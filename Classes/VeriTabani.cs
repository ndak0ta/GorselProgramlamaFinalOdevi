using GorselProgramlamaFinalOdevi.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi
{
    internal class VeriTabani
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ndak0ta\\source\\repos\\GorselProgramlamaFinalOdevi\\bin\\Debug\\VakıfbankDB.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dataReader;

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
                // MessageBox.Show("İşlem başarıyla gerçekleştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
