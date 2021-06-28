using API.Clients.Models;
using System.ComponentModel.DataAnnotations;

namespace API.Clients.Dto
{
 
    public class Client
    {   
        public Client(ClientRegister client)
        {
            ClientId = client.ClientId;
            Name = client.Name;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
        }
        public Client() { }

        public int ClientId { get;  set; }

        [Required(ErrorMessage = "Field 'Name' don't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field 'Email' don't be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field 'PhoneNumber' don't be empty")]
        public string PhoneNumber { get; set; }
    }
}
