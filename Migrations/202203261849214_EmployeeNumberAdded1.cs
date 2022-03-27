namespace PolarCape.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNumberAdded1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Clients", "Company", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
