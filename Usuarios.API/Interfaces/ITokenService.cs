using Usuarios.API.Entities;

namespace Usuarios.API.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}
