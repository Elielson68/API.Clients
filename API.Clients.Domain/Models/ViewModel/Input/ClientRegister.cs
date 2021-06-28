using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Domain.Models.ViewModel.Input
{
    public class ClientRegister
    {        
        [Required(ErrorMessage = "Field 'Name' don't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field 'Email' don't be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field 'PhoneNumber' don't be empty")]
        public string PhoneNumber { get; set; }
    }
}
