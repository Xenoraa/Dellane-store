using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Dellane_store.API.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Description { get; set; } = string.Empty;

        // Navigation property for related products
        [JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }
}
