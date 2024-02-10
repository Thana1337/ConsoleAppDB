

using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDB.Entities
{
    internal class CustomerEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public int AdressId { get; set; }
        public AdressEntity Address { get; set; } = null!;

    }
}
