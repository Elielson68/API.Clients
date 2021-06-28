using API.Clients.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Clients.Database.Interfaces
{
    public interface IApiContext
    {
        DbSet<ClientRegister> Client { get; set; }

        int SaveChanges();
    }
}
