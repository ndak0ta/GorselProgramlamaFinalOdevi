using GorselProgramlamaFinalOdevi.Forms;
using GorselProgramlamaFinalOdevi.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class IslemSayfasi : Form
    {
        public IslemSayfasi(int musteriId)
        {
            InitializeComponent();
            MusteriId = musteriId;
        }

        // Giriş yapan müşteriyi tespit edip işlem yapabilmek için giriş formunda musteri_id'yi aldık
        public int MusteriId { get; set; }
        VeriTabani vt = new VeriTabani();

        // Herhangi bir işlem gerçekleştirildiğinde işlem sayfasındaki verileri yenilemek için kullanacağımız fonksiyon
        public void FormYenile()
        {
            Controls.Clear();
            InitializeComponent();
            IslemSayfası_Load();
        }

        private void IslemSayfası_Load(object sender = null, EventArgs e = null)
        {
            #region Hesaplar 

            // Hesap sayfası
            // Panelleri alt alta kaydırabilmek için bir değişken tanımladık
            int panelUzunlugu = 20;

            // İlk panelimiz sabit ve ekleme fonksiyonu olacağı için statik olarak tanımladık
            Panel panel = new Panel();
            Label yeniHesapLabel = new Label();

            HesaplarTabPage.Controls.Add(panel);
            panel.Controls.Add(yeniHesapLabel);
            panel.Size = new Size(800, 65);
            panel.Location = new Point(10, panelUzunlugu);
            panel.Click += new EventHandler(HesapEkleButton_Click);
            panel.BackColor = SystemColors.Control;
            yeniHesapLabel.Location = new Point(250, 25);
            yeniHesapLabel.Text = "Yeni hesap oluşturmak için lütfen buraya basın";
            yeniHesapLabel.TabIndex = 2;
            yeniHesapLabel.AutoSize = false;
            yeniHesapLabel.TextAlign = ContentAlignment.MiddleCenter;
            yeniHesapLabel.Dock = DockStyle.Fill;
            yeniHesapLabel.Click += new EventHandler(HesapEkleButton_Click);

            panel.Visible = true;

            // Hesapları tanımlanan UserControl ile ekrana yazdır
            foreach (var item in vt.SelectHesap("SELECT * FROM Hesaplar WHERE musteri_id = " + MusteriId.ToString()))
            {
                panelUzunlugu += 75; // Control'lerin alt alta gelmesi için her seferinde uzunluk değerini arttır

                HesapBilgiControl hesapBilgiControl = new HesapBilgiControl(item, this);
                HesaplarTabPage.Controls.Add(hesapBilgiControl);
                hesapBilgiControl.Location = new Point(10, panelUzunlugu);
            }
            #endregion

            #region Kredi Kartları

            // Hesaplar ile aynı algoritma kredi kartı için ufak değişiklik yapıldı

            panelUzunlugu = 20;

            panel = new Panel();
            Label yeniKartLabel = new Label();

            KrediKartlarıTabPage.Controls.Add(panel);
            panel.Controls.Add(yeniKartLabel);
            panel.Size = new Size(800, 65);
            panel.Location = new Point(10, panelUzunlugu);
            panel.Click += new EventHandler(KrediKartiOlustur);
            panel.BackColor = SystemColors.Control;
            yeniKartLabel.Location = new Point(250, 25);
            yeniKartLabel.Text = "Yeni kart oluşturmak için lütfen buraya basın";
            yeniKartLabel.TabIndex = 2;
            yeniKartLabel.AutoSize = false;
            yeniKartLabel.TextAlign = ContentAlignment.MiddleCenter;
            yeniKartLabel.Dock = DockStyle.Fill;
            yeniKartLabel.Click += new EventHandler(KrediKartiOlustur);

            foreach (var item in vt.SelectKrediKarti("SELECT * FROM Kredi_Kartlari WHERE musteri_id = " + MusteriId))
            {
                panelUzunlugu += 75;

                KrediKartiBilgiControl krediKartiBilgiControl = new KrediKartiBilgiControl(item, this);
                KrediKartlarıTabPage.Controls.Add(krediKartiBilgiControl);
                krediKartiBilgiControl.Location = new Point(10, panelUzunlugu);
            }

            #endregion
        }

        // Hesap ekle buton kaldırıldı ama fonksiyon faklı yerlerde kullanılıyor
        // Hesap oluşturmak için Yenihesap metodunu çağır
        private void HesapEkleButton_Click(object sender, EventArgs e)
        {
            YeniHesap f = new YeniHesap(MusteriId);
            f.ShowDialog();
            FormYenile();
            tabControl1.SelectedTab = HesaplarTabPage;
        }

        // Kredi kartı oluşturmak için YeniKrediKarti metodunu çağır
        private void KrediKartiOlustur(object sender, EventArgs e)
        {
            YeniKrediKarti f = new YeniKrediKarti(MusteriId);
            f.ShowDialog();
            FormYenile();
            tabControl1.SelectedTab = KrediKartlarıTabPage;
        }

        private void OdemelerButton_Click(object sender, EventArgs e)
        {
            // Ödeme için gerekli alanların dolu olup olmadığını kontrol et
            if (OdemelerComboBox.SelectedIndex > -1 &&
                !string.IsNullOrEmpty(OdemeTextBox.Text) &&
                OdemeSekliComboBox.SelectedIndex > -1 &&
                HesapKrediKartiComboBox.SelectedIndex > -1)
            {
                bool result = false;

                switch (OdemeSekliComboBox.SelectedIndex) // ComboBox'da odeme şekline göre (hesaptan veya keredi kartından) sorguyu gönder
                {
                    case 0:
                        result = vt.Query("INSERT INTO Odemeler (tipi, ucret, musteri_id) VALUES ('" + OdemelerComboBox.Text + "', '" + OdemeTextBox.Text + "', '" + MusteriId + "')") &&
                            vt.Query("UPDATE Kredi_Kartlari SET borc = borc + " + OdemeTextBox.Text + " WHERE kredi_kart_id = " + HesapKrediKartiComboBox.Text);

                        if (result)
                        {
                            vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, musteri_id) VALUES ('" + "Ödeme" + "', '" + OdemelerComboBox.Text + "', '-" + OdemeTextBox.Text + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + MusteriId + "')");
                            MessageBox.Show("İşlem Başarıyla Gerçekleştirildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("İşleminiz gerçekleştirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        if (Convert.ToInt32(OdemeTextBox.Text) < vt.SelectHesap("SELECT * FROM Hesaplar WHERE hesap_id = " + HesapKrediKartiComboBox.Text)[0].paraMiktari)
                        {
                            result = vt.Query("INSERT INTO Odemeler (tipi, ucret, musteri_id) VALUES ('" + OdemelerComboBox.Text + "', '" + OdemeTextBox.Text + "', '" + MusteriId + "')") &&
                                vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari - " + OdemeTextBox.Text + " WHERE hesap_id = " + HesapKrediKartiComboBox.Text);

                            if (result)
                            {
                                vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES ('" + "Ödeme" + "', '" + OdemelerComboBox.Text + "', '-" + OdemeTextBox.Text + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + HesapKrediKartiComboBox.Text + "', '" + MusteriId + "')");
                                MessageBox.Show("İşlem Başarıyla Gerçekleştirildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("İşleminiz gerçekleştirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Hesabınızda Yeterli Para Yok!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
                MessageBox.Show("Lütfen herhangi bir alanı boş bırakmayınız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            FormYenile();
            tabControl1.SelectedTab = OdemelerTabPage;

        }

        // Seçilen ödeme iekline göre HesapKrediKartiComboBox'a gereken verileri ekle
        private void OdemeSekliComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HesapKrediKartiComboBox.Items.Clear();
            HesapKrediKartiComboBox.Text = "";

            switch (OdemeSekliComboBox.SelectedIndex)
            {
                case 0:
                    HesapKrediKartiLabel.Text = "Kredi Kartı: ";
                    foreach (var item in vt.SelectKrediKarti("SELECT * FROM Kredi_Kartlari WHERE musteri_id = " + MusteriId))
                        HesapKrediKartiComboBox.Items.Add(item.Id);
                    HesapKrediKartiLabel.Visible = true;
                    HesapKrediKartiComboBox.Visible = true;
                    break;
                case 1:
                    HesapKrediKartiLabel.Text = "Hesap: ";
                    foreach (var item in vt.SelectHesap("SELECT * FROM Hesaplar WHERE musteri_id = " + MusteriId))
                        HesapKrediKartiComboBox.Items.Add(item.hesapId);
                    HesapKrediKartiLabel.Visible = true;
                    HesapKrediKartiComboBox.Visible = true;
                    break;
            }
        }
    }
}
