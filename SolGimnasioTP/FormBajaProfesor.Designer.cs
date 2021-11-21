
namespace SolGimnasioTP
{
    partial class FormBajaProfesor
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
            this.TxtApellidoProfesor = new System.Windows.Forms.TextBox();
            this.TxtNombreProfesor = new System.Windows.Forms.TextBox();
            this.GrBSexo = new System.Windows.Forms.GroupBox();
            this.RbtnOtro = new System.Windows.Forms.RadioButton();
            this.RbtnFemenino = new System.Windows.Forms.RadioButton();
            this.RbtnMasculino = new System.Windows.Forms.RadioButton();
            this.LblApellidoProfesor = new System.Windows.Forms.Label();
            this.LblNombreProfesor = new System.Windows.Forms.Label();
            this.TxtBusquedaProfesor = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.DgwProfesor = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrBSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellidoProfesor
            // 
            this.TxtApellidoProfesor.Enabled = false;
            this.TxtApellidoProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidoProfesor.Location = new System.Drawing.Point(321, 143);
            this.TxtApellidoProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtApellidoProfesor.Multiline = true;
            this.TxtApellidoProfesor.Name = "TxtApellidoProfesor";
            this.TxtApellidoProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtApellidoProfesor.TabIndex = 3;
            // 
            // TxtNombreProfesor
            // 
            this.TxtNombreProfesor.Enabled = false;
            this.TxtNombreProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreProfesor.Location = new System.Drawing.Point(321, 92);
            this.TxtNombreProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreProfesor.Multiline = true;
            this.TxtNombreProfesor.Name = "TxtNombreProfesor";
            this.TxtNombreProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtNombreProfesor.TabIndex = 2;
            // 
            // GrBSexo
            // 
            this.GrBSexo.Controls.Add(this.RbtnOtro);
            this.GrBSexo.Controls.Add(this.RbtnFemenino);
            this.GrBSexo.Controls.Add(this.RbtnMasculino);
            this.GrBSexo.Enabled = false;
            this.GrBSexo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrBSexo.ForeColor = System.Drawing.Color.White;
            this.GrBSexo.Location = new System.Drawing.Point(38, 218);
            this.GrBSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrBSexo.Name = "GrBSexo";
            this.GrBSexo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrBSexo.Size = new System.Drawing.Size(424, 122);
            this.GrBSexo.TabIndex = 16;
            this.GrBSexo.TabStop = false;
            this.GrBSexo.Text = "Sexo";
            // 
            // RbtnOtro
            // 
            this.RbtnOtro.AutoSize = true;
            this.RbtnOtro.Location = new System.Drawing.Point(332, 51);
            this.RbtnOtro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbtnOtro.Name = "RbtnOtro";
            this.RbtnOtro.Size = new System.Drawing.Size(77, 29);
            this.RbtnOtro.TabIndex = 6;
            this.RbtnOtro.Text = "Otro";
            this.RbtnOtro.UseVisualStyleBackColor = true;
            // 
            // RbtnFemenino
            // 
            this.RbtnFemenino.AutoSize = true;
            this.RbtnFemenino.Checked = true;
            this.RbtnFemenino.Location = new System.Drawing.Point(8, 51);
            this.RbtnFemenino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbtnFemenino.Name = "RbtnFemenino";
            this.RbtnFemenino.Size = new System.Drawing.Size(132, 29);
            this.RbtnFemenino.TabIndex = 4;
            this.RbtnFemenino.TabStop = true;
            this.RbtnFemenino.Text = "Femenino";
            this.RbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // RbtnMasculino
            // 
            this.RbtnMasculino.AutoSize = true;
            this.RbtnMasculino.Location = new System.Drawing.Point(169, 51);
            this.RbtnMasculino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbtnMasculino.Name = "RbtnMasculino";
            this.RbtnMasculino.Size = new System.Drawing.Size(134, 29);
            this.RbtnMasculino.TabIndex = 5;
            this.RbtnMasculino.Text = "Masculino";
            this.RbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // LblApellidoProfesor
            // 
            this.LblApellidoProfesor.AutoSize = true;
            this.LblApellidoProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellidoProfesor.ForeColor = System.Drawing.Color.White;
            this.LblApellidoProfesor.Location = new System.Drawing.Point(32, 158);
            this.LblApellidoProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellidoProfesor.Name = "LblApellidoProfesor";
            this.LblApellidoProfesor.Size = new System.Drawing.Size(96, 25);
            this.LblApellidoProfesor.TabIndex = 18;
            this.LblApellidoProfesor.Text = "Apellido";
            // 
            // LblNombreProfesor
            // 
            this.LblNombreProfesor.AutoSize = true;
            this.LblNombreProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.LblNombreProfesor.Location = new System.Drawing.Point(32, 109);
            this.LblNombreProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreProfesor.Name = "LblNombreProfesor";
            this.LblNombreProfesor.Size = new System.Drawing.Size(96, 25);
            this.LblNombreProfesor.TabIndex = 17;
            this.LblNombreProfesor.Text = "Nombre";
            // 
            // TxtBusquedaProfesor
            // 
            this.TxtBusquedaProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBusquedaProfesor.Location = new System.Drawing.Point(321, 22);
            this.TxtBusquedaProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBusquedaProfesor.Name = "TxtBusquedaProfesor";
            this.TxtBusquedaProfesor.PlaceholderText = "Buscar";
            this.TxtBusquedaProfesor.Size = new System.Drawing.Size(234, 33);
            this.TxtBusquedaProfesor.TabIndex = 1;
            this.TxtBusquedaProfesor.Tag = "";
            this.TxtBusquedaProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(567, 550);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBorrar.Enabled = false;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBorrar.ForeColor = System.Drawing.Color.White;
            this.BtnBorrar.Location = new System.Drawing.Point(319, 550);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(220, 69);
            this.BtnBorrar.TabIndex = 8;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // DgwProfesor
            // 
            this.DgwProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProfesor.Location = new System.Drawing.Point(148, 372);
            this.DgwProfesor.Name = "DgwProfesor";
            this.DgwProfesor.RowTemplate.Height = 25;
            this.DgwProfesor.Size = new System.Drawing.Size(496, 150);
            this.DgwProfesor.TabIndex = 7;
            this.DgwProfesor.Visible = false;
            this.DgwProfesor.SelectionChanged += new System.EventHandler(this.SeleccionarProfesor);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormBajaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.DgwProfesor);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TxtBusquedaProfesor);
            this.Controls.Add(this.TxtApellidoProfesor);
            this.Controls.Add(this.TxtNombreProfesor);
            this.Controls.Add(this.GrBSexo);
            this.Controls.Add(this.LblApellidoProfesor);
            this.Controls.Add(this.LblNombreProfesor);
            this.Name = "FormBajaProfesor";
            this.Text = "FormBajaProfesor";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.GrBSexo.ResumeLayout(false);
            this.GrBSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellidoProfesor;
        private System.Windows.Forms.TextBox TxtNombreProfesor;
        private System.Windows.Forms.GroupBox GrBSexo;
        private System.Windows.Forms.RadioButton RbtnOtro;
        private System.Windows.Forms.RadioButton RbtnFemenino;
        private System.Windows.Forms.RadioButton RbtnMasculino;
        private System.Windows.Forms.Label LblApellidoProfesor;
        private System.Windows.Forms.Label LblNombreProfesor;
        private System.Windows.Forms.TextBox TxtBusquedaProfesor;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.DataGridView DgwProfesor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}