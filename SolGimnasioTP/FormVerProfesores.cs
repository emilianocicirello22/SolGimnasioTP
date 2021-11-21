using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormVerProfesores : Form
    {
        public FormVerProfesores()
        {
            InitializeComponent();
            MostrarProfesor(DgwProfesor);
        }

        private void MostrarProfesor(DataGridView prf)
        {
            prf.DataSource = Logica.Profesor.MostrarProfesorAll();
        }
    }
}
