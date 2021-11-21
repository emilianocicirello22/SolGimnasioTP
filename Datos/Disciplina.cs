using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;

namespace Datos
{
    public class Disciplina
    {
        public static void AgregarDisciplina(string nombre, string descripcion)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"INSERT INTO disciplinas (Nombre, Descripcion) values (@nombre,@descripcion)";

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@nombre", nombre);
            objMySqlcommand.Parameters.AddWithValue("@descripcion", descripcion);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strSQL = "select ID,Nombre from disciplinas";

            MySqlDataAdapter objDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataAdapterTraer.Fill(dt);

            return dt;
        }

        public static DataTable TraerDisciplina(int id)
        {
            DataTable dt = new DataTable();

            string strSQL = "select ID, Nombre, Descripcion from disciplinas where ID ="+id;

            MySqlDataAdapter objDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataAdapterTraer.Fill(dt);

            return dt;
        }

        public static void ModificarDisciplina(Entidades.Disciplina dis)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE disciplinas SET Nombre=@nombre, Descripcion=@descripcion where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@nombre", dis.Nombre);
            objMySqlcommand.Parameters.AddWithValue("@id", dis.ID);
            objMySqlcommand.Parameters.AddWithValue("@descripcion", dis.Descripcion);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static void BorrarDisciplina(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from disciplinas where ID = @id"; ;

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
    }
}
