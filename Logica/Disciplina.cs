using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;


namespace Logica
{
    public class Disciplina
    {
        public static void AgregarDisciplina(string nombre, string descripcion)
        {
            Datos.Disciplina.AgregarDisciplina(nombre, descripcion);
        }

        public static DataTable TraerTodos()
        {
            return Datos.Disciplina.TraerTodos();
        }

        public static DataTable TraerDisciplina(int id)
        {
            return Datos.Disciplina.TraerDisciplina(id);
        }

        public static void ModificarDisciplina(Entidades.Disciplina dis)
        {
            Datos.Disciplina.ModificarDisciplina(dis);
        }

        public static void BorrarDisciplina(int id)
        {
            Datos.Disciplina.BorrarDisciplina(id);
        }
    }
}
