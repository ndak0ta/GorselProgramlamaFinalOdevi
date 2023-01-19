using System;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class Havale : Form
    {
        public Havale(Hesap hsp)
        {
            InitializeComponent();
            hesap = hsp;

            /* HesapNumericUpDown'nın oklarını sil ki sadece sayı kabul edebilen bir TextBox gibi olsun
             */
            HesapNumericUpDown.Controls.RemoveAt(0);
            HesapNumericUpDown.Maximum = 999999999;
            ParaNumericUpDown.Maximum = decimal.MaxValue;
        }

        private Hesap hesap { get; set; }
        VeriTabani vt = new VeriTabani();

        private void ParaGonderButton_Click(object sender, EventArgs e)
        {
            /* havale edilecek parayı masrafı ile topla 
             * Havale işleminin yapılmak istenildiğini kullanıcıya dialog ile sor
             * cevaba göre işleme devam et ya da bitir
             * İşleme devam edilecekse şunları yap
             * Paranın çıkış yapacaığı hesaptan parayı eksilt
             * Gideceği hesaptaki para miktarını arttır
             * İşlem geçmişine bir hesaptan eksiltme
             * ötekinden arttırma olarak ekle
             * kullanıcıya işlemin başarılı olup olmadığını bildir
             * formu kapat
             */
            bool result = false;
            decimal cekilecekPara = decimal.Add(ParaNumericUpDown.Value, MasrafHesapla(ParaNumericUpDown.Value));
            DialogResult dialogResult = MessageBox.Show("Göndereciğiniz para:" + ParaNumericUpDown.Value.ToString() + "Masraf: " + MasrafHesapla(ParaNumericUpDown.Value),
                "Para gönderme işlemini onayla",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                result = vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + cekilecekPara + " WHERE hesap_id = " + hesap.hesapId.ToString()); &&
                    vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari + " + ParaNumericUpDown.Value.ToString() + " WHERE hesap_id = " + HesapNumericUpDown.Value.ToString());

                if (result)
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
            /* Havale masrafını havale edilecek miktara göre hesapla ve geri döndür
             */
            if (gonderilecekPara > 50000)
                return 19.48m;
            else if (gonderilecekPara > 1000)
                return 1.55m;
            else
                return 0.77m;
        }
    }
}
