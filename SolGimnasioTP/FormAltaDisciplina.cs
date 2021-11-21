using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormAltaDisciplina : Form
    {
        public FormAltaDisciplina()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.TxtNombreDisciplina, "Ingrese el nombre de la disciplina");
            toolTip1.SetToolTip(this.TxtDescripcionDisciplina, "Ingrese descripcion de la disciplina 250 caracteres");
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
                DialogResult btn = MessageBox.Show("¿Esta seguro de que desea Guardar los datos de la disciplina?", "Guardar disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (btn == DialogResult.Yes)
                {
                    Logica.Disciplina.AgregarDisciplina(TxtNombreDisciplina.Text, TxtDescripcionDisciplina.Text);
                    MessageBox.Show("¡Disciplina Guardada!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreDisciplina.Clear();
                    TxtDescripcionDisciplina.Clear();
                }
            }
        }

        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (TxtNombreDisciplina.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombreDisciplina, "Ingrese el nombre de la disciplina");
                TxtNombreDisciplina.Clear();
            }
            if (TxtDescripcionDisciplina.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtNombreDisciplina, "Ingrese el descripcion de la disciplina, 250 caracteres maximo");
                TxtNombreDisciplina.Clear();
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TxtNombreDisciplina, "");
            errorProvider1.SetError(TxtDescripcionDisciplina, "");
        }

        private void TxtDescripcionDisciplina_TextChanged(object sender, EventArgs e)
        {
            LvlContador.Text = (TxtDescripcionDisciplina.Text.Length).ToString();
        }
    }
}
