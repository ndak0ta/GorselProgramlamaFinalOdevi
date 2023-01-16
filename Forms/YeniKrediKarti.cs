using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GorselProgramlamaFinalOdevi.Forms
{
    public partial class YeniKrediKarti : Form
    {
        public YeniKrediKarti(int musteriId)
        {
            InitializeComponent();

            Dictionary<int, string> hesaplar = new Dictionary<int, string>();
            hesaplar.Add(0, "İstemiyorum");

            foreach (var item in vt.SelectHesap("SELECT * FROM Hesaplar WHERE musteri_id = " + musteriId.ToString()))
                hesaplar.Add(item.hesapId, item.adi);

            comboBox1.DataSource = new BindingSource(hesaplar, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            MusteriId = musteriId;
        }

        int MusteriId { get; set; }
        VeriTabani vt = new VeriTabani();

        private void KartOlusturButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            int limit = Convert.ToInt32(textBox1.Text) * 3;

            if (vt.SelectKrediKarti("SELECT * FROM Kredi_Kartlari WHERE musteri_id = " + MusteriId) != null)
            {
                if (((KeyValuePair<int, string>)comboBox1.SelectedItem).Key != 0)
                    result = vt.Query("INSERT INTO Kredi_Kartlari (limit, anakart, online_alisveris, hesap_kesim, musteri_id, hesap_id) VALUES ('" +
                        limit + "', " +
                        true + ", " +
                        checkBox1.Checked + ", '" +
                        DateTime.Now.ToString("dd") + "', '" +
                        MusteriId + "', '" +
                        ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key + "')");
                else
                    result = vt.Query("INSERT INTO Kredi_Kartlari (limit, anakart, online_alisveris, hesap_kesim, musteri_id) VALUES ('" +
                        limit + "', " +
                        true + ", " +
                        checkBox1.Checked + ", '" +
                        DateTime.Now.ToString("dd") + "', '" +
                        MusteriId + "')");
            }
            else
            {
                if (((KeyValuePair<int, string>)comboBox1.SelectedItem).Key != 0)
                    result = vt.Query("INSERT INTO Kredi_Kartlari (limit, anakart, online_alisveris, hesap_kesim, musteri_id, hesap_id) VALUES ('" +
                        limit + "', " +
                        false + ", " +
                        checkBox1.Checked + ", '" +
                        DateTime.Now.ToString("dd") + "', '" +
                        MusteriId + "', '" +
                        ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key + "')");
                else
                    result = vt.Query("INSERT INTO Kredi_Kartlari (limit, anakart, online_alisveris, hesap_kesim, musteri_id) VALUES ('" +
                        limit + "', " +
                        false + ", " +
                        checkBox1.Checked + ", '" +
                        DateTime.Now.ToString("dd") + "', '" +
                        MusteriId + "')");
            }

            if (result)
                MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Close();
        }
    }
}
