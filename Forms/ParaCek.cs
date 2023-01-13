using System;
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
                {
                    vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES ('" + "Para çekme" + "', '" + "Para çekme" + "', '" + (-cekilecekPara).ToString() + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + hesap.hesapId.ToString() + "', '" + hesap.musteriId.ToString() + "')");
                    MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
