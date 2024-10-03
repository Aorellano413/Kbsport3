using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class ConexionDAL
    {
        private string connectionString;

        public ConexionDAL()
        {
            connectionString = "server=localhost;database=Kb_sport3;uid=root;pwd=Tatareto10;";
        }

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void CerrarConexion(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
