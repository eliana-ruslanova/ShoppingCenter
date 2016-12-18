namespace ShoppingCenter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Brand_Id = c.Int(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Brand_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        Invoice_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Invoice_Id, t.Item_Id })
                .ForeignKey("dbo.Invoices", t => t.Invoice_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Invoice_Id)
                .Index(t => t.Item_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.InvoiceItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.InvoiceItems", "Invoice_Id", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Items", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.InvoiceItems", new[] { "Item_Id" });
            DropIndex("dbo.InvoiceItems", new[] { "Invoice_Id" });
            DropIndex("dbo.Invoices", new[] { "Employee_Id" });
            DropIndex("dbo.Items", new[] { "Department_Id" });
            DropIndex("dbo.Items", new[] { "Brand_Id" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropTable("dbo.InvoiceItems");
            DropTable("dbo.Invoices");
            DropTable("dbo.Items");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Brands");
        }
    }
}
