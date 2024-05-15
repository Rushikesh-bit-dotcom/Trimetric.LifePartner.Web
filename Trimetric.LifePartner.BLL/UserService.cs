using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class UserService
    {
        public void InsertUser(UserInfo userInfo)
        {
            UserDAL userDAL = new UserDAL();
            userDAL.InsertUser(userInfo); 
        }
        public UserInfo CheckUser(UserInfo userInfo)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.CheckUser(userInfo);
        }

    }
}
