
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities
{
    internal class ManufactureEntity
    {
        [Key]
        public int Id { get; set; }
        public string Manufactures { get; set; } = null!;
    }
}
