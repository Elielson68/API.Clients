using API.Clients.Database.Interfaces;
using API.Clients.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Clients.Database.Context
{
    public class ApiContext: DbContext, IApiContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<ClientRegister> Client { get; set; }

    }
}
