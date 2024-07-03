using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Entities;
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
    }
}
