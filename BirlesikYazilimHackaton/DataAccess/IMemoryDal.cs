namespace BirlesikYazilimHackaton.DataAccess
{
    public interface IMemoryDal<T> where T : class
    {
        List<T> GetAll();
    }
}
