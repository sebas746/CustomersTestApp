namespace WebApi.Domain.DataContext.WebApi
{
    using global::WebApi.Domain.DataContext.Migrations;
    using System.Data.Entity;
    public partial class WebApiDataContext : DbContext
    {
        public WebApiDataContext() : base("name=WebApiDataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebApiDataContext, Configuration>());
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<SalesRepresentative> SalesRepresentatives { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
    }
}
