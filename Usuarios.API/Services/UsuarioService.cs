using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Entities;
using Usuarios.API.Interfaces;

namespace Usuarios.API.Services
{
    public class UsuarioService(IMapper mapper, UserManager<Usuario> manager, SignInManager<Usuario> signInManager, ITokenService tokenService) : IUsuarioService
    {
        private readonly IMapper _mapper = mapper;
        private readonly UserManager<Usuario> _userManager = manager;
        private readonly SignInManager<Usuario> _signInManager = signInManager;
        private readonly ITokenService _tokenservice = tokenService;

        public async Task CadastrarUsuario(CadastroUsuarioRequest request)
        {
            Usuario usuario = _mapper.Map<Usuario>(request);

            var result = await _userManager.CreateAsync(usuario, request.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário");
            }
        }

        public async Task<string> LoginUsuario(LoginUsuarioRequest request)
        {
            var result = await _signInManager.PasswordSignInAsync(request.Username, request.Password, false, false);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }

            var usuario = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(user => user.NormalizedUserName == request.Username.ToUpper());

            var token = _tokenservice.GenerateToken(usuario);
            return token;
        }
    }
}
