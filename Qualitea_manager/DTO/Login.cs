using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Login
    {
        public int loginID { get; set; }
        public int personID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int score { get; set; }
        public string role { get; set; }
    }
}
