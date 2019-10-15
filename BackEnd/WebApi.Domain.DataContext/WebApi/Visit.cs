namespace WebApi.Domain.DataContext.WebApi
{
    using System;    
    using System.ComponentModel.DataAnnotations;
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }

        public DateTime VisitDate { get; set; }

        public virtual SalesRepresentative SalesRepresentative { get; set; }

        public int VisitNet { get; set; }

        public long VisitTotal { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
