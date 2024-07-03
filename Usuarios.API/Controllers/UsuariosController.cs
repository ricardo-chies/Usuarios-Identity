using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Entities;

namespace Usuarios.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuariosController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuariosController(IMapper mapper, UserManager<Usuario> manager)
        {
            _mapper = mapper;
            _userManager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CadastroUsuarioRequest request) 
        {
            Usuario usuario = _mapper.Map<Usuario>(request);

            var result = await _userManager.CreateAsync(usuario, request.Password);

            if (result.Succeeded) return Ok("Usuário cadastrado!");

            throw new ApplicationException("Falha ao cadastrar usuário");
        }
    }
}
