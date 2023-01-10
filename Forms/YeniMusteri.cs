using System;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class YeniMusteri : Form
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }

        VeriTabani vt = new VeriTabani();

        private void KaydolButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            result = vt.Query("INSERT INTO Musteriler (tc_no, sifre, ad, soyad) VALUES ('" + TCNoTextBox.Text + "', '" + SifreTextBox.Text + "', '" + AdTextBox.Text + "', '" + SoyadTextBox.Text + "' )");
            if (result)
                MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}
