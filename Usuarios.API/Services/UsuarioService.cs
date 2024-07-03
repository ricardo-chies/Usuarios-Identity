using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Entities;
using Usuarios.API.Interfaces;

namespace Usuarios.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuarioService(IMapper mapper, UserManager<Usuario> manager)
        {
            _mapper = mapper;
            _userManager = manager;
        }
        public async Task CadastrarUsuario(CadastroUsuarioRequest request)
        {
            Usuario usuario = _mapper.Map<Usuario>(request);

            var result = await _userManager.CreateAsync(usuario, request.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário");
            }
        }
    }
}
