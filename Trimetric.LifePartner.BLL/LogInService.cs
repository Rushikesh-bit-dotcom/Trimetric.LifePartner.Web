using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class LogInService
    {
        public UserInfo GetProfileIdByUser(UserInfo userInfo)
        {
            LogInDAL logInDAL = new LogInDAL();
            return logInDAL.GetProfileIdByUser(userInfo);
        }
    }
}
