using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormSalaBorrar : Form
    {
        
        public FormSalaBorrar()
        {
            InitializeComponent();

            this.toolTip1.SetToolTip(this.TxtNombreSala, "Ingrese nombre de la sala, para buscar presione ENTER min 4 caracteres");
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
                    BtnBorrar.Enabled = true;
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
                LvlNombreSala.Text = DgwSala.CurrentRow.Cells["Nombre"].Value.ToString();
                LvlIDSala.Text = DgwSala.CurrentRow.Cells["ID"].Value.ToString();
                LvlNombreSala.Visible=true;
                LvlIDSala.Visible = true;
                BtnBorrar.Enabled = true;


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

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombreSala_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea borrar los datos de la sala?", "Borrar sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {                
                int ID = int.Parse(LvlIDSala.Text);

                Logica.Sala.BorrarSala(ID);

                TxtNombreSala.Clear();
                BtnBorrar.Enabled = false;                
                DgwSala.Columns.Clear();
                DgwSala.Visible = false;
                LvlIDSala.Text = "ID";
                LvlNombreSala.Text = "Nombre";
                LvlIDSala.Visible = false;
                LvlNombreSala.Visible = false;

            }
            else
            {
                LvlIDSala.Text = "ID";
                LvlNombreSala.Text = "Nombre";
                LvlIDSala.Visible = false;
                LvlNombreSala.Visible = false;
                BtnBorrar.Enabled = false;
            }
        }
    }
}
