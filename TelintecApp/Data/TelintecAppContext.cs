using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelintecApp.Models;

namespace TelintecApp.Data
{
    public class TelintecAppContext : DbContext
    {
        public TelintecAppContext (DbContextOptions<TelintecAppContext> options)
            : base(options)
        {
        }

        public DbSet<TelintecApp.Models.Department> Department { get; set; } = default!;

        public DbSet<TelintecApp.Models.Employee>? Employee { get; set; }

        public DbSet<TelintecApp.Models.Holiday>? Holiday { get; set; }
    }
}
