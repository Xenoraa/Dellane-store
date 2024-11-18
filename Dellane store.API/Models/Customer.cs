using System.ComponentModel.DataAnnotations;

namespace Dellane_store.API.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Address { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // Navigation property for related products
        public virtual List<Product>? Products { get; set; }
    }
}
