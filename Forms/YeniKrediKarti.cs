using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi.Forms
{
    public partial class YeniKrediKarti : Form
    {
        public YeniKrediKarti(int musteriId)
        {
            InitializeComponent();

            /* Müşterinin sahip olduğu hesapları ComboBox'a ekle
             */

            Dictionary<int, string> hesaplar = new Dictionary<int, string>
            {
                { 0, "İstemiyorum" }
            };

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
            /* Girilen maaş bilgsini 3 ile çarp ve limit olarak ata 
             * (kredi kartı limitleri genelde kişilerin maaşlarının 3 ile 4 katına tekabül ediyor) 
             * Müşterinin daha önce kart sahibi olup olmadığını kontrol et
             * eğer sahip değilse yeni kart anakart olarak tanımlanacak
             * eğer sahipse ek kart olarak tanımlanacak
             * kullanıcının kartını hesabına bağlamak isteyip istemediğin kontrol et
             * eğer istiyorsa veritabanına kart eklenirken hesap bilgisiyle beraber girilecek
             * eğer istemiyorsa hesap bilgisi boş bırakılacak
             */
            bool result = false;
            int limit = Convert.ToInt32(textBox1.Text) * 3;

            if (vt.SelectKrediKarti("SELECT * FROM Kredi_Kartlari WHERE musteri_id = " + MusteriId) != null)
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
            else
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

            if (result)
                MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşlem gerçekleştirilemedi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Close();
        }
    }
}
