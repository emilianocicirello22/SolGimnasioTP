using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Logica
{
    public class Sala
    {
        public static void AgregarSala(string nombre)
        {
            Datos.Sala.AgregarSala(nombre);
        }
        public static DataTable MostrarSala(string nombre)
        {
            return Datos.Sala.MostrarSala(nombre); 
        }
        public static void ModificarSala(string Nombre, int id)
        {
            Datos.Sala.ModificarSala(Nombre, id);
        }
        public static void BorrarSala(int id)
        {
            Datos.Sala.BorrarSala(id);
        }

        public static DataTable TraerAllSalas()
        {
            return Datos.Sala.TraerAllSalas();
        }
    }
}
