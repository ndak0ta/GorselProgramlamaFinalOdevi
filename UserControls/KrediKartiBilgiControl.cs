using GorselProgramlamaFinalOdevi.Classes;
using GorselProgramlamaFinalOdevi.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi.UserControls
{
    public partial class KrediKartiBilgiControl : UserControl
    {
        public KrediKartiBilgiControl(KrediKarti krediKarti, IslemSayfasi islemSayfası)
        {
            InitializeComponent();

            // Gelen Kredi kartı bilgilerini label'lara yazıdr
            KartNoLabel.Text = "Kart No:" + krediKarti.Id.ToString();
            KartLimitLabel.Text = "Kart Limit:" + krediKarti.Limit.ToString();
            KullanilabilirLimitLabel.Text = "Kullanılabilir Limit:" + (krediKarti.Limit - krediKarti.Borc).ToString("G29");
            BorcLabel.Text = "Borç:" + krediKarti.Borc.ToString("G29");
            HesapKesimLabel.Text = "Hesap Kesim Günü:" + krediKarti.HesapKesim.ToString();
            OnlineAlisverisLabel.Text = "Online Alışveriş: " + (krediKarti.OnlineAlisveris ? "Açık" : "Kapalı");

            BackColor = SystemColors.Control;
            KrediKarti = krediKarti;
            IslemSayfasi = islemSayfası;
        }

        KrediKarti KrediKarti { get; set; }
        IslemSayfasi IslemSayfasi { get; set; }
        VeriTabani vt = new VeriTabani();

        private void OnlineAlısverisAcKapaButton_Click(object sender, System.EventArgs e)
        {
            // Online alışveriş özelliğini aç/kapa
            vt.Query("UPDATE Kredi_Kartlari SET online_alisveris = " + !KrediKarti.OnlineAlisveris + " WHERE kredi_kart_id = " + KrediKarti.Id);
            IslemSayfasi.FormYenile();
            IslemSayfasi.tabControl1.SelectedTab = IslemSayfasi.KrediKartlarıTabPage;
        }

        private void BorcOdemeButton_Click(object sender, System.EventArgs e)
        {
            // Borç ödemek için KartBorcOde formuna yönlendir
            KartBorcOde f = new KartBorcOde(KrediKarti);
            f.ShowDialog();
            IslemSayfasi.FormYenile();
            IslemSayfasi.tabControl1.SelectedTab = IslemSayfasi.KrediKartlarıTabPage;
        }
    }
}
