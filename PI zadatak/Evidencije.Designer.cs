namespace PI_zadatak
{
    partial class frmEvidencije
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
            this.dgvEvidencija = new System.Windows.Forms.DataGridView();
            this.bntKreiranjeEvidencije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvidencija
            // 
            this.dgvEvidencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencija.Location = new System.Drawing.Point(2, 3);
            this.dgvEvidencija.Name = "dgvEvidencija";
            this.dgvEvidencija.Size = new System.Drawing.Size(786, 298);
            this.dgvEvidencija.TabIndex = 0;
            // 
            // bntKreiranjeEvidencije
            // 
            this.bntKreiranjeEvidencije.Location = new System.Drawing.Point(625, 374);
            this.bntKreiranjeEvidencije.Name = "bntKreiranjeEvidencije";
            this.bntKreiranjeEvidencije.Size = new System.Drawing.Size(142, 45);
            this.bntKreiranjeEvidencije.TabIndex = 1;
            this.bntKreiranjeEvidencije.Text = "Kreiraj evidenciju";
            this.bntKreiranjeEvidencije.UseVisualStyleBackColor = true;
            this.bntKreiranjeEvidencije.Click += new System.EventHandler(this.bntKreiranjeEvidencije_Click);
            // 
            // frmEvidencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntKreiranjeEvidencije);
            this.Controls.Add(this.dgvEvidencija);
            this.Name = "frmEvidencije";
            this.Text = "Evidencije";
            this.Load += new System.EventHandler(this.Evidencije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvidencija;
        private System.Windows.Forms.Button bntKreiranjeEvidencije;
    }
}