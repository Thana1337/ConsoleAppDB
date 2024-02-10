
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities

{
    internal class CurrencyEntity
    {
        [Key]
        public string Code { get; set; } = null!;
        public string Currency { get; set; } = null!;
    }
}
