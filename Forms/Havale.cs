using System;
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
    public partial class Havale : Form
    {
        public Havale(Hesap hsp)
        {
            InitializeComponent();
            hesap = hsp;
            HesapNumericUpDown.Controls.RemoveAt(0);
            HesapNumericUpDown.Maximum = 999999999;
            ParaNumericUpDown.Maximum = decimal.MaxValue;
        }

        private Hesap hesap { get; set; }
        VeriTabani vt = new VeriTabani();

        private void ParaGonderButton_Click(object sender, EventArgs e)
        {
            bool result1 = false,
                result2 = false;
            decimal cekilecekPara = decimal.Add(ParaNumericUpDown.Value, MasrafHesapla(ParaNumericUpDown.Value));
            DialogResult dialogResult = MessageBox.Show("Göndereciğiniz para:" + ParaNumericUpDown.Value.ToString() + "Masraf: " + MasrafHesapla(ParaNumericUpDown.Value),
                "Para gönderme işlemini onayla",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                result1 = vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + cekilecekPara + " WHERE hesap_id = " + hesap.hesapId.ToString());
                result2 = vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari + " + ParaNumericUpDown.Value.ToString() + " WHERE hesap_id = " + HesapNumericUpDown.Value.ToString());

                if (result1 && result2)
                {
                    vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES " + "('" + "Havale" + "', '" + richTextBox1.Text + "', '" + (-cekilecekPara).ToString() + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + hesap.hesapId.ToString() + "', '" + hesap.musteriId.ToString() + "')");
                    vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES " + "('" + "Havale" + "', '" + richTextBox1.Text + "', '" + cekilecekPara.ToString() + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + HesapNumericUpDown.Value.ToString() + "', '" + vt.SelectHesap("SELECT * FROM Hesaplar WHERE hesap_id = " + HesapNumericUpDown.Value.ToString())[0].musteriId + "')");
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("İşlem iptal edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private decimal MasrafHesapla(decimal gonderilecekPara)
        {
            if (gonderilecekPara > 50000)
                return 19.48m;
            else if (gonderilecekPara > 1000)
                return 1.55m;
            else
                return 0.77m;
        }
    }
}
