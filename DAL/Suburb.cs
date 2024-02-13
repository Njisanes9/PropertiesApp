using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Suburb
    {

        public int suburbID { get; set; }

        public string subDescr { get; set; }

        public string postalCode { get; set; }

        public int cityID { get; set; }
    }
}
