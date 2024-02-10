
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities
{
    internal class ProductEntity
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int ManufactureId { get; set; }
        public ManufactureEntity Manufacture { get; set; } = null!;
        public string Preamble { get; set; } = string.Empty!;
        public string Description { get; set; } = string.Empty!;
       

        public int CategoryId { get; set; }
        public CategoriesEntity Category { get; set; } = null!;


    }
}
