namespace WebApi.Domain.DataContext.WebApi
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}
