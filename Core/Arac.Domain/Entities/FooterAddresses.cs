using System;
using System.Collections.Generic;
using System.Text;

namespace Arac.Domain.Entities
{
    public class FooterAddresses
    {
        public int FooterAddressesID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
