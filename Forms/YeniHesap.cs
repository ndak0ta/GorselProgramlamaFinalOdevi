using System;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class YeniHesap : Form
    {
        public YeniHesap(int musteriId)
        {
            InitializeComponent();
            MusteriId = musteriId;
        }

        private int MusteriId { get; set; }
        VeriTabani vt = new VeriTabani();

        private void button1_Click(object sender, EventArgs e)
        {
            /* Formdaki veri giriş yerlerinin doldurulduğunu kontrol et
             * Gelen müşteri id'sine ve formdan girilen verilere göre
             * sorgu tanımla ve çalıştır
             * Query metodunun geri döndürdüğü değere göre başarı veya hata mesajını ver
             * ve formu kapat
             */

            if (!string.IsNullOrEmpty(HesapAdiTextBox.Text) && LokasyonComboBox.SelectedIndex > -1)
            {
                bool result = false;

                result = vt.Query("INSERT INTO Hesaplar (adi, lokasyon, musteri_id) VALUES ('" + HesapAdiTextBox.Text + "', '" + LokasyonComboBox.Text + "', '" + MusteriId + "')");
                if (result)
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }

        }
    }
}
