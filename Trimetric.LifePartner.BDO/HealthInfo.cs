using System;
using System.Collections.Generic;
using System.Text;

namespace Trimetric.LifePartner.BDO
{
    public class HealthInfo
    {
   
        public int HealthID { get; set; }
        public int UserID { get; set; }
        public string Height { get; set; }

        public string Weight {  get; set; } 

        public string Color { get; set; }

        public string BloodType {  get; set; }

        public string Glasses {  get; set; }

        public string Diet {  get; set; }

        public DateTime Date { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
