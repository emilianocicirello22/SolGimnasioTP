
namespace SolGimnasioTP
{
    partial class FormVerSalas
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
            this.DgwSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwSalas
            // 
            this.DgwSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwSalas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgwSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwSalas.Location = new System.Drawing.Point(285, 144);
            this.DgwSalas.Name = "DgwSalas";
            this.DgwSalas.RowTemplate.Height = 25;
            this.DgwSalas.Size = new System.Drawing.Size(275, 150);
            this.DgwSalas.TabIndex = 0;
            // 
            // FormVerSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgwSalas);
            this.Name = "FormVerSalas";
            this.Text = "FormVerSalas";
            ((System.ComponentModel.ISupportInitialize)(this.DgwSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwSalas;
    }
}