using System.ComponentModel.DataAnnotations;

namespace Usuarios.API.Dtos.Requests
{
    public record CadastroUsuarioRequest()
    {
        public required string Username { get; init; } = string.Empty;
        public required DateTime DataNascimento { get; init; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; init; } = string.Empty;
        [DataType(DataType.Password)]
        public required string Password { get; init; } = string.Empty;
        [Compare("Password")]
        public required string ConfirmPassword { get; init; } = string.Empty;
    }
}
