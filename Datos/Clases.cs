using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace Datos
{
    public class Clases
    {
        public static void Agregar(Entidades.Clases dis)
        {
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            string sqlString = @"insert into clases(Profesor, Disciplina, Sala, Duracion) values(@profesor, @disciplina, @sala, @duracion)";

            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            objMySqlcommand.Parameters.AddWithValue("@profesor", dis.Profesor);
            objMySqlcommand.Parameters.AddWithValue("@disciplina", dis.Disciplina);
            objMySqlcommand.Parameters.AddWithValue("@sala", dis.Sala);
            objMySqlcommand.Parameters.AddWithValue("@duracion", dis.Duracion);
            
            objconexion.Open();

            objMySqlcommand.ExecuteNonQuery();

            objconexion.Close();
        }

        public static DataTable MostrarClases()
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "SELECT cl.Id , concat_ws(' ', p.Nombre, p.Apellido) AS 'PROFESOR', ds.Nombre  AS 'Disciplina', sl.Nombre AS 'Sala', cl.Duracion FROM clases AS cl  INNER JOIN profesores AS p ON  cl.Profesor = p.Id INNER JOIN disciplinas AS ds ON cl.Disciplina = ds.Id INNER JOIN salas AS sl ON cl.Sala = sl.Id ORDER BY cl.Id desc";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }

        public static DataTable MostrarClasesID()
        {
            //Creamos data table
            DataTable dt = new DataTable();

            //Realizamos la consulta
            string strSQL = "SELECT p.ID AS 'IDPROF', ds.ID AS 'IDDIS' ,sl.ID AS 'IDSAL', cl.Id , concat_ws(' ', p.Nombre, p.Apellido) AS 'PROFESOR', ds.Nombre  AS 'Disciplina', sl.Nombre AS 'Sala', cl.Duracion FROM clases AS cl  INNER JOIN profesores AS p ON  cl.Profesor = p.Id INNER JOIN disciplinas AS ds ON cl.Disciplina = ds.Id INNER JOIN salas AS sl ON cl.Sala = sl.Id ORDER BY cl.Id desc";

            MySqlDataAdapter objDataTraer = new MySqlDataAdapter(strSQL, Conexion.connectorMysql());

            objDataTraer.Fill(dt);

            return dt;
        }



        public static void BorrarClase(int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"delete from clases where ID = @id"; ;

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

        public static void ModificarClase(Entidades.Clases cla)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.connectorMysql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE clases SET Profesor=@Profesor, Disciplina=@disciplina, Sala=@sala, Duracion=@duracion where ID = @id"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@Profesor", cla.Profesor);
            objMySqlcommand.Parameters.AddWithValue("@disciplina", cla.Disciplina);
            objMySqlcommand.Parameters.AddWithValue("@sala", cla.Sala);
            objMySqlcommand.Parameters.AddWithValue("@duracion", cla.Duracion);
            objMySqlcommand.Parameters.AddWithValue("@id", cla.ID);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }
    }



    /*SELECT p.ID AS 'IDPROF', ds.ID AS 'IDDIS' ,sl.ID AS 'IDSAL', cl.Id, concat_ws(' ', p.Nombre, p.Apellido) AS 'Nombre y Apellido PROFESOR', ds.Nombre  AS 'Disciplina', sl.Nombre AS 'Sala'

    FROM clases AS cl  INNER JOIN

            profesores AS p ON  cl.Profesor = p.Id INNER JOIN

            disciplinas AS ds ON cl.Disciplina = ds.Id INNER JOIN

            salas AS sl ON cl.Sala = sl.Id";*/
}
