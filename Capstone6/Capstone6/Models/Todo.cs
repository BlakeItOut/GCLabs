using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Capstone6.Models
{
    public class Todo
    {
        [Key]
        public int TaskID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}"), DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }
    }
}
