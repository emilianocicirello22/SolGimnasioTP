
namespace SolGimnasioTP
{
    partial class FormVerProfesores
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
            this.DgwProfesor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwProfesor
            // 
            this.DgwProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProfesor.Location = new System.Drawing.Point(12, 71);
            this.DgwProfesor.Name = "DgwProfesor";
            this.DgwProfesor.RowTemplate.Height = 25;
            this.DgwProfesor.Size = new System.Drawing.Size(756, 229);
            this.DgwProfesor.TabIndex = 1;
            // 
            // FormVerProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgwProfesor);
            this.Name = "FormVerProfesores";
            this.Text = "FormVerProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.DgwProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwProfesor;
    }
}