using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Usuarios.API.Entities;

namespace Usuarios.API.Data
{
    public class Context : IdentityDbContext<Usuario>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
