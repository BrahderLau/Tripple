using System;
using System.ComponentModel.DataAnnotations;

namespace Tripple.Models
{
    public class DeliveryMan
    {
        [Key]
        public Guid DmId { get; set; }

        public string Name { get; set; }
    }
}
