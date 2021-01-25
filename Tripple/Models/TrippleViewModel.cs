using System.Collections.Generic;
using Tripple.Data;

namespace Tripple.Models
{
    public class TrippleViewModel
    {
        public TrippleViewModel()
        {
            DeliveryMan = new List<DeliveryMan>();
            Customer = new List<Customer>();
        }

        public List<DeliveryMan> DeliveryMan { get; set; }
        public List<Customer> Customer { get; set; }
    }
}