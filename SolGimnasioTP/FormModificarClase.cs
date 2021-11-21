using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormModificarClase : Form
    {
        private int ID;
        public FormModificarClase()
        {
            InitializeComponent();
            CargarClases(this.DgwMostrarClases);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClases(DataGridView cb)
        {
            cb.DataSource = Logica.Clases.MostrarClasesID();

            DgwMostrarClases.Columns["IDPROF"].Visible = false;
            DgwMostrarClases.Columns["IDDIS"].Visible = false;
            DgwMostrarClases.Columns["IDSAL"].Visible = false;

        }

        private void CargarDisciplina(ComboBox cb)
        {
            cb.DataSource = Logica.Disciplina.TraerTodos();
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }
        private void CargarProfesor(ComboBox cb)
        {
            cb.DataSource = Logica.Profesor.MostrarProfesor();
            cb.DisplayMember = "Profesor";
            cb.ValueMember = "ID";
        }
        private void CargarSalas(ComboBox cb)
        {
            cb.DataSource = Logica.Sala.TraerAllSalas();
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "ID";
        }

        

        private void DgwMostrarClases_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarDisciplina(CbxClase);
            CargarProfesor(CbxProfesor);
            CargarSalas(CbxSala);
            try
            {
                CbxClase.SelectedValue = DgwMostrarClases.CurrentRow.Cells["IDDIS"].Value.ToString();
                CbxProfesor.SelectedValue = DgwMostrarClases.CurrentRow.Cells["IDPROF"].Value.ToString();
                CbxSala.SelectedValue = DgwMostrarClases.CurrentRow.Cells["IDSAL"].Value.ToString();
                TxtDuracion.Text = DgwMostrarClases.CurrentRow.Cells["Duracion"].Value.ToString();
                ID = int.Parse(DgwMostrarClases.CurrentRow.Cells["Id"].Value.ToString());
                BtnModificar.Enabled = true;
                HabilitarControles();
            }
            catch(FormatException) 
            {
                MessageBox.Show("¡No se puede seleccionar esa celda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesHabilitarControles();
            }
            
        }

        private void HabilitarControles()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is ComboBox)
                {
                    ctr.Enabled = true;                   
                }
                if(ctr is TextBox)
                {
                    ctr.Enabled = true;
                }
            }
        }

        private void DesHabilitarControles()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ComboBox)
                {
                    ctr.Enabled = false;
                    
                }
                if (ctr is TextBox)
                {
                    ctr.Enabled = false;
                }
            }

            BtnModificar.Enabled = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea Modificar los datos de la clase?", "Modificar clase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (btn == DialogResult.Yes)
            {
                Entidades.Clases cl1 = new Entidades.Clases();

                cl1.ID = ID;
                cl1.Profesor = int.Parse(CbxProfesor.SelectedValue.ToString());
                cl1.Disciplina = int.Parse(CbxClase.SelectedValue.ToString());
                cl1.Sala = int.Parse(CbxSala.SelectedValue.ToString());
                cl1.Duracion = int.Parse(TxtDuracion.Text);

                Logica.Clases.ModificarClase(cl1);

                CargarClases(this.DgwMostrarClases);

                DesHabilitarControles();
            }
            else
            {
                DesHabilitarControles();
            }
            
        }
    }
}
