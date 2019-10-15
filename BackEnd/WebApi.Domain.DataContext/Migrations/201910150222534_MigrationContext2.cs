namespace WebApi.Domain.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationContext2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Visits", "VisitNet", c => c.Int(nullable: false));
            AddColumn("dbo.Visits", "VisitTotal", c => c.Long(nullable: false));
            AddColumn("dbo.Visits", "Description", c => c.String(maxLength: 1000));
            DropColumn("dbo.Visits", "Nit");
            DropColumn("dbo.Visits", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Visits", "FullName", c => c.String(maxLength: 60));
            AddColumn("dbo.Visits", "Nit", c => c.String(maxLength: 50));
            DropColumn("dbo.Visits", "Description");
            DropColumn("dbo.Visits", "VisitTotal");
            DropColumn("dbo.Visits", "VisitNet");
        }
    }
}
