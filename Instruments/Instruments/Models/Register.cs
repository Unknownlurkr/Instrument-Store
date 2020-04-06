using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Register
    {
        [Key]
        [Required]
        public String NewUserName { get; set; }
        [Required]
        public String NewUserEmail { get; set; }
        [Required]
        public String ConfirmEmail { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String ConfirmPassword { get; set; }

    }
}
