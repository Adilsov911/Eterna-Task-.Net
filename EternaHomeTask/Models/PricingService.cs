using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaHomeTask.Models
{
    public class PricingService
    {
        public int Id { get; set; }
        public int? PricingId { get; set; }
        public Pricing Pricing { get; set; }

        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
    }
}
