namespace GorselProgramlamaFinalOdevi
{
    partial class ParaCek
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
            this.ParaLabel = new System.Windows.Forms.Label();
            this.ParaCekButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ParaLabel
            // 
            this.ParaLabel.AutoSize = true;
            this.ParaLabel.Location = new System.Drawing.Point(34, 55);
            this.ParaLabel.Name = "ParaLabel";
            this.ParaLabel.Size = new System.Drawing.Size(279, 25);
            this.ParaLabel.TabIndex = 0;
            this.ParaLabel.Text = "Para Çekebiliceğiniz Miktar:";
            // 
            // ParaCekButton
            // 
            this.ParaCekButton.Location = new System.Drawing.Point(218, 296);
            this.ParaCekButton.Name = "ParaCekButton";
            this.ParaCekButton.Size = new System.Drawing.Size(294, 80);
            this.ParaCekButton.TabIndex = 1;
            this.ParaCekButton.Text = "Para Çek";
            this.ParaCekButton.UseVisualStyleBackColor = true;
            this.ParaCekButton.Click += new System.EventHandler(this.ParaCekButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çekmek istediğiniz miktar:";
            // 
            // ParaNumericUpDown
            // 
            this.ParaNumericUpDown.DecimalPlaces = 2;
            this.ParaNumericUpDown.Location = new System.Drawing.Point(319, 159);
            this.ParaNumericUpDown.Name = "ParaNumericUpDown";
            this.ParaNumericUpDown.Size = new System.Drawing.Size(236, 31);
            this.ParaNumericUpDown.TabIndex = 4;
            // 
            // ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.ParaNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParaCekButton);
            this.Controls.Add(this.ParaLabel);
            this.MaximumSize = new System.Drawing.Size(830, 520);
            this.MinimumSize = new System.Drawing.Size(830, 520);
            this.Name = "ParaCek";
            this.Text = "ParaCek";
            this.Load += new System.EventHandler(this.ParaCek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParaLabel;
        private System.Windows.Forms.Button ParaCekButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ParaNumericUpDown;
    }
}