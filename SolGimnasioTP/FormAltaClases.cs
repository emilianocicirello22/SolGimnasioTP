using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormAltaClases : Form
    {
        
        public FormAltaClases()
        {
            InitializeComponent();
            CargarClase(DgwMostrarClases);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCamposVacios())
            {
                DialogResult btn = MessageBox.Show("¿Esta seguro de que desea Guardar los datos de la clase?", "Guardar clase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (btn == DialogResult.Yes)
                {
                    Datos.Clases.Agregar(CrearClase());
                    MessageBox.Show("¡Clase Guardada!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClase(DgwMostrarClases);
                    LimpiarControles();
                }
            }
        }

        private void CbxClase_DropDown(object sender, EventArgs e)
        {
            CargarDisciplina(CbxClase);
        }
        public void CargarDisciplina(ComboBox cb)
        {
            cb.DataSource = Logica.Disciplina.TraerTodos();
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }

        

        public void CargarProfesor(ComboBox cb)
        {
            cb.DataSource = Logica.Profesor.MostrarProfesor();
            cb.DisplayMember = "Profesor";
            cb.ValueMember = "ID";
        }

        private void CbxProfesor_DropDown(object sender, EventArgs e)
        {
            CargarProfesor(CbxProfesor);
        }

        private void TxtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CbxSala_DropDown(object sender, EventArgs e)
        {
            CargarSalas(CbxSala);
        }

        public void CargarSalas(ComboBox cb)
        {
            cb.DataSource = Logica.Sala.TraerAllSalas();
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }

        private bool ValidarCamposVacios()
        {
            bool ok = true;

            if (CbxSala.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CbxSala, "Seleccione una Sala");
            }
            if (CbxProfesor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CbxProfesor, "Seleccione un Profesor");
            }
            if (CbxClase.Text == "")
            {
                ok = false;
                errorProvider1.SetError(CbxClase, "Seleccione una Clase");
            }
            if (TxtDuracion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TxtDuracion, "Ingrese las horas de duracion de la clase");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(CbxProfesor, "");
            errorProvider1.SetError(CbxClase, "");
            errorProvider1.SetError(CbxSala, "");
            errorProvider1.SetError(TxtDuracion, "");
        }

        private Entidades.Clases CrearClase()
        {
            Entidades.Clases cl = new Entidades.Clases();

            cl.Profesor = CbxProfesor.SelectedIndex + 1;
            cl.Sala = CbxSala.SelectedIndex + 1;
            cl.Disciplina = CbxClase.SelectedIndex + 1;
            cl.Duracion = int.Parse(TxtDuracion.Text);

            return cl;
        }
        
        private void LimpiarControles()
        {
            foreach(Control ct in this.Controls)
            {
                if(ct is ComboBox)
                {
                    ct.Text = null;
                }
                if (ct is TextBox)
                {
                    ct.Text = "";
                }
            }
        }

        public void CargarClase(DataGridView cb)
        {
            cb.DataSource = Logica.Clases.MostrarClases();
            
        }

       
    }
}
