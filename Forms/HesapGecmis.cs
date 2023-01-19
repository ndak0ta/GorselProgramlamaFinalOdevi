using GorselProgramlamaFinalOdevi.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    public partial class HesapGecmis : Form
    {
        public HesapGecmis(Hesap hsp)
        {
            InitializeComponent();
            hesap = hsp;
        }

        private Hesap hesap { get; set; }
        VeriTabani vt = new VeriTabani();

        private void HesapGecmis_Load(object sender, EventArgs e)
        {
            int panelUzunlugu = 20;

            foreach (var item in vt.SelectIslemGecmis("SELECT * FROM Islem_Gecmis WHERE hesap_id = " + hesap.hesapId.ToString()))
            {
                /* Hesap aktivitelerini HesapGecmisControl'üne göndererek yazdır
                 */
                HesapGecmisControl hesapGecmisControl = new HesapGecmisControl(item);
                Controls.Add(hesapGecmisControl);
                hesapGecmisControl.Location = new Point(10, panelUzunlugu);
                panelUzunlugu += 25;
            }
        }
    }
}
