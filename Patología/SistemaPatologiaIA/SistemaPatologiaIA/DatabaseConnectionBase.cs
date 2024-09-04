using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaPatologiaIA
{
    public class DatabaseConnectionBase
    {
        private string connectionString;

        // Método para obtener la conexión
        public SqlConnection Connection => new SqlConnection(connectionString);
    }
}