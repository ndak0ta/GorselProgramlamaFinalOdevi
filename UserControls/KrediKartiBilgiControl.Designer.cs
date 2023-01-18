namespace GorselProgramlamaFinalOdevi.UserControls
{
    partial class KrediKartiBilgiControl
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
            this.KartNoLabel = new System.Windows.Forms.Label();
            this.KartLimitLabel = new System.Windows.Forms.Label();
            this.KullanilabilirLimitLabel = new System.Windows.Forms.Label();
            this.BorcLabel = new System.Windows.Forms.Label();
            this.HesapKesimLabel = new System.Windows.Forms.Label();
            this.OnlineAlısverisAcKapaButton = new System.Windows.Forms.Button();
            this.OnlineAlisverisLabel = new System.Windows.Forms.Label();
            this.BorcOdemeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KartNoLabel
            // 
            this.KartNoLabel.AutoSize = true;
            this.KartNoLabel.Location = new System.Drawing.Point(36, 19);
            this.KartNoLabel.Name = "KartNoLabel";
            this.KartNoLabel.Size = new System.Drawing.Size(96, 25);
            this.KartNoLabel.TabIndex = 0;
            this.KartNoLabel.Text = "Kart No: ";
            // 
            // KartLimitLabel
            // 
            this.KartLimitLabel.AutoSize = true;
            this.KartLimitLabel.Location = new System.Drawing.Point(18, 71);
            this.KartLimitLabel.Name = "KartLimitLabel";
            this.KartLimitLabel.Size = new System.Drawing.Size(114, 25);
            this.KartLimitLabel.TabIndex = 2;
            this.KartLimitLabel.Text = "Kart Limit: ";
            // 
            // KullanilabilirLimitLabel
            // 
            this.KullanilabilirLimitLabel.AutoSize = true;
            this.KullanilabilirLimitLabel.Location = new System.Drawing.Point(327, 19);
            this.KullanilabilirLimitLabel.Name = "KullanilabilirLimitLabel";
            this.KullanilabilirLimitLabel.Size = new System.Drawing.Size(191, 25);
            this.KullanilabilirLimitLabel.TabIndex = 3;
            this.KullanilabilirLimitLabel.Text = "Kullanılabilir Limit: ";
            // 
            // BorcLabel
            // 
            this.BorcLabel.AutoSize = true;
            this.BorcLabel.Location = new System.Drawing.Point(450, 71);
            this.BorcLabel.Name = "BorcLabel";
            this.BorcLabel.Size = new System.Drawing.Size(68, 25);
            this.BorcLabel.TabIndex = 4;
            this.BorcLabel.Text = "Borç: ";
            // 
            // HesapKesimLabel
            // 
            this.HesapKesimLabel.AutoSize = true;
            this.HesapKesimLabel.Location = new System.Drawing.Point(750, 19);
            this.HesapKesimLabel.Name = "HesapKesimLabel";
            this.HesapKesimLabel.Size = new System.Drawing.Size(209, 25);
            this.HesapKesimLabel.TabIndex = 5;
            this.HesapKesimLabel.Text = "Hesap Kesim Günü: ";
            // 
            // OnlineAlısverisAcKapaButton
            // 
            this.OnlineAlısverisAcKapaButton.Location = new System.Drawing.Point(1399, 19);
            this.OnlineAlısverisAcKapaButton.Name = "OnlineAlısverisAcKapaButton";
            this.OnlineAlısverisAcKapaButton.Size = new System.Drawing.Size(150, 77);
            this.OnlineAlısverisAcKapaButton.TabIndex = 6;
            this.OnlineAlısverisAcKapaButton.Text = "Online Alışveriş Aç/Kapa";
            this.OnlineAlısverisAcKapaButton.UseVisualStyleBackColor = true;
            this.OnlineAlısverisAcKapaButton.Click += new System.EventHandler(this.OnlineAlısverisAcKapaButton_Click);
            // 
            // OnlineAlisverisLabel
            // 
            this.OnlineAlisverisLabel.AutoSize = true;
            this.OnlineAlisverisLabel.Location = new System.Drawing.Point(786, 71);
            this.OnlineAlisverisLabel.Name = "OnlineAlisverisLabel";
            this.OnlineAlisverisLabel.Size = new System.Drawing.Size(173, 25);
            this.OnlineAlisverisLabel.TabIndex = 7;
            this.OnlineAlisverisLabel.Text = "Online Alışveriş: ";
            // 
            // BorcOdemeButton
            // 
            this.BorcOdemeButton.Location = new System.Drawing.Point(1243, 19);
            this.BorcOdemeButton.Name = "BorcOdemeButton";
            this.BorcOdemeButton.Size = new System.Drawing.Size(150, 77);
            this.BorcOdemeButton.TabIndex = 8;
            this.BorcOdemeButton.Text = "Borç Ödeme";
            this.BorcOdemeButton.UseVisualStyleBackColor = true;
            this.BorcOdemeButton.Click += new System.EventHandler(this.BorcOdemeButton_Click);
            // 
            // KrediKartiBilgiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BorcOdemeButton);
            this.Controls.Add(this.OnlineAlisverisLabel);
            this.Controls.Add(this.OnlineAlısverisAcKapaButton);
            this.Controls.Add(this.HesapKesimLabel);
            this.Controls.Add(this.BorcLabel);
            this.Controls.Add(this.KullanilabilirLimitLabel);
            this.Controls.Add(this.KartLimitLabel);
            this.Controls.Add(this.KartNoLabel);
            this.Name = "KrediKartiBilgiControl";
            this.Size = new System.Drawing.Size(1600, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KartNoLabel;
        private System.Windows.Forms.Label KartLimitLabel;
        private System.Windows.Forms.Label KullanilabilirLimitLabel;
        private System.Windows.Forms.Label BorcLabel;
        private System.Windows.Forms.Label HesapKesimLabel;
        private System.Windows.Forms.Button OnlineAlısverisAcKapaButton;
        private System.Windows.Forms.Label OnlineAlisverisLabel;
        private System.Windows.Forms.Button BorcOdemeButton;
    }
}
