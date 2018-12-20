using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BatFriends.DTO
{
    public class SpeciesDTO
    {
        public int SpeciesId { get; set; }
        [Display(Name = "Common Name")]
        public string CommonName { get; set; } = "";
        [Display(Name = "Species")]
        public string SpeciesName { get; set; } = "";
        public string Genus { get; set; } = "";
        public string Family { get; set; } = "";
        [Display(Name = "Fun Fact")]
        public string FunFact { get; set; } = "";
        public string PicURL { get; set; }
        public virtual ICollection<BatDTO> Bats { get; set; }
    }
}