using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instruments.Models
{
    public class Login
    {
        [Key]
        public String UserName { get; set; }

        public String Password { get; set; }

        public Boolean RememberMe { get; set; }

        [ForeignKey("Customer")]
        public ICollection<Customer> CustomerEmail { get; set; }

        //One to one
        //Login info has user name as the primary key and the customer email as the foregin key   
        
    }
}
