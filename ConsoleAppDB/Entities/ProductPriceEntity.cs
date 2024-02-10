
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities
{
    internal class ProductPriceEntity
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;
        public ProductEntity Products { get; set; } = null!;
        public decimal Price { get; set; }

        public decimal DiscountPrice { get; set;}

        public string CurrencyCode { get; set; } = null!;
        public CurrencyEntity Currency { get; set; } = null!;


    }
}
