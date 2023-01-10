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

        VeriTabani vt = new VeriTabani();

        private void GirisButton_Click(object sender, EventArgs e)
        {
            foreach (var item in vt.SelectMusteri("SELECT * FROM Musteriler"))
            {
                if (item.tc_no.ToString() == TcNo_TextBox.Text)
                {
                    if (item.sifre == Sifre_TextBox.Text)
                    {
                        IslemSayfası f = new IslemSayfası(item.musteriId);
                        Hide();
                        f.ShowDialog();
                        Show();
                        return;
                    }

                    MessageBox.Show("Lütfen şifrenizi doğru girdiğinizden emin olur", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Böyle bir müşteri bulunamadı", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void YeniMusteriButton_Click(object sender, EventArgs e)
        {
            YeniMusteri f = new YeniMusteri();
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
