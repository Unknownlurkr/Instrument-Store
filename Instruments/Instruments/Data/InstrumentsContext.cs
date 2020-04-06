using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Instruments.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Instruments.Data
{
    public class InstrumentsContext : DbContext
    {
        public InstrumentsContext(DbContextOptions<InstrumentsContext> options)
            : base(options)
        {
         
        }

        public DbSet<Instruments.Models.Customer> Customer { get; set; }

        public DbSet<Instruments.Models.Products> Products { get; set; }

        public DbSet<Instruments.Models.Transaction> Transaction { get; set; }

        public DbSet<Instruments.Models.Login> Login { get; set; }
    }

    public class ApplicationRole
    {
    }

    public class ApplicationUser
    {
    }
}
