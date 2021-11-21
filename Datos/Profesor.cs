using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace Datos
{
    public class Profesor
    {
        public static void Agregar(Entidades.Profesor p1)
        {
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            string sqlString = @"insert into profesores(Nombre, Apellido, Sexo, Telefono, Celular, TelFamiliar, NomFamiliar) values(@nombre, @apellido, @sexo, @telefono, @celular, @telfamiliar, @nomfamiliar)";

            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            objMySqlcommand.Parameters.AddWithValue("@nombre", p1.Nombre);
            objMySqlcommand.Parameters.AddWithValue("@apellido", p1.Apellido);
            objMySqlcommand.Parameters.AddWithValue("@sexo", p1.Sexo);
            objMySqlcommand.Parameters.AddWithValue("@telefono", p1.Tel);
            objMySqlcommand.Parameters.AddWithValue("@celular", p1.Cel);
            objMySqlcommand.Parameters.AddWithValue("@telfamiliar", p1.TelFamiliar);
            objMySqlcommand.Parameters.AddWithValue("@nomfamiliar", p1.NombreFamiliar);

            objconexion.Open();

            objMySqlcommand.ExecuteNonQuery();

            objconexion.Close();
        }
        public static DataTable MostrarProfesor(string nombre)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select ID, Nombre, Apellido, Sexo from profesores where Nombre like '%" + nombre + "%' or Apellido like '%" + nombre + "%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }
        public static void BorrarProfesor(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from profesores where ID = @id"; ;

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
        public static DataTable MostrarProfesorAllDatos(string nombre)
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from profesores where Nombre like '%" + nombre + "%' or Apellido like '%" + nombre + "%'";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }
        public static void ModificarProfesor(Entidades.Profesor prof)
        {
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            string sqlString = @"UPDATE profesores SET Nombre= @nombre, Apellido= @apellido, Sexo= @sexo, Telefono= @telefono, Celular=@celular, TelFamiliar= @telfam,  NomFamiliar= @nomfam where ID = @id";

            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            objMySqlcommand.Parameters.AddWithValue("@nombre", prof.Nombre);
            objMySqlcommand.Parameters.AddWithValue("@apellido", prof.Apellido);
            objMySqlcommand.Parameters.AddWithValue("@sexo", prof.Sexo);
            objMySqlcommand.Parameters.AddWithValue("@telefono", prof.Tel);
            objMySqlcommand.Parameters.AddWithValue("@celular", prof.Cel);
            objMySqlcommand.Parameters.AddWithValue("@telfam", prof.TelFamiliar);
            objMySqlcommand.Parameters.AddWithValue("@nomfam", prof.NombreFamiliar);
            objMySqlcommand.Parameters.AddWithValue("@id", prof.ID);

            objconexion.Open();

            objMySqlcommand.ExecuteNonQuery();

            objconexion.Close();
        }

        public static DataTable MostrarProfesor()
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select ID, CONCAT(Nombre, ' ', Apellido) As Profesor from profesores";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }

        public static DataTable MostrarProfesorAll()
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "select * from profesores";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }
    }




    
}
