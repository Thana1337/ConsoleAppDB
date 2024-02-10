using ConsoleAppDB.Contexts;
using ConsoleAppDB.Entities;

namespace ConsoleAppDB.Repositories
{
    internal class CurrencyRepository : Repo<CurrencyEntity>
    {
        public CurrencyRepository(DataContext context) : base(context)
        {
        }
    }


}
