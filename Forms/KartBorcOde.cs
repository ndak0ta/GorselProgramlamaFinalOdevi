using GorselProgramlamaFinalOdevi.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi.Forms
{
    public partial class KartBorcOde : Form
    {
        public KartBorcOde(KrediKarti krediKarti)
        {
            InitializeComponent();

            KrediKarti = krediKarti;

            // Kullanıcının borcu ödeyeceğei hesabı seçebilmesi için hesapları ekrana yazdır
            Dictionary<int, string> hesaplar = new Dictionary<int, string>();

            foreach (var item in vt.SelectHesap("SELECT * FROM Hesaplar WHERE musteri_id = " + krediKarti.MusteriId))
                hesaplar.Add(item.hesapId, item.adi);

            comboBox1.DataSource = new BindingSource(hesaplar, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        VeriTabani vt = new VeriTabani();
        KrediKarti KrediKarti { get; set; }

        private void OdeButton_Click(object sender, EventArgs e)
        {
            /* Kullanıcı kart borcunun tamamını mı yoksa bir kısmınımı ödeyeceğeini kontrol et
             * Eğer tamamı ödenecek ise 
             * seçili hesapta borc kadar para olup olmadığını kontrol et
             * eğer varsa borc kadar para miktarını azalt
             * ve işlem geçmişine kaydet
             * 
             * Eğer bir kısmı ödenecek ise hesapta girilen tutar kadar para olup olmadığını kontrol et
             * eğer varsa hesaptan girilen tutar kadar para miktarı azalt
             * işlem geçmişine kaydet
             * 
             * formu kapat
             */
            bool result = false;
            int hesapId = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;

            if (TamaminiOdeCheckBox.Checked)
            {
                if (vt.SelectHesap("SELECT * FROM Hesaplar WHERE hesap_id = " + hesapId)[0].paraMiktari > KrediKarti.Borc)
                    result = vt.Query("UPDATE Kredi_Kartlari SET borc = 0" + " WHERE kredi_kart_id = " + KrediKarti.Id) &&
                        vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + KrediKarti.Borc + " WHERE hesap_id = " + hesapId);
                else
                    MessageBox.Show("Hesabınızda Yeterli Para Yok!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result)
                {
                    vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES ('" + "Kart Borcu Ödemesi" + "', '" + "Kart Borcu Ödemesi" + "', '-" + KrediKarti.Borc + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + hesapId + "', '" + KrediKarti.MusteriId + "')");
                    MessageBox.Show("İşlem Başarıyla Gerçekleştirildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İşleminiz gerçekleştirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vt.SelectHesap("SELECT * FROM Hesaplar WHERE hesap_id = " + hesapId)[0].paraMiktari > Convert.ToInt32(TutarTextBox.Text))
                    result = vt.Query("UPDATE Kredi_Kartlari SET borc = borc - " + TutarTextBox.Text + " WHERE kredi_kart_id = " + KrediKarti.Id) &&
                        vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + TutarTextBox.Text + " WHERE hesap_id = " + hesapId);
                else
                    MessageBox.Show("Hesabınızda Yeterli Para Yok!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result)
                {
                    vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES ('" + "Kart Borcu Ödemesi" + "', '" + "Kart Borcu Ödemesi" + "', '-" + TutarTextBox.Text + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + hesapId + "', '" + KrediKarti.MusteriId + "')");
                    MessageBox.Show("İşlem Başarıyla Gerçekleştirildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İşleminiz gerçekleştirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* Kart borcunun tamamı ödenecek ise eğer
             * sayı girşi bölümünü disable et
             * eğer girilen tutar kadar ödenecek ise 
             * enable et
             */
            if (TamaminiOdeCheckBox.Checked)
            {
                TutarLabel.Enabled = false;
                TutarTextBox.Enabled = false;
            }
            else
            {
                TutarLabel.Enabled = true;
                TutarTextBox.Enabled = true;
            }
        }
    }
}
