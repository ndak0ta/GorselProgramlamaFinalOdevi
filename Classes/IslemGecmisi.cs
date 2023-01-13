using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaFinalOdevi.Classes
{
    public class IslemGecmisi
    {
        public int Id { get; set; }
        public string Tipi { get; set; }
        public string Aciklama { get; set;}
        public decimal ParaMiktari { get; set; }
        public DateTime TarihSaat { get; set; }
        public int HesapId { get; set; }
        public int MusteriId { get; set; }
    }
}
