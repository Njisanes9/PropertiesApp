using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Property
    {
        public int propertyID { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public byte[] image { get; set; }
        public int propTypeID { get; set; }
        public int subID { get; set; }
        public string status { get; set; }

    }
}
