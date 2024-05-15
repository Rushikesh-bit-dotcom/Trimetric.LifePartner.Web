using System;
using System.Collections.Generic;
using System.Text;

namespace Trimetric.LifePartner.BDO
{
    public class UserInfo 
    {
        public int UserID {  get; set; }
        public Int64 Mobile { get;set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
