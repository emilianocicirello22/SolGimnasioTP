
namespace SolGimnasioTP
{
    partial class FormAltaClases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CbxClase = new System.Windows.Forms.ComboBox();
            this.LblNombreClase = new System.Windows.Forms.Label();
            this.LvlProfesor = new System.Windows.Forms.Label();
            this.CbxProfesor = new System.Windows.Forms.ComboBox();
            this.LvlSala = new System.Windows.Forms.Label();
            this.CbxSala = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LvlDuracion = new System.Windows.Forms.Label();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.LvlHs = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DgwMostrarClases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwMostrarClases)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxClase
            // 
            this.CbxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxClase.FormattingEnabled = true;
            this.CbxClase.Location = new System.Drawing.Point(319, 45);
            this.CbxClase.Name = "CbxClase";
            this.CbxClase.Size = new System.Drawing.Size(328, 23);
            this.CbxClase.TabIndex = 2;
            this.CbxClase.DropDown += new System.EventHandler(this.CbxClase_DropDown);
            // 
            // LblNombreClase
            // 
            this.LblNombreClase.AutoSize = true;
            this.LblNombreClase.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreClase.ForeColor = System.Drawing.Color.White;
            this.LblNombreClase.Location = new System.Drawing.Point(72, 39);
            this.LblNombreClase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreClase.Name = "LblNombreClase";
            this.LblNombreClase.Size = new System.Drawing.Size(70, 25);
            this.LblNombreClase.TabIndex = 33;
            this.LblNombreClase.Text = "Clase";
            // 
            // LvlProfesor
            // 
            this.LvlProfesor.AutoSize = true;
            this.LvlProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlProfesor.ForeColor = System.Drawing.Color.White;
            this.LvlProfesor.Location = new System.Drawing.Point(72, 117);
            this.LvlProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlProfesor.Name = "LvlProfesor";
            this.LvlProfesor.Size = new System.Drawing.Size(100, 25);
            this.LvlProfesor.TabIndex = 34;
            this.LvlProfesor.Text = "Profesor";
            // 
            // CbxProfesor
            // 
            this.CbxProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProfesor.FormattingEnabled = true;
            this.CbxProfesor.Location = new System.Drawing.Point(319, 123);
            this.CbxProfesor.Name = "CbxProfesor";
            this.CbxProfesor.Size = new System.Drawing.Size(328, 23);
            this.CbxProfesor.TabIndex = 35;
            this.CbxProfesor.DropDown += new System.EventHandler(this.CbxProfesor_DropDown);
            // 
            // LvlSala
            // 
            this.LvlSala.AutoSize = true;
            this.LvlSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlSala.ForeColor = System.Drawing.Color.White;
            this.LvlSala.Location = new System.Drawing.Point(72, 188);
            this.LvlSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlSala.Name = "LvlSala";
            this.LvlSala.Size = new System.Drawing.Size(58, 25);
            this.LvlSala.TabIndex = 36;
            this.LvlSala.Text = "Sala";
            // 
            // CbxSala
            // 
            this.CbxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSala.FormattingEnabled = true;
            this.CbxSala.Location = new System.Drawing.Point(319, 194);
            this.CbxSala.Name = "CbxSala";
            this.CbxSala.Size = new System.Drawing.Size(328, 23);
            this.CbxSala.TabIndex = 37;
            this.CbxSala.DropDown += new System.EventHandler(this.CbxSala_DropDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(567, 492);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 39;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(319, 492);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(220, 69);
            this.BtnGuardar.TabIndex = 38;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LvlDuracion
            // 
            this.LvlDuracion.AutoSize = true;
            this.LvlDuracion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlDuracion.ForeColor = System.Drawing.Color.White;
            this.LvlDuracion.Location = new System.Drawing.Point(72, 264);
            this.LvlDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlDuracion.Name = "LvlDuracion";
            this.LvlDuracion.Size = new System.Drawing.Size(226, 25);
            this.LvlDuracion.TabIndex = 40;
            this.LvlDuracion.Text = "Duracion de la clase";
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.Location = new System.Drawing.Point(319, 270);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(63, 23);
            this.TxtDuracion.TabIndex = 41;
            this.TxtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDuracion_KeyPress);
            // 
            // LvlHs
            // 
            this.LvlHs.AutoSize = true;
            this.LvlHs.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlHs.ForeColor = System.Drawing.Color.White;
            this.LvlHs.Location = new System.Drawing.Point(389, 270);
            this.LvlHs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlHs.Name = "LvlHs";
            this.LvlHs.Size = new System.Drawing.Size(50, 25);
            this.LvlHs.TabIndex = 42;
            this.LvlHs.Text = "HS.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DgwMostrarClases
            // 
            this.DgwMostrarClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwMostrarClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwMostrarClases.Location = new System.Drawing.Point(72, 321);
            this.DgwMostrarClases.Name = "DgwMostrarClases";
            this.DgwMostrarClases.RowTemplate.Height = 25;
            this.DgwMostrarClases.Size = new System.Drawing.Size(575, 150);
            this.DgwMostrarClases.TabIndex = 43;
            // 
            // FormAltaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.DgwMostrarClases);
            this.Controls.Add(this.LvlHs);
            this.Controls.Add(this.TxtDuracion);
            this.Controls.Add(this.LvlDuracion);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbxSala);
            this.Controls.Add(this.LvlSala);
            this.Controls.Add(this.CbxProfesor);
            this.Controls.Add(this.LvlProfesor);
            this.Controls.Add(this.LblNombreClase);
            this.Controls.Add(this.CbxClase);
            this.Name = "FormAltaClases";
            this.Text = "FormAltaClases";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwMostrarClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxClase;
        private System.Windows.Forms.Label LblNombreClase;
        private System.Windows.Forms.Label LvlProfesor;
        private System.Windows.Forms.ComboBox CbxProfesor;
        private System.Windows.Forms.Label LvlSala;
        private System.Windows.Forms.ComboBox CbxSala;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LvlDuracion;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.Label LvlHs;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DgwMostrarClases;
    }
}