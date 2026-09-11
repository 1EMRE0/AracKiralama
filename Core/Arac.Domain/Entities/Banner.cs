using System;
using System.Collections.Generic;
using System.Text;

namespace Arac.Domain.Entities
{
    public class Banner
    {
        public int BannerID { get; set; }
        public int Title { get; set; }
        public string BannerDesc { get; set; }
        public string BannerVideoDesc { get; set; }
        public string BannerUrl { get; set; }
      
    }
}
