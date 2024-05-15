using System;
using System.Collections.Generic;
using System.Text;

namespace Trimetric.LifePartner.BDO
{
    public class HoroScopeInfo
    {
      
        public int HoroScopeID { get; set; }
        public int UserID { get; set; }
        public string NavrasName { get; set; }
        public string Kuldevat { get; set; }
        public string Zodic {  get; set; }  
        public string Nadi {  get; set; }
        public string Charan {  get; set; }
        public string Constellation {  get; set; }
        public string Gotra {  get; set; }
        public string Gan {  get; set; }
        public string Mangal {  get; set; }
        public string Yoni {  get; set; }
        public DateTime BirthDate {  get; set; }
        public DateTime BirthTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
