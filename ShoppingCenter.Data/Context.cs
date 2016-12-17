using System.Data.Entity;

namespace ShoppingCenter.Data
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Journal> Journal { get; set; }

        public Context() : base("localsql") { }
    }
}
