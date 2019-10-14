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

        public virtual DbSet<Customers> Customers { get; set; }
    }
}
