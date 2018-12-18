using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelFirstFramework.Models
{
    public class MovieMetadata
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        [Required, Range(1950,2050)]
        public int Year { get; set; }
        public Nullable<int> DirectorID { get; set; }
        public string Watched { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Characters { get; set; }
        public virtual Director Director { get; set; }
    }
}