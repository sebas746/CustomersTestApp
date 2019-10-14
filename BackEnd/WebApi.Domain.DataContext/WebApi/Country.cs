namespace WebApi.Domain.DataContext.WebApi
{
    using System.ComponentModel.DataAnnotations;
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [StringLength(5)]
        public string CountryCode { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }
    }
}
