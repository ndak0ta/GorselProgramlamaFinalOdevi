namespace GorselProgramlamaFinalOdevi.UserControls
{
    partial class HesapGecmisControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TarihSaatLabel = new System.Windows.Forms.Label();
            this.ParaDegisimiLabel = new System.Windows.Forms.Label();
            this.AciklamaLabel = new System.Windows.Forms.Label();
            this.IslemTipiLabel = new System.Windows.Forms.Label();
            this.IslemNumarasıLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TarihSaatLabel
            // 
            this.TarihSaatLabel.AutoSize = true;
            this.TarihSaatLabel.Location = new System.Drawing.Point(602, 12);
            this.TarihSaatLabel.Name = "TarihSaatLabel";
            this.TarihSaatLabel.Size = new System.Drawing.Size(111, 25);
            this.TarihSaatLabel.TabIndex = 10;
            this.TarihSaatLabel.Text = "Tarih/Saat";
            // 
            // ParaDegisimiLabel
            // 
            this.ParaDegisimiLabel.AutoSize = true;
            this.ParaDegisimiLabel.Location = new System.Drawing.Point(393, 12);
            this.ParaDegisimiLabel.Name = "ParaDegisimiLabel";
            this.ParaDegisimiLabel.Size = new System.Drawing.Size(145, 25);
            this.ParaDegisimiLabel.TabIndex = 9;
            this.ParaDegisimiLabel.Text = "Para Değişimi";
            // 
            // AciklamaLabel
            // 
            this.AciklamaLabel.AutoSize = true;
            this.AciklamaLabel.Location = new System.Drawing.Point(887, 12);
            this.AciklamaLabel.Name = "AciklamaLabel";
            this.AciklamaLabel.Size = new System.Drawing.Size(99, 25);
            this.AciklamaLabel.TabIndex = 8;
            this.AciklamaLabel.Text = "Açıklama";
            // 
            // IslemTipiLabel
            // 
            this.IslemTipiLabel.AutoSize = true;
            this.IslemTipiLabel.Location = new System.Drawing.Point(203, 12);
            this.IslemTipiLabel.Name = "IslemTipiLabel";
            this.IslemTipiLabel.Size = new System.Drawing.Size(103, 25);
            this.IslemTipiLabel.TabIndex = 7;
            this.IslemTipiLabel.Text = "İşlem Tipi";
            // 
            // IslemNumarasıLabel
            // 
            this.IslemNumarasıLabel.AutoSize = true;
            this.IslemNumarasıLabel.Location = new System.Drawing.Point(3, 12);
            this.IslemNumarasıLabel.Name = "IslemNumarasıLabel";
            this.IslemNumarasıLabel.Size = new System.Drawing.Size(156, 25);
            this.IslemNumarasıLabel.TabIndex = 6;
            this.IslemNumarasıLabel.Text = "İşlem numarası";
            // 
            // HesapGecmisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TarihSaatLabel);
            this.Controls.Add(this.ParaDegisimiLabel);
            this.Controls.Add(this.AciklamaLabel);
            this.Controls.Add(this.IslemTipiLabel);
            this.Controls.Add(this.IslemNumarasıLabel);
            this.Name = "HesapGecmisControl";
            this.Size = new System.Drawing.Size(1200, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TarihSaatLabel;
        private System.Windows.Forms.Label ParaDegisimiLabel;
        private System.Windows.Forms.Label AciklamaLabel;
        private System.Windows.Forms.Label IslemTipiLabel;
        private System.Windows.Forms.Label IslemNumarasıLabel;
    }
}
