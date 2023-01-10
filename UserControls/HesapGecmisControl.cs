using GorselProgramlamaFinalOdevi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi.UserControls
{
    public partial class HesapGecmisControl : UserControl
    {
        public HesapGecmisControl(IslemGecmisi islemGecmisi)
        {
            InitializeComponent();

            IslemNumarasıLabel.Text = islemGecmisi.Id.ToString();
            IslemTipiLabel.Text = islemGecmisi.Tipi.ToString();
            ParaDegisimiLabel.Text = islemGecmisi.ParaMiktari.ToString();
            AciklamaLabel.Text = islemGecmisi.Aciklama.ToString();

            if (islemGecmisi.ParaMiktari < 0)
                ParaDegisimiLabel.ForeColor = Color.Red;
            else if (islemGecmisi.ParaMiktari > 0)
                ParaDegisimiLabel.ForeColor = Color.Green;
        }
    }
}
