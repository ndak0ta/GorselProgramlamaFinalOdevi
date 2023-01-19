namespace GorselProgramlamaFinalOdevi.Classes
{
    public class KrediKarti
    {
        public int Id { get; set; }
        public int Limit { get; set; }
        public bool Anakart { get; set; }
        public decimal Borc { get; set; }
        public bool OnlineAlisveris { get; set; }
        public int HesapKesim { get; set; }
        public int MusteriId { get; set; }
        public int HesapId { get; set; }
    }
}
