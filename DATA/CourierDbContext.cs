using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.DATA_MODEL;

namespace Courier_Management_System.Data
{
    public class CourierDbContext : DbContext
    {
        public CourierDbContext (DbContextOptions<CourierDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
