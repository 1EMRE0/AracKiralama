using System;
using System.Collections.Generic;
using System.Text;

namespace Arac.Domain.Entities
{
    public class CarDesc
    {
        public string CarDescID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string Detail { get; set; }
    }
}
