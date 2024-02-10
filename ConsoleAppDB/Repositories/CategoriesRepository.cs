using ConsoleAppDB.Contexts;
using ConsoleAppDB.Entities;

namespace ConsoleAppDB.Repositories
{
    internal class CategoriesRepository : Repo<CategoriesEntity>
    {
        public CategoriesRepository(DataContext context) : base(context)
        {
        }
    }

    {


}
