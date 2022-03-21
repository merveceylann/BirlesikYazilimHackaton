namespace BirlesikYazilimHackaton.Entity
{
    public class StandartDuruslar
    {
        public int Id { get; set; }
        public TimeSpan Baslangic { get; set; }
        public TimeSpan Bitis { get; set; }
        public string DurusNedeni { get; set; }
    }
}
