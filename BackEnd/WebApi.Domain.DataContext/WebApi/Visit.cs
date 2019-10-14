namespace WebApi.Domain.DataContext.WebApi
{
    using System;    
    using System.ComponentModel.DataAnnotations;
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        public DateTime VisitDate { get; set; }

        public virtual SalesRepresentative SalesRepresentative { get; set; }
    }
}
