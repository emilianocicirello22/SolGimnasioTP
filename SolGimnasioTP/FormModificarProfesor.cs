using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormModificarProfesor : Form
    {
        int ID;

        public FormModificarProfesor()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.TxtBusquedaProfesor, "Ingrese en nombre o apellido del profesor y presione enter, minimo 3 Caracteres");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusquedaProfesor_KeyPress(object sender, KeyPressEventArgs e)
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
                DT = Logica.Profesor.MostrarProfesorAllDatos(TxtBusquedaProfesor.Text);

                if (DT.Rows.Count >= 1)
                {
                    DgwProfesor.DataSource = DT;
                    DgwProfesor.Visible = true;

                }
                else
                {
                    MessageBox.Show("¡No se encontro al profesor!", "Profesores", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LimpiarControles()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                    ct.Enabled = false;
                }

                if (ct is GroupBox)
                {
                    ct.Enabled = false;
                    foreach (Control rb in ct.Controls)
                    {

                        if (rb is RadioButton)
                        {
                            rb.Enabled = false;
                        }
                    }
                }

                ID = 0;
                RbtnFemenino.Checked = true;
                BtnModificar.Enabled = false;
                TxtBusquedaProfesor.Enabled = true;
            }
        }

        private void SeleccionarProfesor(object sender, EventArgs e)
        {
            ID = 0;
            TxtBusquedaProfesor.Clear();

            if (DgwProfesor.Rows.Count > 0)
            {
                HabilitarControles();
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

                TxtCelProfesor.Text = DgwProfesor.CurrentRow.Cells["Celular"].Value.ToString();
                TxtTelProfesor.Text = DgwProfesor.CurrentRow.Cells["Telefono"].Value.ToString();
                TxtTelFamiliarProfesor.Text = DgwProfesor.CurrentRow.Cells["TelFamiliar"].Value.ToString();
                TxtNombreFamiliarProfesor.Text = DgwProfesor.CurrentRow.Cells["NomFamiliar"].Value.ToString();


                ID = (int)DgwProfesor.CurrentRow.Cells["ID"].Value;
                BtnModificar.Enabled = true;
            }
        }

        private void HabilitarControles()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Enabled = true;
                }

                if (ct is GroupBox)
                {
                    ct.Enabled = true;
                    foreach (Control rb in ct.Controls)
                    {
                        if (rb is RadioButton)
                        {
                            rb.Enabled = true;
                        }
                    }
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
            DialogResult btn = MessageBox.Show("¿Desea guardar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {

                Logica.Profesor.ModificarProfesor(CambioProfesor());
                MessageBox.Show("¡Profesor Modificado!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgwProfesor.Columns.Clear();
                DgwProfesor.Visible = false;
                LimpiarControles();
                
            }
            else
            {
                DgwProfesor.Columns.Clear();
                DgwProfesor.Visible = false;
                LimpiarControles();
                
            }
        }

        private Entidades.Profesor CambioProfesor()
        {
            Entidades.Profesor prof = new Entidades.Profesor();

            prof.ID = ID;
            prof.Nombre = TxtNombreProfesor.Text;
            prof.Apellido = TxtApellidoProfesor.Text;
            prof.Tel = Convert.ToInt32(TxtTelProfesor.Text);
            prof.Cel = Convert.ToInt32(TxtCelProfesor.Text);

            if (RbtnFemenino.Checked)
            {
                prof.Sexo = "F";
            }
            if (RbtnMasculino.Checked)
            {
                prof.Sexo = "M";
            }
            if (RbtnOtro.Checked)
            {
                prof.Sexo = "O";
            }
            prof.TelFamiliar = Convert.ToInt32(TxtTelFamiliarProfesor.Text);
            prof.NombreFamiliar = TxtNombreFamiliarProfesor.Text;

            return prof;
        }

        private void TxtCelProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
