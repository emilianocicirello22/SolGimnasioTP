using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormAltaProfesor : Form
    {
        public FormAltaProfesor()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();

            if (ValidarCamposVacios())
            {
                Entidades.Profesor p1 = new Entidades.Profesor();

                CargarDatos(p1);
                DialogResult btn = MessageBox.Show("¿Desea guardar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (btn == DialogResult.Yes)
                {
                    Logica.Profesor consulta = new Logica.Profesor();
                    consulta.AgregarProfesor(p1);
                    LimpiarCampos();
                }
                else
                {
                    LimpiarCampos();
                }
                    
            }

            
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            //con este comando se limita el ingreso en los textbox solo a numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (TxtNombreProfesor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombreProfesor, "Ingrese un nombre");
            }
            if (TxtApellidoProfesor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtApellidoProfesor, "Ingrese un apellido");
            }
            if (TxtCelProfesor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtCelProfesor, "Ingrese un numero de celular");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TxtNombreProfesor, "");
            errorProvider1.SetError(TxtApellidoProfesor, "");
            errorProvider1.SetError(TxtCelProfesor, "");
        }

        private void HabilitarNombreFamiliar(object sender, EventArgs e)
        {
            if(!TxtTelFamiliarProfesor.Text.Equals(""))
            {
                TxtNombreFamiliarProfesor.Enabled = true;
            }
            else
            {
                TxtNombreFamiliarProfesor.Enabled = false;
            }
        }

        private void CargarDatos(Entidades.Profesor p1)
        {
            p1.Nombre = TxtNombreProfesor.Text;
            p1.Apellido = TxtApellidoProfesor.Text;

            if (!TxtCelProfesor.Text.Equals(""))
            {
                p1.Cel = Convert.ToInt32(TxtCelProfesor.Text);
            }
            if (!TxtTelProfesor.Text.Equals(""))
            {
                p1.Tel = Convert.ToInt32(TxtTelProfesor.Text);
            }
            if (!TxtTelFamiliarProfesor.Text.Equals(""))
            {
                p1.TelFamiliar = Convert.ToInt32(TxtTelFamiliarProfesor.Text);
            }        
            
            
            p1.NombreFamiliar = TxtNombreFamiliarProfesor.Text;

            if (RbtnMasculino.Checked)
            {
                p1.Sexo = "M";
            }
            if (RbtnFemenino.Checked)
            {
                p1.Sexo = "F";
            }
            if (RbtnOtro.Checked)
            {
                p1.Sexo = "O";
            }
        }

        private void LimpiarCampos()
        {
            foreach (Control ct in this.Controls)
            {
                if(ct is TextBox)
                {
                    ct.Text = "";
                }                
            }
        }
    }
}
