namespace GorselProgramlamaFinalOdevi.Forms
{
    partial class KartBorcOde
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OdeButton = new System.Windows.Forms.Button();
            this.TamaminiOdeCheckBox = new System.Windows.Forms.CheckBox();
            this.TutarTextBox = new System.Windows.Forms.TextBox();
            this.TutarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenecek Hesap:";
            // 
            // OdeButton
            // 
            this.OdeButton.Location = new System.Drawing.Point(274, 295);
            this.OdeButton.Name = "OdeButton";
            this.OdeButton.Size = new System.Drawing.Size(308, 61);
            this.OdeButton.TabIndex = 2;
            this.OdeButton.Text = "Öde";
            this.OdeButton.UseVisualStyleBackColor = true;
            this.OdeButton.Click += new System.EventHandler(this.OdeButton_Click);
            // 
            // TamaminiOdeCheckBox
            // 
            this.TamaminiOdeCheckBox.AutoSize = true;
            this.TamaminiOdeCheckBox.Location = new System.Drawing.Point(274, 174);
            this.TamaminiOdeCheckBox.Name = "TamaminiOdeCheckBox";
            this.TamaminiOdeCheckBox.Size = new System.Drawing.Size(183, 29);
            this.TamaminiOdeCheckBox.TabIndex = 3;
            this.TamaminiOdeCheckBox.Text = "Tamamını Öde";
            this.TamaminiOdeCheckBox.UseVisualStyleBackColor = true;
            this.TamaminiOdeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TutarTextBox
            // 
            this.TutarTextBox.Location = new System.Drawing.Point(274, 226);
            this.TutarTextBox.Name = "TutarTextBox";
            this.TutarTextBox.Size = new System.Drawing.Size(308, 31);
            this.TutarTextBox.TabIndex = 4;
            // 
            // TutarLabel
            // 
            this.TutarLabel.AutoSize = true;
            this.TutarLabel.Location = new System.Drawing.Point(12, 229);
            this.TutarLabel.Name = "TutarLabel";
            this.TutarLabel.Size = new System.Drawing.Size(256, 25);
            this.TutarLabel.TabIndex = 5;
            this.TutarLabel.Text = "Ödemek İstediğiniz Tutar:";
            // 
            // KartBorcOde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.TutarLabel);
            this.Controls.Add(this.TutarTextBox);
            this.Controls.Add(this.TamaminiOdeCheckBox);
            this.Controls.Add(this.OdeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "KartBorcOde";
            this.Text = "KartBorcOde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OdeButton;
        private System.Windows.Forms.CheckBox TamaminiOdeCheckBox;
        private System.Windows.Forms.TextBox TutarTextBox;
        private System.Windows.Forms.Label TutarLabel;
    }
}