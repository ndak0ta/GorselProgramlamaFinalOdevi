using GorselProgramlamaFinalOdevi.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    internal class VeriTabani
    {
        // Veritabanı bağlantısı için bağlantı kodları
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ndak0ta\\source\\repos\\GorselProgramlamaFinalOdevi\\bin\\Debug\\VakıfbankDB.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dataReader;

        /* Sql SELECT komutu için her veri tipi için tek tek özel metod tanımlandı sebebi ise
         * SELECT komutunun geriye değer döndürmesidir öteki komutlarda böyle bir şey yok
         * o yüzden öteki komutları tek bir metodla hallederken SELECT komutunda ayrı ayrı metod tanımlamamaız gerekiyor
         * 
         * Select metodlarının çalışma adımları:
         * Select Metodu ile çekilecek veriye göre liste tanımla 
         * bağlantıyı aç
         * query'i komuta ata
         * bağlantıyı komuta ata 
         * komutu çalışıtır dataReader'a ata
         * dataReader'daki verilerin hepsini veriye uygun nesneye koyarak listeye ata
         * bağlantıyı kapat 
         * listeyi geri döndür
         */
        public List<Musteri> SelectMusteri(string query)
        {
            try
            {
                List<Musteri> list = new List<Musteri>();
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new Musteri()
                    {
                        musteriId = (int)dataReader["musteri_id"],
                        tc_no = (long)dataReader["tc_no"],
                        sifre = (string)dataReader["sifre"],
                        ad = (string)dataReader["ad"],
                        soyad = (string)dataReader["soyad"]
                    });
                }
                con.Close();

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<Hesap> SelectHesap(string query)
        {
            try
            {
                List<Hesap> list = new List<Hesap>();
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new Hesap()
                    {
                        hesapId = (int)dataReader["hesap_id"],
                        adi = (string)dataReader["adi"],
                        lokasyon = (string)dataReader["lokasyon"],
                        paraMiktari = (decimal)dataReader["para_miktari"],
                        musteriId = (int)dataReader["musteri_id"],
                    });
                }

                con.Close();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<IslemGecmisi> SelectIslemGecmis(string query)
        {
            try
            {
                List<IslemGecmisi> list = new List<IslemGecmisi>();
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new IslemGecmisi()
                    {
                        Id = (int)dataReader["islem_id"],
                        Tipi = (string)dataReader["tipi"],
                        Aciklama = (string)dataReader["aciklama"],
                        ParaMiktari = (decimal)dataReader["para_miktari"],
                        TarihSaat = (DateTime)dataReader["tarih_saat"],
                        HesapId = (int)dataReader["hesap_id"],
                        MusteriId = (int)dataReader["musteri_id"],
                    });
                }

                con.Close();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<KrediKarti> SelectKrediKarti(string query)
        {
            try
            {
                List<KrediKarti> list = new List<KrediKarti>();
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new KrediKarti()
                    {
                        Id = (int)dataReader["kredi_kart_id"],
                        Limit = (int)dataReader["limit"],
                        Anakart = (bool)dataReader["anakart"],
                        Borc = (decimal)dataReader["borc"],
                        OnlineAlisveris = (bool)dataReader["online_alisveris"],
                        HesapKesim = (int)dataReader["hesap_kesim"],
                        MusteriId = (int)dataReader["musteri_id"],
                        HesapId = (int)dataReader["hesap_id"]
                    });
                }

                con.Close();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /* 
         * Query Metodunun Çalışma adımları:
         * Bağlantıyı Aç
         * Komuta query'yi ata
         * Komuta bağlantıyı ata
         * Komutu çalıştır
         * Bağlantıyı kapat
         * true değerini dön
         * 
         * Bu metodun bool değer döndürme sebebi şudur
         * metodun çağrıldığı yerde programın başarıyla çalışıp
         * çalışmadığını kontrol etmek
         */
        public bool Query(string query)
        {
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
