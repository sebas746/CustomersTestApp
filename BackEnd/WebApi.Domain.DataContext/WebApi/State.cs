namespace WebApi.Domain.DataContext.WebApi
{
    using System.ComponentModel.DataAnnotations;
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [StringLength(5)]
        public string StateCode { get; set; }

        [StringLength(100)]
        public string StateName { get; set; }

        public virtual Country Country { get; set; }
    }
}
