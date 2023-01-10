namespace GorselProgramlamaFinalOdevi
{
    partial class Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.TcNo_TextBox = new System.Windows.Forms.TextBox();
            this.Sifre_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.YeniMusteriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // TcNo_TextBox
            // 
            this.TcNo_TextBox.Location = new System.Drawing.Point(292, 155);
            this.TcNo_TextBox.MaxLength = 11;
            this.TcNo_TextBox.Name = "TcNo_TextBox";
            this.TcNo_TextBox.Size = new System.Drawing.Size(333, 31);
            this.TcNo_TextBox.TabIndex = 1;
            this.TcNo_TextBox.Text = "12345678912";
            // 
            // Sifre_TextBox
            // 
            this.Sifre_TextBox.Location = new System.Drawing.Point(292, 216);
            this.Sifre_TextBox.MaxLength = 1000;
            this.Sifre_TextBox.Name = "Sifre_TextBox";
            this.Sifre_TextBox.PasswordChar = '*';
            this.Sifre_TextBox.Size = new System.Drawing.Size(333, 31);
            this.Sifre_TextBox.TabIndex = 3;
            this.Sifre_TextBox.Text = "123456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // GirisButton
            // 
            this.GirisButton.Location = new System.Drawing.Point(292, 357);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(333, 73);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "Giriş Yap";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // YeniMusteriButton
            // 
            this.YeniMusteriButton.Location = new System.Drawing.Point(680, 558);
            this.YeniMusteriButton.Name = "YeniMusteriButton";
            this.YeniMusteriButton.Size = new System.Drawing.Size(183, 72);
            this.YeniMusteriButton.TabIndex = 5;
            this.YeniMusteriButton.Text = "Yeni Müşteri";
            this.YeniMusteriButton.UseVisualStyleBackColor = true;
            this.YeniMusteriButton.Click += new System.EventHandler(this.YeniMusteriButton_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 642);
            this.Controls.Add(this.YeniMusteriButton);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.Sifre_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TcNo_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TcNo_TextBox;
        private System.Windows.Forms.TextBox Sifre_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button YeniMusteriButton;
    }
}