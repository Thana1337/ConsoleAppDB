using ConsoleAppDB.Contexts;
using ConsoleAppDB.Entities;

namespace ConsoleAppDB.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }


}
