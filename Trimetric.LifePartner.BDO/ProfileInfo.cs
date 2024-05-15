using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trimetric.LifePartner.BDO
{
    public class ProfileInfo
    {
        
        public int ProfileID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }

        public string Religion { get; set; }

        public string Sex { get; set; }

        public string Caste { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Postalcode { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}