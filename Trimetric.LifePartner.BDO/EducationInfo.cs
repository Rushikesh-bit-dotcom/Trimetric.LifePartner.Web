using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trimetric.LifePartner.BDO
{
    public class EducationInfo 
    {

        public int EducationID { get; set; }
        public int UserID { get; set; }
        public string Education { get; set; }

        public string WorkType {  get; set; }

        public string WorkingAt { get; set; }

        public string WorkAddress {  get; set; }

        public string Salary {  get; set; }        

        public int MonthlySalary {  get; set; } 
        
        public int AnnualSalary {  get; set; }

        public DateTime Date { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}