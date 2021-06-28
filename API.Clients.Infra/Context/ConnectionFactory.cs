using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Infra.Context
{
    public class ConnectionFactory
    {
        public Dictionary<string, Connection> Connections { get; set; }
    }

    public class Connection
    {
        public string Server { get; set; }
        public string Base { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString
        {
            get
            {
                return  $"Data Source={Server};"+
                        $"Initial Catalog={Base};"+
                        $"Persist Security Info=False;"+
                        $"User ID={User};"+
                        $"Password={Password}";

            }
        }
    }
}
