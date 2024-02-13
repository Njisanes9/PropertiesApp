using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rental
    {
        public int rentalID { get; set; }
        public int propID { get; set; }
        public int tenantID { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string status { get; set; }

    }
}
