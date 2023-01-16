namespace GorselProgramlamaFinalOdevi
{
    partial class HesapBilgiControl
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
            this.HesapAdi = new System.Windows.Forms.Label();
            this.HesapLokasyon = new System.Windows.Forms.Label();
            this.Bakiye = new System.Windows.Forms.Label();
            this.HavaleButton = new System.Windows.Forms.Button();
            this.ParaYatirButton = new System.Windows.Forms.Button();
            this.ParaCekButton = new System.Windows.Forms.Button();
            this.HesapGecmisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HesapAdi
            // 
            this.HesapAdi.AutoSize = true;
            this.HesapAdi.Location = new System.Drawing.Point(10, 10);
            this.HesapAdi.Name = "HesapAdi";
            this.HesapAdi.Size = new System.Drawing.Size(117, 25);
            this.HesapAdi.TabIndex = 0;
            this.HesapAdi.Text = "Hesap Adı:";
            // 
            // HesapLokasyon
            // 
            this.HesapLokasyon.AutoSize = true;
            this.HesapLokasyon.Location = new System.Drawing.Point(10, 90);
            this.HesapLokasyon.Name = "HesapLokasyon";
            this.HesapLokasyon.Size = new System.Drawing.Size(179, 25);
            this.HesapLokasyon.TabIndex = 1;
            this.HesapLokasyon.Text = "Hesap Lokasyon:";
            // 
            // Bakiye
            // 
            this.Bakiye.AutoSize = true;
            this.Bakiye.Location = new System.Drawing.Point(500, 50);
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.Size = new System.Drawing.Size(83, 25);
            this.Bakiye.TabIndex = 2;
            this.Bakiye.Text = "Bakiye:";
            // 
            // HavaleButton
            // 
            this.HavaleButton.Location = new System.Drawing.Point(1411, 15);
            this.HavaleButton.Name = "HavaleButton";
            this.HavaleButton.Size = new System.Drawing.Size(179, 95);
            this.HavaleButton.TabIndex = 7;
            this.HavaleButton.Text = "Havale";
            this.HavaleButton.UseVisualStyleBackColor = true;
            this.HavaleButton.Click += new System.EventHandler(this.HavaleButton_Click);
            // 
            // ParaYatirButton
            // 
            this.ParaYatirButton.Location = new System.Drawing.Point(1226, 15);
            this.ParaYatirButton.Name = "ParaYatirButton";
            this.ParaYatirButton.Size = new System.Drawing.Size(179, 95);
            this.ParaYatirButton.TabIndex = 6;
            this.ParaYatirButton.Text = "Para Yatır";
            this.ParaYatirButton.UseVisualStyleBackColor = true;
            this.ParaYatirButton.Click += new System.EventHandler(this.ParaYatirButton_Click);
            // 
            // ParaCekButton
            // 
            this.ParaCekButton.Location = new System.Drawing.Point(1041, 15);
            this.ParaCekButton.Name = "ParaCekButton";
            this.ParaCekButton.Size = new System.Drawing.Size(179, 95);
            this.ParaCekButton.TabIndex = 5;
            this.ParaCekButton.Text = "Para Çek";
            this.ParaCekButton.UseVisualStyleBackColor = true;
            this.ParaCekButton.Click += new System.EventHandler(this.ParaCekButton_Click);
            // 
            // HesapGecmisButton
            // 
            this.HesapGecmisButton.Location = new System.Drawing.Point(856, 15);
            this.HesapGecmisButton.Name = "HesapGecmisButton";
            this.HesapGecmisButton.Size = new System.Drawing.Size(179, 95);
            this.HesapGecmisButton.TabIndex = 8;
            this.HesapGecmisButton.Text = "Hesap Geçmişi";
            this.HesapGecmisButton.UseVisualStyleBackColor = true;
            this.HesapGecmisButton.Click += new System.EventHandler(this.HesapGecmisButton_Click);
            // 
            // HesapPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HesapGecmisButton);
            this.Controls.Add(this.HavaleButton);
            this.Controls.Add(this.ParaYatirButton);
            this.Controls.Add(this.ParaCekButton);
            this.Controls.Add(this.Bakiye);
            this.Controls.Add(this.HesapLokasyon);
            this.Controls.Add(this.HesapAdi);
            this.Name = "HesapPanel";
            this.Size = new System.Drawing.Size(1600, 130);
            this.Load += new System.EventHandler(this.HesapPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HesapAdi;
        private System.Windows.Forms.Label HesapLokasyon;
        private System.Windows.Forms.Label Bakiye;
        private System.Windows.Forms.Button HavaleButton;
        private System.Windows.Forms.Button ParaYatirButton;
        private System.Windows.Forms.Button ParaCekButton;
        private System.Windows.Forms.Button HesapGecmisButton;
    }
}
