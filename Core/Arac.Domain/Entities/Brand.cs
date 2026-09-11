using System;
using System.Collections.Generic;
using System.Text;

namespace Arac.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public List<Car> Cars { get; set; }
        
    }
}
