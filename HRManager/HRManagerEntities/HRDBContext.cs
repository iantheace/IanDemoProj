using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerEntities
{
    public class HRDBContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }


        public HRDBContext(DbContextOptions<HRDBContext> options) : base(options)
        {
      
      
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(local)\SQLEXPRESS; Integrated Security=True;");
            }
        }



    }
}
