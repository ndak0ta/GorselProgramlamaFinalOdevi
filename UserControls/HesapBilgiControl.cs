using System;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class HesapBilgiControl : UserControl
    {
        public HesapBilgiControl(Hesap hsp, IslemSayfasi iS)
        {
            InitializeComponent();
            hesap = hsp;
            islemSayfasi = iS;
        }

        private Hesap hesap { get; set; }
        private IslemSayfasi islemSayfasi { get; set; }

        private void HesapPanel_Load(object sender = null, EventArgs e = null)
        {
            /* Bilgileri Control'de gerekli yerlere yazdır
             */
            HesapAdi.Text = "Hesap Adı: " + hesap.adi;
            HesapLokasyon.Text = "Hesap Lokasyon: " + hesap.lokasyon;
            Bakiye.Text = "Bakiye: " + hesap.paraMiktari.ToString() + "₺";
            BackColor = SystemColors.Control;
        }

        private void ParaCekButton_Click(object sender, EventArgs e)
        {
            ParaCek paraCek = new ParaCek(hesap);
            paraCek.ShowDialog();
            islemSayfasi.FormYenile();
            islemSayfasi.tabControl1.SelectedTab = islemSayfasi.HesaplarTabPage;
        }

        private void ParaYatirButton_Click(object sender, EventArgs e)
        {
            ParaYatir paraYatir = new ParaYatir(hesap);
            paraYatir.ShowDialog();
            islemSayfasi.FormYenile();
            islemSayfasi.tabControl1.SelectedTab = islemSayfasi.HesaplarTabPage;
        }

        private void HavaleButton_Click(object sender, EventArgs e)
        {
            Havale havale = new Havale(hesap);
            havale.ShowDialog();
            islemSayfasi.FormYenile();
            islemSayfasi.tabControl1.SelectedTab = islemSayfasi.HesaplarTabPage;
        }

        private void HesapGecmisButton_Click(object sender, EventArgs e)
        {
            HesapGecmis hesapGecmis = new HesapGecmis(hesap);
            hesapGecmis.ShowDialog();
        }
    }
}
