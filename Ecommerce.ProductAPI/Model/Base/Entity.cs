using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.ProductAPI.Model.Base
{
    public class Entity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
