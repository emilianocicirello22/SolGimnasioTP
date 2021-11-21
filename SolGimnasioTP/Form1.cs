using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarForm(Form Formulario)
        {
            Formulario.MdiParent = this;
            Formulario.StartPosition = FormStartPosition.CenterScreen;
            Formulario.Show();
        }

        

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MostrarForm(new FormAltaProfesor());
        }
        

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormSala());
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormSalaBorrar());
        }

        private void crearModificarBorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormAltaSala());
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormBajaProfesor());
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormModificarProfesor());
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormAltaDisciplina());
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormModificarDisciplina());
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormBajaDisciplina());
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormAltaClases());
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormBajaClases());
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormModificarClase());
        }

        private void verProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormVerProfesores());
        }

        private void verSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new FormVerSalas());
        }
    }
}
