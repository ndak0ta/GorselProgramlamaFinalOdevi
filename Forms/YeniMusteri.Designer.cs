namespace GorselProgramlamaFinalOdevi
{
    partial class YeniMusteri
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
            this.TCNoTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KaydolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // TCNoTextBox
            // 
            this.TCNoTextBox.Location = new System.Drawing.Point(229, 96);
            this.TCNoTextBox.Name = "TCNoTextBox";
            this.TCNoTextBox.Size = new System.Drawing.Size(260, 31);
            this.TCNoTextBox.TabIndex = 1;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(229, 146);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.PasswordChar = '*';
            this.SifreTextBox.Size = new System.Drawing.Size(260, 31);
            this.SifreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(229, 198);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(260, 31);
            this.AdTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad:";
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(229, 256);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(260, 31);
            this.SoyadTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad";
            // 
            // KaydolButton
            // 
            this.KaydolButton.Location = new System.Drawing.Point(229, 342);
            this.KaydolButton.Name = "KaydolButton";
            this.KaydolButton.Size = new System.Drawing.Size(260, 79);
            this.KaydolButton.TabIndex = 8;
            this.KaydolButton.Text = "Kaydol";
            this.KaydolButton.UseVisualStyleBackColor = true;
            this.KaydolButton.Click += new System.EventHandler(this.KaydolButton_Click);
            // 
            // YeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.KaydolButton);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCNoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "YeniMusteri";
            this.Text = "YeniMusteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCNoTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KaydolButton;
    }
}