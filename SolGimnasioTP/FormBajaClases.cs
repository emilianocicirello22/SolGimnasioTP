using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormBajaClases : Form
    {
        private int ID;

        public FormBajaClases()
        {
            InitializeComponent();
            CargarClases(this.DgwMostrarClases);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarClases(DataGridView cb)
        {
            cb.DataSource = Logica.Clases.MostrarClases();
        }

        private void DgwMostrarClases_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = 0;
                BtnBorrar.Enabled = true;
                lblClaseDato.Text = DgwMostrarClases.CurrentRow.Cells["Disciplina"].Value.ToString();
                lblProfesorDato.Text = DgwMostrarClases.CurrentRow.Cells["PROFESOR"].Value.ToString();
                lblSalaDato.Text = DgwMostrarClases.CurrentRow.Cells["Sala"].Value.ToString();
                lblDuracionDato.Text = DgwMostrarClases.CurrentRow.Cells["Duracion"].Value.ToString();
                ID = int.Parse(DgwMostrarClases.CurrentRow.Cells["Id"].Value.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("¡No se puede seleccionar esa celda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea Borrar los datos de la clase?", "Borrar clase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Datos.Clases.BorrarClase(ID);
                LimpiarFormulario();
                CargarClases(this.DgwMostrarClases);
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void LimpiarFormulario()
        {
            lblClaseDato.Text = "";
            lblProfesorDato.Text = "";
            lblSalaDato.Text = "";
            lblDuracionDato.Text = "";
            BtnBorrar.Enabled = false;
        }
    }
}
