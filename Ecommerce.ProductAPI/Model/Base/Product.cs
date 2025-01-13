using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.ProductAPI.Model.Base
{
    [Table("product")]
    public class Product : Entity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("category_name")]
        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
