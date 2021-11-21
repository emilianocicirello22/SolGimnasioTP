using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;


namespace Datos
{
    public class Sala
    {
        public static void AgregarSala(string nombre)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"INSERT INTO salas (Nombre) values (@valor)";

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", nombre);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }
        public static DataTable MostrarSala(string nombre)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from salas where Nombre like '%" + nombre + "%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }
        public static void ModificarSala(string descripcion, int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE salas SET Nombre=@valor where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@valor", descripcion);
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }
        public static void BorrarSala(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from salas where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable TraerAllSalas()
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from salas";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }



    }
}
