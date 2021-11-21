using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormBajaProfesor : Form
    {
        int ID;
        public FormBajaProfesor()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.TxtBusquedaProfesor, "Ingrese Nombre o apellido del profesor y presione enter para buscar");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ConsultarExistencia()
        {

            DataTable DT = null;

            if (TxtBusquedaProfesor.Text.Length >= 3)
            {
                DT = Logica.Profesor.MostrarProfesor(TxtBusquedaProfesor.Text);

                if (DT.Rows.Count >= 1)
                {
                    DgwProfesor.DataSource = DT;
                    DgwProfesor.Visible = true;
                }
                else
                {
                    MessageBox.Show("¡No se encontro al profesor!", "Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtBusquedaProfesor.Clear();
                    DgwProfesor.Visible = false;
                    LimpiarControles();
                }
            }
            else
            {
                DgwProfesor.Columns.Clear();
                DgwProfesor.Visible = false;
            }
        }

        private void SeleccionarProfesor(object sender, EventArgs e)
        {
            ID = 0;
            TxtBusquedaProfesor.Clear();

            if (DgwProfesor.Rows.Count > 0)
            {
                TxtNombreProfesor.Text = DgwProfesor.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtApellidoProfesor.Text = DgwProfesor.CurrentRow.Cells["Apellido"].Value.ToString();

                string sexo = DgwProfesor.CurrentRow.Cells["Sexo"].Value.ToString();

                if (sexo.Equals("F"))
                {
                    RbtnFemenino.Checked = true;
                }
                if (sexo.Equals("M"))
                {
                    RbtnMasculino.Checked = true;
                }
                if (sexo.Equals("O"))
                {
                    RbtnOtro.Checked = true;
                }

                ID = (int)DgwProfesor.CurrentRow.Cells["ID"].Value;
                BtnBorrar.Enabled = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea eliminar los datos del profesor?", "Eliminar profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {
                Logica.Profesor.BorrarProfesor(ID);
                MessageBox.Show("¡Profesor Borrado!", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgwProfesor.Columns.Clear();
                DgwProfesor.Visible = false;
                LimpiarControles();
                BtnBorrar.Enabled = false;
            }
            else
            {
                BtnBorrar.Enabled = false;
                LimpiarControles();
                DgwProfesor.Columns.Clear();
                DgwProfesor.Visible = false;
            }
        }

        private void LimpiarControles()
        {
            TxtNombreProfesor.Text = "";
            TxtApellidoProfesor.Text = "";
            RbtnFemenino.Checked = true;
            ID = 0;
        }

        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (TxtBusquedaProfesor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtBusquedaProfesor, "Ingrese el nombre o apellido del profesor");
                TxtBusquedaProfesor.Clear();
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TxtBusquedaProfesor, "");

        }
    }
}