namespace PolarCape.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNumberAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeNumber");
        }
    }
}
