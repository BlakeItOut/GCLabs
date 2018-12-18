using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GCCandyShop.Models
{
    public class ItemMetadata
    {
        public int ItemId { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}