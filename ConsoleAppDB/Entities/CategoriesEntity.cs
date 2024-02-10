
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities
{
    internal class CategoriesEntity
    {
        [Key]
        public int Id { get; set;}
        public int ParentCategoryId { get; set;}
        public string CategoryName { get; set; } = null!;

        public CategoriesEntity ParentCategory { get; set; } = null!;
    }
}
