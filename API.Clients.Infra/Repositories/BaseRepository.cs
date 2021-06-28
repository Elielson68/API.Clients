using API.Clients.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Infra.Repositories
{
    public abstract class BaseRepository 
    {
        private readonly ConnectionFactory _configDataBase;

        protected BaseRepository(ConnectionFactory configDataBase)
        {
            this._configDataBase = configDataBase;
        }

        protected IDbConnection CreateConnection()
        {
            Dictionary<string, Connection> connectionString = _configDataBase.Connections;
            return new SqlConnection(connectionString
                                    .Where(x => x.Key == "API.Client.Database")
                                    .Select(x => x.Value.ConnectionString)
                                    .First()
                                    );
        }
    }
}
