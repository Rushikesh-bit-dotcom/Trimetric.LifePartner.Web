using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trimetric.LifePartner.BDO
{
    public class FamilyInfo 
    {
        public int FamilyID { get; set; }
        public int UserID { get; set; }
        public int Family { get; set; }

        public string FatherName { get; set; }

        public string FatherWork { get; set; }

        public string MotherName { get; set; }

        public string MotherWork {  get; set; }

        public Int32 Brother { get; set; }

        public Int32 Sister { get; set; }

        public string UncleName { get; set; }

        public string UncleCity { get; set; }

        public string OtherRelatives { get; set; }

        public string Property {  get; set; }

        public DateTime Date { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}