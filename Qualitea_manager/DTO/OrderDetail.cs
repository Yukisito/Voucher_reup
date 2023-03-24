using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {
        public int orderDetail { get; set; }
        public int orderID { get; set; }
        public int quantity { get; set; }
        public double totalLine { get; set; }
        public int productID { get; set; }
    }
}
