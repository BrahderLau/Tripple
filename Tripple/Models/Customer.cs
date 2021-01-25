using System;
using System.ComponentModel.DataAnnotations;

namespace Tripple.Models
{
    public class Customer
    {
        [Key]
        public Guid CustId { get; set; }

        public string Name { get; set; }
    }
}
