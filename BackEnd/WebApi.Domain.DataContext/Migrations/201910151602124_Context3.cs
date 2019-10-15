namespace WebApi.Domain.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Context3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Visits", "CityId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Visits", "CityId");
        }
    }
}
