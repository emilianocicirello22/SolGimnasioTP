
namespace SolGimnasioTP
{
    partial class FormSalaBorrar
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
            this.TxtNombreSala = new System.Windows.Forms.TextBox();
            this.LblNombreSala = new System.Windows.Forms.Label();
            this.DgwSala = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LvlNombreSala = new System.Windows.Forms.Label();
            this.LvlIDSala = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgwSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreSala
            // 
            this.TxtNombreSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreSala.Location = new System.Drawing.Point(264, 51);
            this.TxtNombreSala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreSala.Name = "TxtNombreSala";
            this.TxtNombreSala.Size = new System.Drawing.Size(234, 33);
            this.TxtNombreSala.TabIndex = 1;
            this.TxtNombreSala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreSala_KeyPress_1);
            // 
            // LblNombreSala
            // 
            this.LblNombreSala.AutoSize = true;
            this.LblNombreSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreSala.ForeColor = System.Drawing.Color.White;
            this.LblNombreSala.Location = new System.Drawing.Point(81, 54);
            this.LblNombreSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreSala.Name = "LblNombreSala";
            this.LblNombreSala.Size = new System.Drawing.Size(58, 25);
            this.LblNombreSala.TabIndex = 15;
            this.LblNombreSala.Text = "Sala";
            // 
            // DgwSala
            // 
            this.DgwSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwSala.Location = new System.Drawing.Point(264, 166);
            this.DgwSala.Name = "DgwSala";
            this.DgwSala.RowTemplate.Height = 25;
            this.DgwSala.Size = new System.Drawing.Size(240, 150);
            this.DgwSala.TabIndex = 2;
            this.DgwSala.Visible = false;
            this.DgwSala.SelectionChanged += new System.EventHandler(this.SeleccionarSala);
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
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
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
            this.BtnBorrar.Location = new System.Drawing.Point(319, 369);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(220, 69);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LvlNombreSala
            // 
            this.LvlNombreSala.AutoSize = true;
            this.LvlNombreSala.BackColor = System.Drawing.Color.SteelBlue;
            this.LvlNombreSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlNombreSala.ForeColor = System.Drawing.Color.White;
            this.LvlNombreSala.Location = new System.Drawing.Point(408, 138);
            this.LvlNombreSala.Name = "LvlNombreSala";
            this.LvlNombreSala.Size = new System.Drawing.Size(96, 25);
            this.LvlNombreSala.TabIndex = 23;
            this.LvlNombreSala.Text = "Nombre";
            this.LvlNombreSala.Visible = false;
            // 
            // LvlIDSala
            // 
            this.LvlIDSala.AutoSize = true;
            this.LvlIDSala.BackColor = System.Drawing.Color.SteelBlue;
            this.LvlIDSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvlIDSala.ForeColor = System.Drawing.Color.White;
            this.LvlIDSala.Location = new System.Drawing.Point(296, 138);
            this.LvlIDSala.Name = "LvlIDSala";
            this.LvlIDSala.Size = new System.Drawing.Size(36, 25);
            this.LvlIDSala.TabIndex = 24;
            this.LvlIDSala.Text = "ID";
            this.LvlIDSala.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FormSalaBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvlIDSala);
            this.Controls.Add(this.LvlNombreSala);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.DgwSala);
            this.Controls.Add(this.LblNombreSala);
            this.Controls.Add(this.TxtNombreSala);
            this.Name = "FormSalaBorrar";
            this.Text = "FormSala";
            ((System.ComponentModel.ISupportInitialize)(this.DgwSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreSala;
        private System.Windows.Forms.Label LblNombreSala;
        private System.Windows.Forms.DataGridView DgwSala;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LvlIDSala;
        private System.Windows.Forms.Label LvlNombreSala;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}