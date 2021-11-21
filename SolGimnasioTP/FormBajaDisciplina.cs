using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormBajaDisciplina : Form
    {
        int ID;

        public FormBajaDisciplina()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxDisciplina_DropDown(object sender, EventArgs e)
        {
            CargarDisciplina(CbxDisciplina);
            BtnBorrar.Enabled = true;
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea borrar los datos de la disciplina?", "Borrar Disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {

                Logica.Disciplina.BorrarDisciplina(ID);
                MessageBox.Show("¡Disciplina Borrada!", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void TxtDescripcionDisciplina_TextChanged(object sender, EventArgs e)
        {
            LvlContador.Text = (TxtDescripcionDisciplina.Text.Length).ToString();
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

            if (CbxDisciplina != null)
            {
                TxtNombreDisciplina.Text = dt.Rows[0]["Nombre"].ToString();
                TxtDescripcionDisciplina.Text = dt.Rows[0]["Descripcion"].ToString();
                ID = int.Parse(dt.Rows[0]["ID"].ToString());
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

                CbxDisciplina.Text = "";
                BtnBorrar.Enabled = false;
                ID = 0;

            }
        }
    }
}
