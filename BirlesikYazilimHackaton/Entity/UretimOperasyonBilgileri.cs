namespace BirlesikYazilimHackaton.Entity
{
    public class UretimOperasyonBilgileri
    {
        public int Id { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public TimeSpan ToplamSure { get; set; }
        public string Statu { get; set; }
        public string DurusNedeni { get; set; }
    }
}
