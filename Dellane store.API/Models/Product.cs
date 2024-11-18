using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dellane_store.API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        [StringLength(100)]
        public string ProductDescription { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category? Category { get; set; }

        // Rename the foreign key property
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }  // Optional CustomerId

        [JsonIgnore]
        public virtual Customer? Customer { get; set; }
    }


}
