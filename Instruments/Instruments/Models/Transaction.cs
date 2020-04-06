using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instruments.Models
{
    public class Transaction
    {
        [Key]
        [Required]
        public int TransactionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public byte PhoneNumber { get; set; }

        [ForeignKey("Products")]
        public ICollection<Products> ProductId { get; set; }

    }
}
