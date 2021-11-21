using System;
using System.Data;

namespace Logica
{
    public class Profesor
    {
        public void AgregarProfesor(Entidades.Profesor p1)
        {
            Datos.Profesor.Agregar(p1);
        }

        public static DataTable MostrarProfesor(string nombre)
        {
            return Datos.Profesor.MostrarProfesor(nombre);
        }

        public static void BorrarProfesor(int id)
        {
            Datos.Profesor.BorrarProfesor(id);
        }
        public static DataTable MostrarProfesorAllDatos(string nombre)
        {
            return Datos.Profesor.MostrarProfesorAllDatos(nombre);
        }
        public static void ModificarProfesor(Entidades.Profesor prof)
        {
            Datos.Profesor.ModificarProfesor(prof);
        }

        public static DataTable MostrarProfesor()
        {
            return Datos.Profesor.MostrarProfesor();
        }
        public static DataTable MostrarProfesorAll()
        {
            return Datos.Profesor.MostrarProfesorAll();
        }

    }
}
