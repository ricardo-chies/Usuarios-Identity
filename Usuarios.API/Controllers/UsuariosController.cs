using Microsoft.AspNetCore.Mvc;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Interfaces;

namespace Usuarios.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CadastroUsuarioRequest request) 
        {
            await _usuarioService.CadastrarUsuario(request);
            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUsuario(LoginUsuarioRequest request)
        {
            var token = await _usuarioService.LoginUsuario(request);
            return Ok(token);
        }
    }
}
