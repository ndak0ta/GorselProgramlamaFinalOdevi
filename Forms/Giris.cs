using System;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        // Veritabanı işlemlerimizi yürütebilmek için veritabanı nesnesini tanımla
        VeriTabani vt = new VeriTabani();

        private void GirisButton_Click(object sender, EventArgs e)
        {
            // Giriş için girilen verileri veritabanında ara
            foreach (var item in vt.SelectMusteri("SELECT * FROM Musteriler"))
            {
                if (item.tc_no.ToString() == TcNo_TextBox.Text)
                {
                    if (item.sifre == Sifre_TextBox.Text)
                    {
                        // Tc No ve şifre uyuştuğunda kullanıcıyı işlem sayfasına yönlendir
                        IslemSayfasi f = new IslemSayfasi(item.musteriId);
                        Hide();
                        f.ShowDialog();
                        Show();
                        return;
                    }

                    // Tc no bulunup şifre hatalı olduğunda hata ver
                    MessageBox.Show("Lütfen şifrenizi doğru girdiğinizden emin olur", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Tc no bulunamadığında hata ver
            MessageBox.Show("Böyle bir müşteri bulunamadı", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void YeniMusteriButton_Click(object sender, EventArgs e)
        {
            // Yeni müşteri eklemek için yeni müşteri formuna yönlendir
            YeniMusteri f = new YeniMusteri();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
