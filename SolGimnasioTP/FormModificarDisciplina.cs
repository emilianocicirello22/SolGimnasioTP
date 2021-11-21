using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormModificarDisciplina : Form
    {
        int ID;

        public FormModificarDisciplina()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.TxtNombreDisciplina, "Ingrese el nombre de la disciplina");
            toolTip1.SetToolTip(this.TxtDescripcionDisciplina, "Ingrese descripcion de la disciplina 250 caracteres");
        }

        private void TxtDescripcionDisciplina_TextChanged(object sender, EventArgs e)
        {
            LvlContador.Text = (TxtDescripcionDisciplina.Text.Length).ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDisciplina(ComboBox cb)
        {
            cb.DataSource = Logica.Disciplina.TraerTodos();
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }

        private void CbxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

            int iddis = CbxDisciplina.SelectedIndex;
            DataTable dt = Datos.Disciplina.TraerDisciplina(iddis + 1);

            
            TxtNombreDisciplina.Text = dt.Rows[0]["Nombre"].ToString();
            TxtDescripcionDisciplina.Text = dt.Rows[0]["Descripcion"].ToString();
            ID = int.Parse(dt.Rows[0]["ID"].ToString());


        }

        private void CbxDisciplina_DropDown(object sender, EventArgs e)
        {
            CargarDisciplina(CbxDisciplina);
            BtnModificar.Enabled = true;
            TxtNombreDisciplina.Enabled = true;
            TxtDescripcionDisciplina.Enabled = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCamposVacios())
            {
                DialogResult btn = MessageBox.Show("¿Esta seguro de que desea modificar los datos de la disciplina?", "Modificar Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (btn == DialogResult.Yes)
                {
                    Entidades.Disciplina objdi = new Entidades.Disciplina();
                    objdi.ID = ID;
                    objdi.Nombre = TxtNombreDisciplina.Text;
                    objdi.Descripcion = TxtDescripcionDisciplina.Text;

                    Logica.Disciplina.ModificarDisciplina(objdi);
                    MessageBox.Show("¡Disciplina Modificada!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
        }

        private void LimpiarFormulario()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";

                }
                BtnModificar.Enabled = false;

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
    }
}
