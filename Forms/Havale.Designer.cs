namespace GorselProgramlamaFinalOdevi
{
    partial class Havale
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
            this.ParaGonderButton = new System.Windows.Forms.Button();
            this.ParaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HesapNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HesapNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ParaGonderButton
            // 
            this.ParaGonderButton.Location = new System.Drawing.Point(250, 550);
            this.ParaGonderButton.Name = "ParaGonderButton";
            this.ParaGonderButton.Size = new System.Drawing.Size(169, 70);
            this.ParaGonderButton.TabIndex = 5;
            this.ParaGonderButton.Text = "Para Gönder";
            this.ParaGonderButton.UseVisualStyleBackColor = true;
            this.ParaGonderButton.Click += new System.EventHandler(this.ParaGonderButton_Click);
            // 
            // ParaNumericUpDown
            // 
            this.ParaNumericUpDown.DecimalPlaces = 2;
            this.ParaNumericUpDown.Location = new System.Drawing.Point(395, 140);
            this.ParaNumericUpDown.Name = "ParaNumericUpDown";
            this.ParaNumericUpDown.Size = new System.Drawing.Size(265, 31);
            this.ParaNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Göndermek istediğiniz para miktarı:";
            // 
            // HesapNumericUpDown
            // 
            this.HesapNumericUpDown.InterceptArrowKeys = false;
            this.HesapNumericUpDown.Location = new System.Drawing.Point(395, 200);
            this.HesapNumericUpDown.Name = "HesapNumericUpDown";
            this.HesapNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HesapNumericUpDown.Size = new System.Drawing.Size(265, 31);
            this.HesapNumericUpDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Göndermek istediğiniz hesap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Açıklama:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(151, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 247);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HesapNumericUpDown);
            this.Controls.Add(this.ParaGonderButton);
            this.Controls.Add(this.ParaNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Havale";
            this.Text = "Havale";
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HesapNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParaGonderButton;
        private System.Windows.Forms.NumericUpDown ParaNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HesapNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}