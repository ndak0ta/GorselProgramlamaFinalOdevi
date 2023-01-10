namespace GorselProgramlamaFinalOdevi
{
    partial class ParaYatir
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
            this.ParaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ParaYatirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yatırmak istediğiniz para miktarı:";
            // 
            // ParaNumericUpDown
            // 
            this.ParaNumericUpDown.DecimalPlaces = 2;
            this.ParaNumericUpDown.Location = new System.Drawing.Point(384, 172);
            this.ParaNumericUpDown.Name = "ParaNumericUpDown";
            this.ParaNumericUpDown.Size = new System.Drawing.Size(265, 31);
            this.ParaNumericUpDown.TabIndex = 1;
            // 
            // ParaYatirButton
            // 
            this.ParaYatirButton.Location = new System.Drawing.Point(256, 269);
            this.ParaYatirButton.Name = "ParaYatirButton";
            this.ParaYatirButton.Size = new System.Drawing.Size(169, 70);
            this.ParaYatirButton.TabIndex = 2;
            this.ParaYatirButton.Text = "Para Yatır";
            this.ParaYatirButton.UseVisualStyleBackColor = true;
            this.ParaYatirButton.Click += new System.EventHandler(this.ParaYatirButton_Click);
            // 
            // ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.ParaYatirButton);
            this.Controls.Add(this.ParaNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ParaYatir";
            this.Text = "ParaYatir";
            this.Load += new System.EventHandler(this.ParaYatir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ParaNumericUpDown;
        private System.Windows.Forms.Button ParaYatirButton;
    }
}