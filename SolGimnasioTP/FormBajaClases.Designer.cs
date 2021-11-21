
namespace SolGimnasioTP
{
    partial class FormBajaClases
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
            this.DgwMostrarClases = new System.Windows.Forms.DataGridView();
            this.LvlDuracion = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LvlSala = new System.Windows.Forms.Label();
            this.LvlProfesor = new System.Windows.Forms.Label();
            this.LblNombreClase = new System.Windows.Forms.Label();
            this.lblDuracionDato = new System.Windows.Forms.Label();
            this.lblSalaDato = new System.Windows.Forms.Label();
            this.lblProfesorDato = new System.Windows.Forms.Label();
            this.lblClaseDato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwMostrarClases)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwMostrarClases
            // 
            this.DgwMostrarClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwMostrarClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwMostrarClases.Location = new System.Drawing.Point(106, 346);
            this.DgwMostrarClases.Name = "DgwMostrarClases";
            this.DgwMostrarClases.RowTemplate.Height = 25;
            this.DgwMostrarClases.Size = new System.Drawing.Size(575, 150);
            this.DgwMostrarClases.TabIndex = 50;
            this.DgwMostrarClases.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgwMostrarClases_RowHeaderMouseClick);
            // 
            // LvlDuracion
            // 
            this.LvlDuracion.AutoSize = true;
            this.LvlDuracion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlDuracion.ForeColor = System.Drawing.Color.White;
            this.LvlDuracion.Location = new System.Drawing.Point(50, 261);
            this.LvlDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlDuracion.Name = "LvlDuracion";
            this.LvlDuracion.Size = new System.Drawing.Size(226, 25);
            this.LvlDuracion.TabIndex = 49;
            this.LvlDuracion.Text = "Duracion de la clase";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(595, 535);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 48;
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
            this.BtnBorrar.Location = new System.Drawing.Point(347, 535);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(220, 69);
            this.BtnBorrar.TabIndex = 47;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // LvlSala
            // 
            this.LvlSala.AutoSize = true;
            this.LvlSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlSala.ForeColor = System.Drawing.Color.White;
            this.LvlSala.Location = new System.Drawing.Point(50, 185);
            this.LvlSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlSala.Name = "LvlSala";
            this.LvlSala.Size = new System.Drawing.Size(58, 25);
            this.LvlSala.TabIndex = 46;
            this.LvlSala.Text = "Sala";
            // 
            // LvlProfesor
            // 
            this.LvlProfesor.AutoSize = true;
            this.LvlProfesor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlProfesor.ForeColor = System.Drawing.Color.White;
            this.LvlProfesor.Location = new System.Drawing.Point(50, 114);
            this.LvlProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlProfesor.Name = "LvlProfesor";
            this.LvlProfesor.Size = new System.Drawing.Size(100, 25);
            this.LvlProfesor.TabIndex = 45;
            this.LvlProfesor.Text = "Profesor";
            // 
            // LblNombreClase
            // 
            this.LblNombreClase.AutoSize = true;
            this.LblNombreClase.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreClase.ForeColor = System.Drawing.Color.White;
            this.LblNombreClase.Location = new System.Drawing.Point(50, 36);
            this.LblNombreClase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreClase.Name = "LblNombreClase";
            this.LblNombreClase.Size = new System.Drawing.Size(70, 25);
            this.LblNombreClase.TabIndex = 44;
            this.LblNombreClase.Text = "Clase";
            // 
            // lblDuracionDato
            // 
            this.lblDuracionDato.AutoSize = true;
            this.lblDuracionDato.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracionDato.ForeColor = System.Drawing.Color.White;
            this.lblDuracionDato.Location = new System.Drawing.Point(347, 261);
            this.lblDuracionDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracionDato.Name = "lblDuracionDato";
            this.lblDuracionDato.Size = new System.Drawing.Size(0, 25);
            this.lblDuracionDato.TabIndex = 54;
            // 
            // lblSalaDato
            // 
            this.lblSalaDato.AutoSize = true;
            this.lblSalaDato.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalaDato.ForeColor = System.Drawing.Color.White;
            this.lblSalaDato.Location = new System.Drawing.Point(347, 185);
            this.lblSalaDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalaDato.Name = "lblSalaDato";
            this.lblSalaDato.Size = new System.Drawing.Size(0, 25);
            this.lblSalaDato.TabIndex = 53;
            // 
            // lblProfesorDato
            // 
            this.lblProfesorDato.AutoSize = true;
            this.lblProfesorDato.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesorDato.ForeColor = System.Drawing.Color.White;
            this.lblProfesorDato.Location = new System.Drawing.Point(347, 114);
            this.lblProfesorDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesorDato.Name = "lblProfesorDato";
            this.lblProfesorDato.Size = new System.Drawing.Size(0, 25);
            this.lblProfesorDato.TabIndex = 52;
            // 
            // lblClaseDato
            // 
            this.lblClaseDato.AutoSize = true;
            this.lblClaseDato.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClaseDato.ForeColor = System.Drawing.Color.White;
            this.lblClaseDato.Location = new System.Drawing.Point(347, 36);
            this.lblClaseDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaseDato.Name = "lblClaseDato";
            this.lblClaseDato.Size = new System.Drawing.Size(0, 25);
            this.lblClaseDato.TabIndex = 51;
            // 
            // FormBajaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.lblDuracionDato);
            this.Controls.Add(this.lblSalaDato);
            this.Controls.Add(this.lblProfesorDato);
            this.Controls.Add(this.lblClaseDato);
            this.Controls.Add(this.DgwMostrarClases);
            this.Controls.Add(this.LvlDuracion);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LvlSala);
            this.Controls.Add(this.LvlProfesor);
            this.Controls.Add(this.LblNombreClase);
            this.Name = "FormBajaClases";
            this.Text = "FormBajaClases";
            ((System.ComponentModel.ISupportInitialize)(this.DgwMostrarClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwMostrarClases;
        private System.Windows.Forms.Label LvlDuracion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label LvlSala;
        private System.Windows.Forms.Label LvlProfesor;
        private System.Windows.Forms.Label LblNombreClase;
        private System.Windows.Forms.Label lblDuracionDato;
        private System.Windows.Forms.Label lblSalaDato;
        private System.Windows.Forms.Label lblProfesorDato;
        private System.Windows.Forms.Label lblClaseDato;
    }
}