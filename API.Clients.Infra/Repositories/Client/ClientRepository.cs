using API.Clients.Domain.Interfaces;
using API.Clients.Domain.Models.ViewModel.Input;
using API.Clients.Infra.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Infra.Repositories.Client
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(ConnectionFactory configDataBase):base(configDataBase) { }
        public dynamic RegisterClient(ClientRegister viewModel)
        {
            string query = $"INSERT INTO CLIENTS (Name, Email, PhoneNumber) OUTPUT Inserted.* VALUES (" +
                $"'{viewModel.Name}', {viewModel.Email}, {viewModel.PhoneNumber}" +
                $")";
            using (var connection = CreateConnection()) { return connection.Query(query); }
        }
    }
}
