using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;

namespace Trimetric.LifePartner.DAL
{
    public class LogInDAL : BaseDAL
    {
        public UserInfo GetProfileIdByUser(UserInfo userInfo)
        {
            //LINQ (Language Integrated Query .  .NET 3.5 framework. ):
            string query = "select [UserID]  from [dbo].[User] where Mobile = '" + userInfo.Mobile + "' and Password = '" + userInfo.Password + "'";
            UserInfo userInfo2 = GetById<UserInfo>(query);
            return userInfo2;
        }

        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserID = -1;
            while (dataReader.Read())
            {
                userInfo.UserID = Convert.ToInt32(dataReader["UserID"]);
            }
            return userInfo as T;
        }
    }
}
//The GetHashCode method provides a hash code for algorithms that need quick checks of object equality.