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
    public partial class ParaYatir : Form
    {
        public ParaYatir(Hesap hsp)
        {
            InitializeComponent();
            hesap = hsp;
        }

        private Hesap hesap { get; set; }
        VeriTabani vt = new VeriTabani();

        private void ParaYatirButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            decimal yatırılacakPara = ParaNumericUpDown.Value;

            result = vt.Query("UPDATE Hesaplar SET para_miktari = para_miktari + " + yatırılacakPara + " WHERE hesap_id = " + hesap.hesapId.ToString());
            if (result)
            {
                vt.Query("INSERT INTO Islem_Gecmis (tipi, aciklama, para_miktari, tarih_saat, hesap_id, musteri_id) VALUES ('" + "Para yatırma" + "', '" + "Para yatırma" + "', '" + yatırılacakPara.ToString() + "', '" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + "', '" + hesap.hesapId.ToString() + "', '" + hesap.musteriId.ToString() + "')");
                MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void ParaYatir_Load(object sender, EventArgs e)
        {
            ParaNumericUpDown.Maximum = decimal.MaxValue;
        }
    }
}
