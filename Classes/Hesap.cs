using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaFinalOdevi
{
    public class Hesap
    {
        public int hesapId { get; set; }
        public string adi { get; set; }
        public string lokasyon { get; set; }
        public decimal paraMiktari { get; set; }
        public int musteriId { get; set; }
    }
}
