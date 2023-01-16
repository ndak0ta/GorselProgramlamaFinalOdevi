using GorselProgramlamaFinalOdevi.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class IslemSayfası : Form
    {
        public IslemSayfası(int musteriId)
        {
            InitializeComponent();
            MusteriId = musteriId;
        }

        private int MusteriId { get; set; }
        VeriTabani vt = new VeriTabani();

        public void FormYenile()
        {
            Controls.Clear();
            InitializeComponent();
            IslemSayfası_Load();
        }

        private void IslemSayfası_Load(object sender = null, EventArgs e = null)
        {
            #region Hesaplar 
            int panelUzunlugu = 20;

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

            foreach (var item in vt.SelectHesap("SELECT * FROM Hesaplar WHERE musteri_id = " + MusteriId.ToString()))
            {
                panelUzunlugu += 75;

                HesapBilgiControl hp = new HesapBilgiControl(item, this);
                HesaplarTabPage.Controls.Add(hp);
                hp.Location = new Point(10, panelUzunlugu);
            }
            #endregion

            #region Kredi Kartları

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

            #endregion
        }

        private void HesapEkleButton_Click(object sender, EventArgs e)
        {
            YeniHesap f = new YeniHesap(MusteriId);
            f.ShowDialog();
            FormYenile();
            tabControl1.SelectedTab = HesaplarTabPage;
        }

        private void KrediKartiOlustur(object sender, EventArgs e)
        {
            YeniKrediKarti f = new YeniKrediKarti(MusteriId);
            f.ShowDialog();
            FormYenile();
            tabControl1.SelectedTab = KrediKartlarıTabPage;
        }
    }
}
