
namespace SolGimnasioTP
{
    partial class FormAltaDisciplina
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombreDisciplina = new System.Windows.Forms.TextBox();
            this.LblNombreDisciplina = new System.Windows.Forms.Label();
            this.TxtDescripcionDisciplina = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LvlDescripcionDisciplina = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LvlContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(567, 369);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 4;
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
            this.BtnGuardar.Location = new System.Drawing.Point(319, 369);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(220, 69);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombreDisciplina
            // 
            this.TxtNombreDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreDisciplina.Location = new System.Drawing.Point(305, 41);
            this.TxtNombreDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreDisciplina.Name = "TxtNombreDisciplina";
            this.TxtNombreDisciplina.Size = new System.Drawing.Size(234, 33);
            this.TxtNombreDisciplina.TabIndex = 1;
            // 
            // LblNombreDisciplina
            // 
            this.LblNombreDisciplina.AutoSize = true;
            this.LblNombreDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreDisciplina.ForeColor = System.Drawing.Color.White;
            this.LblNombreDisciplina.Location = new System.Drawing.Point(74, 44);
            this.LblNombreDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreDisciplina.Name = "LblNombreDisciplina";
            this.LblNombreDisciplina.Size = new System.Drawing.Size(113, 25);
            this.LblNombreDisciplina.TabIndex = 5;
            this.LblNombreDisciplina.Text = "Disciplina";
            // 
            // TxtDescripcionDisciplina
            // 
            this.TxtDescripcionDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcionDisciplina.Location = new System.Drawing.Point(261, 138);
            this.TxtDescripcionDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDescripcionDisciplina.MaxLength = 250;
            this.TxtDescripcionDisciplina.Multiline = true;
            this.TxtDescripcionDisciplina.Name = "TxtDescripcionDisciplina";
            this.TxtDescripcionDisciplina.Size = new System.Drawing.Size(328, 179);
            this.TxtDescripcionDisciplina.TabIndex = 2;
            this.TxtDescripcionDisciplina.TextChanged += new System.EventHandler(this.TxtDescripcionDisciplina_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LvlDescripcionDisciplina
            // 
            this.LvlDescripcionDisciplina.AutoSize = true;
            this.LvlDescripcionDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlDescripcionDisciplina.ForeColor = System.Drawing.Color.White;
            this.LvlDescripcionDisciplina.Location = new System.Drawing.Point(74, 138);
            this.LvlDescripcionDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlDescripcionDisciplina.Name = "LvlDescripcionDisciplina";
            this.LvlDescripcionDisciplina.Size = new System.Drawing.Size(134, 25);
            this.LvlDescripcionDisciplina.TabIndex = 6;
            this.LvlDescripcionDisciplina.Text = "Descripción";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // LvlContador
            // 
            this.LvlContador.AutoSize = true;
            this.LvlContador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlContador.ForeColor = System.Drawing.Color.White;
            this.LvlContador.Location = new System.Drawing.Point(552, 320);
            this.LvlContador.Name = "LvlContador";
            this.LvlContador.Size = new System.Drawing.Size(19, 21);
            this.LvlContador.TabIndex = 27;
            this.LvlContador.Text = "0";
            // 
            // FormAltaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvlContador);
            this.Controls.Add(this.LvlDescripcionDisciplina);
            this.Controls.Add(this.TxtDescripcionDisciplina);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtNombreDisciplina);
            this.Controls.Add(this.LblNombreDisciplina);
            this.Name = "FormAltaDisciplina";
            this.Text = "FormAltaDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombreDisciplina;
        private System.Windows.Forms.Label LblNombreDisciplina;
        private System.Windows.Forms.TextBox TxtDescripcionDisciplina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LvlDescripcionDisciplina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LvlContador;
    }
}