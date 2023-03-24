using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CouponRedemptions
    {
        public int code { get; set; }
        public int couponID { get; set; }
        public int loginID { get; set; }
        public DateTime redemptionDate { get; set }
    }
}
