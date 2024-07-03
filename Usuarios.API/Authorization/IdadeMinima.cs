using Microsoft.AspNetCore.Authorization;

namespace Usuarios.API.Authorization
{
    public class IdadeMinima(int idade) : IAuthorizationRequirement
    {
        public int Idade { get; set; } = idade;
    }
}
