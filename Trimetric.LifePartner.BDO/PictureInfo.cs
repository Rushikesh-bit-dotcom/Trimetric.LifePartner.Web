using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Trimetric.LifePartner.BDO
{
    public class PictureInfo
    {
        public int UserID { get; set; }
        public int PictureID { get; set; }
        public byte[] Image { get; set; }
        public DateTime Date {  get; set; }
        public DateTime ModifiedDate { get; set; }
      
    }
}
