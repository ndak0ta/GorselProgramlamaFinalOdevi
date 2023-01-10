namespace GorselProgramlamaFinalOdevi
{
    partial class YeniHesap
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
            this.HesapAdiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LokasyonComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Adı:";
            // 
            // HesapAdiTextBox
            // 
            this.HesapAdiTextBox.Location = new System.Drawing.Point(247, 69);
            this.HesapAdiTextBox.Name = "HesapAdiTextBox";
            this.HesapAdiTextBox.Size = new System.Drawing.Size(261, 31);
            this.HesapAdiTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap Şube:";
            // 
            // LokasyonComboBox
            // 
            this.LokasyonComboBox.FormattingEnabled = true;
            this.LokasyonComboBox.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Kocaeli",
            "İstanbul",
            "İzmir",
            "Yalova"});
            this.LokasyonComboBox.Location = new System.Drawing.Point(247, 127);
            this.LokasyonComboBox.Name = "LokasyonComboBox";
            this.LokasyonComboBox.Size = new System.Drawing.Size(261, 33);
            this.LokasyonComboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesabı Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YeniHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LokasyonComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HesapAdiTextBox);
            this.Controls.Add(this.label1);
            this.Name = "YeniHesap";
            this.Text = "YeniHesap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HesapAdiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LokasyonComboBox;
        private System.Windows.Forms.Button button1;
    }
}