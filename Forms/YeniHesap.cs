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
            bool result = false;

            vt.Query("INSERT INTO Hesaplar (adi, lokasyon, musteri_id) VALUES ('" + HesapAdiTextBox.Text + "', '" + LokasyonComboBox.Text + "', '" + MusteriId + "')");
            if (result)
                MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}
