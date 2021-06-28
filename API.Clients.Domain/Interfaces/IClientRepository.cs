using API.Clients.Domain.Models.ViewModel.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Domain.Interfaces
{
    public interface IClientRepository
    {
        dynamic RegisterClient(ClientRegister viewModel);

    }
}
