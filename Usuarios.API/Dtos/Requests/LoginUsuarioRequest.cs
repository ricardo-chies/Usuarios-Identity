namespace Usuarios.API.Dtos.Requests
{
    public record LoginUsuarioRequest
    {
        public required string Username { get; init; } = string.Empty;
        public required string Password { get; init; } = string.Empty;
    }
}
