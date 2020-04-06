using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Products
    {
     [Key]
     [Required]
        public int ProductId { get; set; }
     [Required]
        public String  ProductName{ get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public double Price { get; set; }

         

    }
}
