﻿namespace GorselProgramlamaFinalOdevi
{
    partial class IslemSayfasi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anasayfa = new System.Windows.Forms.TabPage();
            this.HesaplarTabPage = new System.Windows.Forms.TabPage();
            this.KrediKartlarıTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.anasayfa);
            this.tabControl1.Controls.Add(this.HesaplarTabPage);
            this.tabControl1.Controls.Add(this.KrediKartlarıTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1674, 829);
            this.tabControl1.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.Location = new System.Drawing.Point(8, 39);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.anasayfa.Size = new System.Drawing.Size(1658, 782);
            this.anasayfa.TabIndex = 0;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            // 
            // HesaplarTabPage
            // 
            this.HesaplarTabPage.AutoScroll = true;
            this.HesaplarTabPage.BackColor = System.Drawing.Color.White;
            this.HesaplarTabPage.Location = new System.Drawing.Point(8, 39);
            this.HesaplarTabPage.Name = "HesaplarTabPage";
            this.HesaplarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HesaplarTabPage.Size = new System.Drawing.Size(1658, 782);
            this.HesaplarTabPage.TabIndex = 1;
            this.HesaplarTabPage.Text = "Hesaplar";
            // 
            // KrediKartlarıTabPage
            // 
            this.KrediKartlarıTabPage.BackColor = System.Drawing.Color.White;
            this.KrediKartlarıTabPage.Location = new System.Drawing.Point(8, 39);
            this.KrediKartlarıTabPage.Name = "KrediKartlarıTabPage";
            this.KrediKartlarıTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.KrediKartlarıTabPage.Size = new System.Drawing.Size(1658, 782);
            this.KrediKartlarıTabPage.TabIndex = 2;
            this.KrediKartlarıTabPage.Text = "Kredi Kartları";
            // 
            // IslemSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 829);
            this.Controls.Add(this.tabControl1);
            this.Name = "IslemSayfası";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IslemSayfası_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage anasayfa;
        public System.Windows.Forms.TabPage HesaplarTabPage;
        public System.Windows.Forms.TabPage KrediKartlarıTabPage;
    }
}
