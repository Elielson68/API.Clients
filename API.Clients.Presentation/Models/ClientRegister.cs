using API.Clients.Dto;
using System.ComponentModel.DataAnnotations;

namespace API.Clients.Models
{
    public class ClientRegister
    {
        public ClientRegister(Client client)
        {
            Name = client.Name;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
        }
        public ClientRegister() { }

        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
