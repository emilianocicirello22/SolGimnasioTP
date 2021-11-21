using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormSala : Form
    {
        int ID;

        public FormSala()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarExistencia()
        {           

            DataTable DT = null;

            if (TxtNombreSala.Text.Length >= 3)
            {
                DT = Logica.Sala.MostrarSala(TxtNombreSala.Text);

                if (DT.Rows.Count >= 1)
                {
                    DgwSala.DataSource = DT;
                    DgwSala.Visible = true;

                }
                else
                {
                    MessageBox.Show("¡No se encontro la sala disponible!", "Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreSala.Clear();
                }
            }
            else
            {
                DgwSala.Columns.Clear();
                DgwSala.Visible = false;
            }

        }

        private void SeleccionarSala(object sender, EventArgs e)
        {
            TxtNombreSala.Clear();

            if (DgwSala.Rows.Count > 0)
            {
                TxtNombreSala.Text = DgwSala.CurrentRow.Cells["Nombre"].Value.ToString();
                ID = (int)DgwSala.CurrentRow.Cells["ID"].Value;
                BtnModificar.Enabled = true;
            }
            
        }

        private void TxtNombreSala_KeyPress(object sender, KeyPressEventArgs e)
        {    
            


            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (ValidarCamposVacios())
                {
                    BorrarMensajeError();
                    ConsultarExistencia();
                }                     
            }

        }

        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (TxtNombreSala.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombreSala, "Ingrese el nombre de la sala, minimo 3 caracteres");
                TxtNombreSala.Clear();
            }


            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TxtNombreSala, "");

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea modificar los datos de la sala?", "Modificar sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {

                string nom = TxtNombreSala.Text;

                Logica.Sala.ModificarSala(nom, ID);

                TxtNombreSala.Clear();
                BtnModificar.Enabled = false;
                ID = 0;
                DgwSala.Columns.Clear();
                DgwSala.Visible = false;
            }
        }
    }
}
