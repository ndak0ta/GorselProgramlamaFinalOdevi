using GorselProgramlamaFinalOdevi.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace GorselProgramlamaFinalOdevi.UserControls
{
    public partial class HesapGecmisControl : UserControl
    {
        public HesapGecmisControl(IslemGecmisi islemGecmisi)
        {
            InitializeComponent();

            // Gelen bilgileri Control'e yazdır
            IslemNumarasıLabel.Text = islemGecmisi.Id.ToString();
            IslemTipiLabel.Text = islemGecmisi.Tipi.ToString();
            ParaDegisimiLabel.Text = islemGecmisi.ParaMiktari.ToString();
            AciklamaLabel.Text = islemGecmisi.Aciklama.ToString();
            TarihSaatLabel.Text = islemGecmisi.TarihSaat.ToString("dd/MM/yyyy HH:mm");

            if (islemGecmisi.ParaMiktari < 0)
                ParaDegisimiLabel.ForeColor = Color.Red;
            else if (islemGecmisi.ParaMiktari > 0)
                ParaDegisimiLabel.ForeColor = Color.Green;
        }
    }
}
