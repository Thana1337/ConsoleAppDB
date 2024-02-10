using ConsoleAppDB.Contexts;
using ConsoleAppDB.Entities;

namespace ConsoleAppDB.Repositories
{
    internal class ProductPriceRepository : Repo<ProductPriceEntity>
    {
        public ProductPriceRepository(DataContext context) : base(context)
        {
        }
    }


}
