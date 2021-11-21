
namespace SolGimnasioTP
{
    partial class FormBajaDisciplina
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
            this.CbxDisciplina = new System.Windows.Forms.ComboBox();
            this.LvlContador = new System.Windows.Forms.Label();
            this.LvlDescripcionDisciplina = new System.Windows.Forms.Label();
            this.TxtDescripcionDisciplina = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TxtNombreDisciplina = new System.Windows.Forms.TextBox();
            this.LblNombreDisciplina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxDisciplina
            // 
            this.CbxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDisciplina.FormattingEnabled = true;
            this.CbxDisciplina.Location = new System.Drawing.Point(204, 24);
            this.CbxDisciplina.Name = "CbxDisciplina";
            this.CbxDisciplina.Size = new System.Drawing.Size(328, 23);
            this.CbxDisciplina.TabIndex = 1;
            this.CbxDisciplina.DropDown += new System.EventHandler(this.CbxDisciplina_DropDown);
            this.CbxDisciplina.SelectedIndexChanged += new System.EventHandler(this.CbxDisciplina_SelectedIndexChanged);
            // 
            // LvlContador
            // 
            this.LvlContador.AutoSize = true;
            this.LvlContador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlContador.ForeColor = System.Drawing.Color.White;
            this.LvlContador.Location = new System.Drawing.Point(495, 403);
            this.LvlContador.Name = "LvlContador";
            this.LvlContador.Size = new System.Drawing.Size(19, 21);
            this.LvlContador.TabIndex = 42;
            this.LvlContador.Text = "0";
            // 
            // LvlDescripcionDisciplina
            // 
            this.LvlDescripcionDisciplina.AutoSize = true;
            this.LvlDescripcionDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlDescripcionDisciplina.ForeColor = System.Drawing.Color.White;
            this.LvlDescripcionDisciplina.Location = new System.Drawing.Point(17, 221);
            this.LvlDescripcionDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LvlDescripcionDisciplina.Name = "LvlDescripcionDisciplina";
            this.LvlDescripcionDisciplina.Size = new System.Drawing.Size(134, 25);
            this.LvlDescripcionDisciplina.TabIndex = 41;
            this.LvlDescripcionDisciplina.Text = "Descripción";
            // 
            // TxtDescripcionDisciplina
            // 
            this.TxtDescripcionDisciplina.Enabled = false;
            this.TxtDescripcionDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcionDisciplina.Location = new System.Drawing.Point(204, 221);
            this.TxtDescripcionDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDescripcionDisciplina.MaxLength = 250;
            this.TxtDescripcionDisciplina.Multiline = true;
            this.TxtDescripcionDisciplina.Name = "TxtDescripcionDisciplina";
            this.TxtDescripcionDisciplina.Size = new System.Drawing.Size(328, 179);
            this.TxtDescripcionDisciplina.TabIndex = 3;
            this.TxtDescripcionDisciplina.TextChanged += new System.EventHandler(this.TxtDescripcionDisciplina_TextChanged);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(648, 452);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 69);
            this.BtnCerrar.TabIndex = 5;
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
            this.BtnBorrar.Location = new System.Drawing.Point(400, 452);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(220, 69);
            this.BtnBorrar.TabIndex = 4;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TxtNombreDisciplina
            // 
            this.TxtNombreDisciplina.Enabled = false;
            this.TxtNombreDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreDisciplina.Location = new System.Drawing.Point(204, 119);
            this.TxtNombreDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreDisciplina.Name = "TxtNombreDisciplina";
            this.TxtNombreDisciplina.Size = new System.Drawing.Size(328, 33);
            this.TxtNombreDisciplina.TabIndex = 2;
            // 
            // LblNombreDisciplina
            // 
            this.LblNombreDisciplina.AutoSize = true;
            this.LblNombreDisciplina.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreDisciplina.ForeColor = System.Drawing.Color.White;
            this.LblNombreDisciplina.Location = new System.Drawing.Point(17, 127);
            this.LblNombreDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreDisciplina.Name = "LblNombreDisciplina";
            this.LblNombreDisciplina.Size = new System.Drawing.Size(113, 25);
            this.LblNombreDisciplina.TabIndex = 40;
            this.LblNombreDisciplina.Text = "Disciplina";
            // 
            // FormBajaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(881, 533);
            this.Controls.Add(this.CbxDisciplina);
            this.Controls.Add(this.LvlContador);
            this.Controls.Add(this.LvlDescripcionDisciplina);
            this.Controls.Add(this.TxtDescripcionDisciplina);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.TxtNombreDisciplina);
            this.Controls.Add(this.LblNombreDisciplina);
            this.Name = "FormBajaDisciplina";
            this.Text = "FormBajaDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxDisciplina;
        private System.Windows.Forms.Label LvlContador;
        private System.Windows.Forms.Label LvlDescripcionDisciplina;
        private System.Windows.Forms.TextBox TxtDescripcionDisciplina;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TxtNombreDisciplina;
        private System.Windows.Forms.Label LblNombreDisciplina;
    }
}