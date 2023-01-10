using GorselProgramlamaFinalOdevi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                HesapGecmisControl hesapGecmisControl = new HesapGecmisControl(item);
                Controls.Add(hesapGecmisControl);
                hesapGecmisControl.Location = new Point(10, panelUzunlugu);
                panelUzunlugu += 25;
            }
        }
    }
}
