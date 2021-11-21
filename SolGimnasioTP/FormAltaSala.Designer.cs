
namespace SolGimnasioTP
{
    partial class FormAltaSala
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreSala
            // 
            this.TxtNombreSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreSala.Location = new System.Drawing.Point(366, 41);
            this.TxtNombreSala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombreSala.Name = "TxtNombreSala";
            this.TxtNombreSala.Size = new System.Drawing.Size(234, 33);
            this.TxtNombreSala.TabIndex = 1;
            // 
            // LblNombreSala
            // 
            this.LblNombreSala.AutoSize = true;
            this.LblNombreSala.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreSala.ForeColor = System.Drawing.Color.White;
            this.LblNombreSala.Location = new System.Drawing.Point(167, 49);
            this.LblNombreSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreSala.Name = "LblNombreSala";
            this.LblNombreSala.Size = new System.Drawing.Size(58, 25);
            this.LblNombreSala.TabIndex = 4;
            this.LblNombreSala.Text = "Sala";
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
            this.BtnCerrar.TabIndex = 3;
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
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAltaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtNombreSala);
            this.Controls.Add(this.LblNombreSala);
            this.Name = "FormAltaSala";
            this.Text = "FormAltaSala";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreSala;
        private System.Windows.Forms.Label LblNombreSala;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}