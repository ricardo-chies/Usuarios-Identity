using Usuarios.API.Dtos.Requests;

namespace Usuarios.API.Interfaces
{
    public interface IUsuarioService
    {
        Task CadastrarUsuario(CadastroUsuarioRequest request);
    }
}
