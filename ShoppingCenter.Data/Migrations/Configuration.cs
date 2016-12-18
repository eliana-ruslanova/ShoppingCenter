namespace ShoppingCenter.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingCenter.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ShoppingCenter.Data.Context";
        }

        protected override void Seed(ShoppingCenter.Data.Context context)
        {
            var brand1 = new Brand { Name = "Canada Goose" };
            var brand2 = new Brand { Name = "Calvin Klein" };
            var brand3 = new Brand { Name = "Nike" };
            var brand4 = new Brand { Name = "Adidas" };
            var brand5 = new Brand { Name = "Apple" };
            var brand6 = new Brand { Name = "Samsung" };
            var brand7 = new Brand { Name = "Lego" };
            var brand8 = new Brand { Name = "Disney" };

            List<Employee> employees1 = new List<Employee>();
            List<Employee> employees2 = new List<Employee>();
            List<Employee> employees3 = new List<Employee>();
            List<Employee> employees4 = new List<Employee>();

            employees1.Add(new Employee { Name = "Adam Smith", BirthDate = new DateTime(1995, 8, 17) });
            employees2.Add(new Employee { Name = "Taemin Lee", BirthDate = new DateTime(1993, 7, 18) });
            employees3.Add(new Employee { Name = "Elsa Worington", BirthDate = new DateTime(1996, 12, 31) });
            employees4.Add(new Employee { Name = "Joann Klark", BirthDate = new DateTime(1993, 10, 22) });

            List<Item> items1 = new List<Item>();
            List<Item> items2 = new List<Item>();
            List<Item> items3 = new List<Item>();
            List<Item> items4 = new List<Item>();

            List<Invoice> invoices1 = new List<Invoice>();
            List<Invoice> invoices2 = new List<Invoice>();
            invoices1.Add(new Invoice { Date = new DateTime(2016, 12, 17), Items = items1, TotalCost = 1800, Employee = employees1.ElementAt(0) });
            invoices2.Add(new Invoice { Date = new DateTime(2016, 12, 16), Items = items3, TotalCost = 1400, Employee = employees3.ElementAt(0)});

            items1.Add(new NormalItem { Name = "Kensington Parka", Price = 850, Brand = brand1, Invoices = invoices1 });
            items1.Add(new NormalItem { Name = "Trillium Parka", Price = 900, Brand = brand1, Invoices = invoices1 });
            items1.Add(new DiscountItem { Name = "T-Shirt Butterfly", Price = 100, Brand = brand2, Discount = 50, Invoices = invoices1 });
            items2.Add(new NormalItem { Name = "Air Max Zero", Price = 900, Brand = brand3 });
            items2.Add(new DiscountItem { Name = "Originals Jeans City Series", Price = 200, Brand = brand4, Discount = 20 });
            items3.Add(new NormalItem { Name = "iPhone 7s plus", Price = 900, Brand = brand5, Invoices = invoices2 });
            items3.Add(new GiftItem { Name = "Bluetooth Headphones", Price = 20, Brand = brand6, Invoices = invoices2 });
            items3.Add(new NormalItem { Name = "Samsung Galaxy S7 edge", Price = 500, Brand = brand6, Invoices = invoices2 });
            items4.Add(new GiftItem { Name = "Teddy Bear", Price = 5, Brand = brand7 });
            items4.Add(new NormalItem { Name = "Minnie Mouse", Price = 20, Brand = brand8 });

            context.Departments.AddOrUpdate(c => c.Name,
                new Department { Name = "Clothes", Employees = employees1, Items = items1 },
                new Department { Name = "Shoes", Employees = employees2, Items = items2 },
                new Department { Name = "Electronics", Employees = employees3, Items = items3 },
                new Department { Name = "Toys", Employees = employees4, Items = items4 });

        }
    }
}
