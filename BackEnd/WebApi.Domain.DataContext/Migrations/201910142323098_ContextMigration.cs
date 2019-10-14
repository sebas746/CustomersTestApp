namespace WebApi.Domain.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Long(nullable: false, identity: true),
                        CityName = c.String(maxLength: 150),
                        State_StateId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.States", t => t.State_StateId)
                .Index(t => t.State_StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateCode = c.String(maxLength: 5),
                        StateName = c.String(maxLength: 100),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 5),
                        CountryName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Nit = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 60),
                        Address = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        CityId = c.Long(nullable: false),
                        CreditLimit = c.Int(nullable: false),
                        AvailableCredit = c.Int(nullable: false),
                        VisitsPercentaje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        VisitId = c.Int(nullable: false, identity: true),
                        Nit = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 60),
                        VisitDate = c.DateTime(nullable: false),
                        SalesRepresentative_SalesRepresentativeId = c.Int(),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.VisitId)
                .ForeignKey("dbo.SalesRepresentatives", t => t.SalesRepresentative_SalesRepresentativeId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.SalesRepresentative_SalesRepresentativeId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.SalesRepresentatives",
                c => new
                    {
                        SalesRepresentativeId = c.Int(nullable: false, identity: true),
                        SalesRepresentativeName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SalesRepresentativeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Visits", "SalesRepresentative_SalesRepresentativeId", "dbo.SalesRepresentatives");
            DropForeignKey("dbo.Cities", "State_StateId", "dbo.States");
            DropForeignKey("dbo.States", "Country_CountryId", "dbo.Countries");
            DropIndex("dbo.Visits", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Visits", new[] { "SalesRepresentative_SalesRepresentativeId" });
            DropIndex("dbo.States", new[] { "Country_CountryId" });
            DropIndex("dbo.Cities", new[] { "State_StateId" });
            DropTable("dbo.SalesRepresentatives");
            DropTable("dbo.Visits");
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
        }
    }
}
