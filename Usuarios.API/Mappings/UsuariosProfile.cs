using AutoMapper;
using Usuarios.API.Dtos.Requests;
using Usuarios.API.Entities;

namespace Usuarios.API.Mappings
{
    public class UsuariosProfile : Profile
    {
        public UsuariosProfile() 
        {
            CreateMap<CadastroUsuarioRequest, Usuario>();
        }
    }
}
