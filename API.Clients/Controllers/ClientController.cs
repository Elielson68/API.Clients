using API.Clients.Database.Interfaces;
using API.Clients.Dto;
using API.Clients.Models;
using API.Clients.Validations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Cors;

namespace API.Clients.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        //context
        private readonly IApiContext _appContext;
        public ClientController(IApiContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            if(_appContext.Client.ToList().Count == 0)
            {
                return NotFound("Empty list");
            }
            List<Client> listClients = new List<Client>();
            _appContext.Client.ToList().ForEach(x => {
                if (x != null)
                {
                    listClients.Add(new Client(x));
                }
            });
            return Ok(listClients);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (_appContext.Client.ToList().Count == 0)
            {
                return NotFound("Empty list");
            }
            ClientRegister clientDb = _appContext.Client.FirstOrDefault(x => x.ClientId == id);
            if (clientDb == null)
            {
                return NotFound("Client not found");
            }
            Client clientDto = new Client(clientDb);
            return Ok(clientDto);
        }

        [HttpPost]
        public IActionResult Post(Client newClient)
        {
            if(newClient == null)
            {
                return NotFound("Null client");
            }
            RegisterClientValidation validator = new RegisterClientValidation();
            var validatorResult =  validator.Validate(newClient);
            if (!validatorResult.IsValid)
            {
                return NotFound(validatorResult.Errors.FirstOrDefault());
            }
            ClientRegister client = new ClientRegister(newClient);
            _appContext.Client.Add(client);
            _appContext.SaveChanges();
            return Ok(newClient);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Client client)
        {
            if(client == null)
            {
                return NotFound("Null client");
            }
            ClientRegister clientUpdate = new ClientRegister(client);
            clientUpdate.ClientId = id;
            _appContext.Client.Update(clientUpdate);
            _appContext.SaveChanges();
            return Ok(client);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ClientRegister clientDb = _appContext.Client.FirstOrDefault(x => x.ClientId == id);
            if (clientDb == null)
            {
                return NotFound("Client not found");
            }
            _appContext.Client.Remove(clientDb);
            _appContext.SaveChanges();
            return Ok("Client removed");
        }
    }
}
