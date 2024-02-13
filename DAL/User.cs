using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {

        public int userID { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public int userType { get; set; }
        public string status { get; set; }
    }
}
