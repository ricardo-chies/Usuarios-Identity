using Microsoft.AspNetCore.Identity;

namespace Usuarios.API.Entities
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario() : base() { }
    }
}
