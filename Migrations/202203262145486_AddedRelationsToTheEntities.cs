namespace PolarCape.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelationsToTheEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectClients",
                c => new
                    {
                        Project_ProjectId = c.Int(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_ProjectId, t.Client_ClientId })
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.EmployeeProjects",
                c => new
                    {
                        Employee_EmployeeId = c.Int(nullable: false),
                        Project_ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_EmployeeId, t.Project_ProjectId })
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId, cascadeDelete: true)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.Project_ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeProjects", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.EmployeeProjects", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ProjectClients", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.ProjectClients", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.EmployeeProjects", new[] { "Project_ProjectId" });
            DropIndex("dbo.EmployeeProjects", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.ProjectClients", new[] { "Client_ClientId" });
            DropIndex("dbo.ProjectClients", new[] { "Project_ProjectId" });
            DropTable("dbo.EmployeeProjects");
            DropTable("dbo.ProjectClients");
        }
    }
}
