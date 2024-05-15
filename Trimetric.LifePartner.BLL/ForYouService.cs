using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class ForYouService
    {
        public DataSet GetProfileData()
        {
            ForYouDAL forYouDAL = new ForYouDAL();
            return forYouDAL.GetProfileData();
        }
 

    }
}
