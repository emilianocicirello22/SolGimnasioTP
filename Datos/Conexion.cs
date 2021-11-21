using System;
using MySqlConnector;

namespace Datos
{
    public class Conexion
    {
        internal static string strConexion = "";
        public static string connectorMysql()
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Add("Data Source", "localhost");
            connBuilder.Add("Port", "3306");
            connBuilder.Add("Database", "gimnasioentrenarmas");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            strConexion = connBuilder.ConnectionString;
            return strConexion;
        }
    }
}
