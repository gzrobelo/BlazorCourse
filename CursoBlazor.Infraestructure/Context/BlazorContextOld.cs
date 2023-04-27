using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBlazor.Infraestructure.Context
{
    public class BlazorContextOld
    {
        private readonly IConfiguration Configuration;
        private readonly string ConnectionString = string.Empty;

        public BlazorContextOld(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(ConnectionString);
    }
}
