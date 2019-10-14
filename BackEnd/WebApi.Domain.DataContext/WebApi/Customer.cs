namespace WebApi.Domain.DataContext.WebApi
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
                
        public int CountryId { get; set; }

        public int StateId { get; set; }

        public long CityId { get; set; }

        public int CreditLimit { get; set; }

        public int AvailableCredit { get; set; }

        public int VisitsPercentaje { get; set; }

        public virtual List<Visit> Visits { get; set; }
    }
}
