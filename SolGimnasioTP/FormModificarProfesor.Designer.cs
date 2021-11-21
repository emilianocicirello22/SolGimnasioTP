
namespace SolGimnasioTP
{
    partial class FormModificarProfesor
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
            this.TxtNombreFamiliarProfesor = new System.Windows.Forms.TextBox();
            this.TxtTelFamiliarProfesor = new System.Windows.Forms.TextBox();
            this.TxtTelProfesor = new System.Windows.Forms.TextBox();
            this.TxtCelProfesor = new System.Windows.Forms.TextBox();
            this.TxtApellidoProfesor = new System.Windows.Forms.TextBox();
            this.TxtNombreProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTelFamiliarProfesor = new System.Windows.Forms.Label();
            this.LblTelefonoProfesor = new System.Windows.Forms.Label();
            this.LblCelProfesor = new System.Windows.Forms.Label();
            this.GrBSexo = new System.Windows.Forms.GroupBox();
            this.RbtnOtro = new System.Windows.Forms.RadioButton();
            this.RbtnFemenino = new System.Windows.Forms.RadioButton();
            this.RbtnMasculino = new System.Windows.Forms.RadioButton();
            this.LblApellidoProfesor = new System.Windows.Forms.Label();
            this.LblNombreProfesor = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.DgwProfesor = new System.Windows.Forms.DataGridView();
            this.TxtBusquedaProfesor = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GrBSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreFamiliarProfesor
            // 
            this.TxtNombreFamiliarProfesor.Enabled = false;
            this.TxtNombreFamiliarProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreFamiliarProfesor.Location = new System.Drawing.Point(319, 474);
            this.TxtNombreFamiliarProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreFamiliarProfesor.Multiline = true;
            this.TxtNombreFamiliarProfesor.Name = "TxtNombreFamiliarProfesor";
            this.TxtNombreFamiliarProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtNombreFamiliarProfesor.TabIndex = 10;
            // 
            // TxtTelFamiliarProfesor
            // 
            this.TxtTelFamiliarProfesor.Enabled = false;
            this.TxtTelFamiliarProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelFamiliarProfesor.Location = new System.Drawing.Point(319, 425);
            this.TxtTelFamiliarProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTelFamiliarProfesor.Multiline = true;
            this.TxtTelFamiliarProfesor.Name = "TxtTelFamiliarProfesor";
            this.TxtTelFamiliarProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtTelFamiliarProfesor.TabIndex = 9;
            this.TxtTelFamiliarProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelProfesor_KeyPress);
            // 
            // TxtTelProfesor
            // 
            this.TxtTelProfesor.Enabled = false;
            this.TxtTelProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelProfesor.Location = new System.Drawing.Point(319, 374);
            this.TxtTelProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTelProfesor.Multiline = true;
            this.TxtTelProfesor.Name = "TxtTelProfesor";
            this.TxtTelProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtTelProfesor.TabIndex = 8;
            this.TxtTelProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelProfesor_KeyPress);
            // 
            // TxtCelProfesor
            // 
            this.TxtCelProfesor.Enabled = false;
            this.TxtCelProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCelProfesor.Location = new System.Drawing.Point(319, 326);
            this.TxtCelProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCelProfesor.Multiline = true;
            this.TxtCelProfesor.Name = "TxtCelProfesor";
            this.TxtCelProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtCelProfesor.TabIndex = 7;
            this.TxtCelProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelProfesor_KeyPress);
            // 
            // TxtApellidoProfesor
            // 
            this.TxtApellidoProfesor.Enabled = false;
            this.TxtApellidoProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellidoProfesor.Location = new System.Drawing.Point(319, 107);
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
            this.TxtNombreProfesor.Location = new System.Drawing.Point(319, 56);
            this.TxtNombreProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreProfesor.Multiline = true;
            this.TxtNombreProfesor.Name = "TxtNombreProfesor";
            this.TxtNombreProfesor.Size = new System.Drawing.Size(234, 42);
            this.TxtNombreProfesor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre del Familiar";
            // 
            // LblTelFamiliarProfesor
            // 
            this.LblTelFamiliarProfesor.AutoSize = true;
            this.LblTelFamiliarProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelFamiliarProfesor.ForeColor = System.Drawing.Color.White;
            this.LblTelFamiliarProfesor.Location = new System.Drawing.Point(30, 438);
            this.LblTelFamiliarProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelFamiliarProfesor.Name = "LblTelFamiliarProfesor";
            this.LblTelFamiliarProfesor.Size = new System.Drawing.Size(192, 25);
            this.LblTelFamiliarProfesor.TabIndex = 30;
            this.LblTelFamiliarProfesor.Text = "Telefono Familiar";
            // 
            // LblTelefonoProfesor
            // 
            this.LblTelefonoProfesor.AutoSize = true;
            this.LblTelefonoProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelefonoProfesor.ForeColor = System.Drawing.Color.White;
            this.LblTelefonoProfesor.Location = new System.Drawing.Point(30, 391);
            this.LblTelefonoProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefonoProfesor.Name = "LblTelefonoProfesor";
            this.LblTelefonoProfesor.Size = new System.Drawing.Size(108, 25);
            this.LblTelefonoProfesor.TabIndex = 29;
            this.LblTelefonoProfesor.Text = "Telefono ";
            // 
            // LblCelProfesor
            // 
            this.LblCelProfesor.AutoSize = true;
            this.LblCelProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCelProfesor.ForeColor = System.Drawing.Color.White;
            this.LblCelProfesor.Location = new System.Drawing.Point(30, 343);
            this.LblCelProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCelProfesor.Name = "LblCelProfesor";
            this.LblCelProfesor.Size = new System.Drawing.Size(87, 25);
            this.LblCelProfesor.TabIndex = 28;
            this.LblCelProfesor.Text = "Celular";
            // 
            // GrBSexo
            // 
            this.GrBSexo.Controls.Add(this.RbtnOtro);
            this.GrBSexo.Controls.Add(this.RbtnFemenino);
            this.GrBSexo.Controls.Add(this.RbtnMasculino);
            this.GrBSexo.Enabled = false;
            this.GrBSexo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrBSexo.ForeColor = System.Drawing.Color.White;
            this.GrBSexo.Location = new System.Drawing.Point(36, 182);
            this.GrBSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrBSexo.Name = "GrBSexo";
            this.GrBSexo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrBSexo.Size = new System.Drawing.Size(424, 122);
            this.GrBSexo.TabIndex = 21;
            this.GrBSexo.TabStop = false;
            this.GrBSexo.Text = "Sexo";
            // 
            // RbtnOtro
            // 
            this.RbtnOtro.AutoSize = true;
            this.RbtnOtro.Enabled = false;
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
            this.RbtnFemenino.Enabled = false;
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
            this.RbtnMasculino.Enabled = false;
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
            this.LblApellidoProfesor.Location = new System.Drawing.Point(30, 122);
            this.LblApellidoProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellidoProfesor.Name = "LblApellidoProfesor";
            this.LblApellidoProfesor.Size = new System.Drawing.Size(96, 25);
            this.LblApellidoProfesor.TabIndex = 27;
            this.LblApellidoProfesor.Text = "Apellido";
            // 
            // LblNombreProfesor
            // 
            this.LblNombreProfesor.AutoSize = true;
            this.LblNombreProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.LblNombreProfesor.Location = new System.Drawing.Point(30, 73);
            this.LblNombreProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreProfesor.Name = "LblNombreProfesor";
            this.LblNombreProfesor.Size = new System.Drawing.Size(96, 25);
            this.LblNombreProfesor.TabIndex = 26;
            this.LblNombreProfesor.Text = "Nombre";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(567, 719);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(319, 719);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(220, 69);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // DgwProfesor
            // 
            this.DgwProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProfesor.Location = new System.Drawing.Point(57, 546);
            this.DgwProfesor.Name = "DgwProfesor";
            this.DgwProfesor.RowTemplate.Height = 25;
            this.DgwProfesor.Size = new System.Drawing.Size(691, 150);
            this.DgwProfesor.TabIndex = 11;
            this.DgwProfesor.Visible = false;
            this.DgwProfesor.SelectionChanged += new System.EventHandler(this.SeleccionarProfesor);
            // 
            // TxtBusquedaProfesor
            // 
            this.TxtBusquedaProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBusquedaProfesor.Location = new System.Drawing.Point(30, 12);
            this.TxtBusquedaProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBusquedaProfesor.Name = "TxtBusquedaProfesor";
            this.TxtBusquedaProfesor.PlaceholderText = "Buscar";
            this.TxtBusquedaProfesor.Size = new System.Drawing.Size(234, 33);
            this.TxtBusquedaProfesor.TabIndex = 1;
            this.TxtBusquedaProfesor.Tag = "";
            this.TxtBusquedaProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusquedaProfesor_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FormModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 798);
            this.Controls.Add(this.TxtBusquedaProfesor);
            this.Controls.Add(this.DgwProfesor);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtNombreFamiliarProfesor);
            this.Controls.Add(this.TxtTelFamiliarProfesor);
            this.Controls.Add(this.TxtTelProfesor);
            this.Controls.Add(this.TxtCelProfesor);
            this.Controls.Add(this.TxtApellidoProfesor);
            this.Controls.Add(this.TxtNombreProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTelFamiliarProfesor);
            this.Controls.Add(this.LblTelefonoProfesor);
            this.Controls.Add(this.LblCelProfesor);
            this.Controls.Add(this.GrBSexo);
            this.Controls.Add(this.LblApellidoProfesor);
            this.Controls.Add(this.LblNombreProfesor);
            this.Name = "FormModificarProfesor";
            this.Text = "FormModificarProfesor";
            this.GrBSexo.ResumeLayout(false);
            this.GrBSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreFamiliarProfesor;
        private System.Windows.Forms.TextBox TxtTelFamiliarProfesor;
        private System.Windows.Forms.TextBox TxtTelProfesor;
        private System.Windows.Forms.TextBox TxtCelProfesor;
        private System.Windows.Forms.TextBox TxtApellidoProfesor;
        private System.Windows.Forms.TextBox TxtNombreProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTelFamiliarProfesor;
        private System.Windows.Forms.Label LblTelefonoProfesor;
        private System.Windows.Forms.Label LblCelProfesor;
        private System.Windows.Forms.GroupBox GrBSexo;
        private System.Windows.Forms.RadioButton RbtnOtro;
        private System.Windows.Forms.RadioButton RbtnFemenino;
        private System.Windows.Forms.RadioButton RbtnMasculino;
        private System.Windows.Forms.Label LblApellidoProfesor;
        private System.Windows.Forms.Label LblNombreProfesor;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView DgwProfesor;
        private System.Windows.Forms.TextBox TxtBusquedaProfesor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}