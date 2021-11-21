using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Logica
{
    public class Clases
    {
        public static void Agregar(Entidades.Clases dis)
        {
            Datos.Clases.Agregar(dis);
        }

        public static DataTable MostrarClases()
        {
            return Datos.Clases.MostrarClases();
        }

        public static void BorrarClase(int id)
        {
            Datos.Clases.BorrarClase(id);
        }

        public static DataTable MostrarClasesID()
        {
            return Datos.Clases.MostrarClasesID();
        }

        public static void ModificarClase(Entidades.Clases cla)
        {
            Datos.Clases.ModificarClase(cla);
        }
    }
}
