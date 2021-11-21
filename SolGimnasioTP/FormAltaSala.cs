using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormAltaSala : Form
    {
        public FormAltaSala()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.TxtNombreSala, "Ingrese descripcion de la sala");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();

            if (ValidarCamposVacios())
            {
                DialogResult btn = MessageBox.Show("¿Esta seguro de que desea Guardar los datos de la sala?", "Guardar sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (btn == DialogResult.Yes)
                {
                    Logica.Sala.AgregarSala(TxtNombreSala.Text);
                    MessageBox.Show("¡Sala Guardada!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreSala.Clear();
                }
            }
            
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (TxtNombreSala.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombreSala, "Ingrese el nombre de la sala");
                TxtNombreSala.Clear();
            }


            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TxtNombreSala, "");

        }

        
        

    }
}
