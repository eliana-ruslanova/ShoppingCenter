namespace ShoppingCenter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Name");
        }
    }
}
