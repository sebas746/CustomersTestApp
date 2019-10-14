namespace WebApi.Domain.DataContext.WebApi
{
    using System.ComponentModel.DataAnnotations;
    public class City
    {
        [Key]
        public long CityId { get; set; }

        [StringLength(150)]
        public string CityName { get; set; }

        public virtual State State { get; set; }
    }
}
