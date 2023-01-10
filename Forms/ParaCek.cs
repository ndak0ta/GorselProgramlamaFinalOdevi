﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class ParaCek : Form
    {
        public ParaCek(Hesap hsp)
        {
            InitializeComponent();
            hesap = hsp;
        }

        private Hesap hesap { get; set; }
        VeriTabani vt = new VeriTabani();

        private void ParaCek_Load(object sender, EventArgs e)
        {
            ParaLabel.Text = "Para Çekebiliceğiniz Miktar: " + hesap.paraMiktari + "₺";
            ParaNumericUpDown.Maximum = decimal.MaxValue;
        }

        private void ParaCekButton_Click(object sender, EventArgs e)
        {
            decimal cekilecekPara = ParaNumericUpDown.Value;

            if (cekilecekPara < 0)
            {
                MessageBox.Show("Lütfen 0 ve üstünde bir değer girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cekilecekPara > hesap.paraMiktari)
            {
                MessageBox.Show("Malasef hesabınızda bu kadar para yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool result = false;

                result = vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + cekilecekPara + " WHERE hesap_id = " + hesap.hesapId.ToString());

                if (result)
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}