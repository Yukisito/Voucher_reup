using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderHeader
    {
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public double total { get; set; }
        public bool isOnlineOrder { get; set; }
        public int shipInfoID { get; set; }
        public int customerLoginID { get; set; }
        public int staffLoginID { get; set; }
        public int couponCode { get; set; }
    }
}
