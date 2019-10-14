namespace WebApi.Domain.DataContext.WebApi
{
    using System.ComponentModel.DataAnnotations;
    public class SalesRepresentative
    {
        [Key]
        public int SalesRepresentativeId { get; set; }

        [StringLength(50)]
        public string SalesRepresentativeName { get; set; }
    }
}
