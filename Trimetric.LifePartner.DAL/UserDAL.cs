using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;

namespace Trimetric.LifePartner.DAL
{
    public class UserDAL : BaseDAL 
    {
        public UserInfo CheckUser(UserInfo userInfo)
        {
            string query = "select [UserID] from [User] where Mobile='"+userInfo.Mobile+"'";
            UserInfo userInfo2 = GetById<UserInfo>(query);
            return userInfo2;
        }

        public void InsertUser(UserInfo userInfo)
        {

            string commandText = "Insert into [dbo].[User] (Mobile,Password,Date) Values('" + userInfo.Mobile + "','" + userInfo.Password + "','"+userInfo.Date+"')";
            ExecuteCommand(commandText);
            
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

        //protected override T CreateEntity<T>(SqlDataReader dataReader)
        //{
        //    int profileID = -1;
        //    while (dataReader.Read())
        //    {
        //        profileID = dataReader["ProfileId"].GetHashCode();
        //    }
        //    return profileID as T;
        //}
    }
}
