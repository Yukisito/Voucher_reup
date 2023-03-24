using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Coupon
    {
        public int couponID { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double percentageDiscount { get; set; }
        public double maxDiscount { get; set; }
    }
}
