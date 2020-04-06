using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Customer
    {
       [Key]
       [Required]
        public int CustomerID{ get; set; }
        [Required]
        public String CustomerName{ get; set; }
        [Required]
        public String CustomerEmail{ get; set; }
        [Required]
        public Boolean IsAMemeber { get; set; }

       //public ICollection<Products> ProductID { get; set; }
    }
}
