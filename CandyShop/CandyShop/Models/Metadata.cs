using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class ItemMetadata
    {
        [Key]
        public int ItemId { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
        [Required, Range(0,50)]
        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}