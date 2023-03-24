using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int productID { get; set; }
        public int subcategoryID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }
}
