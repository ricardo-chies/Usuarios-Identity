using Microsoft.AspNetCore.Mvc;
using Usuarios.API.Dtos.Requests;

namespace Usuarios.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastrarUsuario(CadastroUsuarioRequest request) 
        {
            throw new NotImplementedException();
        }
    }
}
