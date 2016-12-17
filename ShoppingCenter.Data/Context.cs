using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    class Context : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Journal> Journal { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public Context() : base("localsql")
        {

        }
    }
}
