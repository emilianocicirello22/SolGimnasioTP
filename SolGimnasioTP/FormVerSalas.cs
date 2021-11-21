using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolGimnasioTP
{
    public partial class FormVerSalas : Form
    {
        public FormVerSalas()
        {
            InitializeComponent();
            MostrarSalas(this.DgwSalas);
        }

        private void MostrarSalas(DataGridView dt)
        {
            dt.DataSource = Logica.Sala.TraerAllSalas();
        }
    }
}
