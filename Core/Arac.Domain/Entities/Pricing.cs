using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Arac.Domain.Entities
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string PricingName { get; set; }

        public List<CarPricing> CarPricings { get; set; }

    }
}
