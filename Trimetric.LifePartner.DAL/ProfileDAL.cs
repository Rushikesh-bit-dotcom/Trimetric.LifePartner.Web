using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;

namespace Trimetric.LifePartner.DAL
{
    public class ProfileDAL : BaseDAL
    {    
        public ProfileInfo GetProfile(string ID)
        {
            string query = $"SELECT * FROM Profile where UserID = {ID}";
            ProfileInfo  profileInfo= GetById<ProfileInfo>(query);
            return profileInfo;
        }   
        public DataTable SetProfile()
        {
            string commandText = "Select * from Profile";
            SqlDataAdapter adapter = new SqlDataAdapter(commandText,_connString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);          
            ExecuteCommand(commandText);
            return dataTable;
        }
    
        protected override T GetEntity<T>(SqlDataReader dataReader)
        {  
            ProfileInfo profileInfo = new ProfileInfo();
            profileInfo.ProfileID = -1;
            while (dataReader.Read())
            {
                profileInfo.ProfileID = Convert.ToInt32(dataReader["ProfileID"]);
                profileInfo.Name = dataReader["FullName"].ToString();
                profileInfo.Sex = dataReader["Sex"].ToString();
                profileInfo.Age = Convert.ToInt32( dataReader["Age"]);
                profileInfo.Religion = dataReader["Religion"].ToString();
                profileInfo.Caste = dataReader["Caste"].ToString();
                profileInfo.Address = dataReader["Address"].ToString();
                profileInfo.State = dataReader["State"].ToString();
                profileInfo.District = dataReader["District"].ToString();
                profileInfo.Postalcode = dataReader["PostalCode"].ToString();
                profileInfo.Phone = dataReader["Mobile"].ToString();    
                
            }  
                return profileInfo as T;  
        }

        public void InsertProfile(ProfileInfo profileInfo)
        {
            string commandText = "insert into Profile(UserID,FullName,Sex,Age,Religion,Caste,Address,State,District,PostalCode,Mobile,Date)" +
                "Values("+ profileInfo.UserID +",'" + profileInfo.Name + "','" + profileInfo.Sex + "','" + profileInfo.Age + "','" + profileInfo.Religion + "','" + profileInfo.Caste + "','" + profileInfo.Address + "','" + profileInfo.State + "','" + profileInfo.District + "','" + profileInfo.Postalcode + "','" + profileInfo.Phone + "','"+profileInfo.Date+"')";
            ExecuteCommand(commandText); 
        }

        public void UpdateProfile(ProfileInfo profileInfo)
        {
            string commandText = "update Profile set FullName = '" + profileInfo.Name + "', Sex = '" + profileInfo.Sex + "', Age = '" + profileInfo.Age + "', Religion = '" + profileInfo.Religion + "', Caste = '" + profileInfo.Caste + "'," +
                   "Address = '" + profileInfo.Address + "', State = '" + profileInfo.State + "',District = '" + profileInfo.District + "', PostalCode = '" + profileInfo.Postalcode + "', Mobile = '" + profileInfo.Phone + "',ModifiedDate ='" + profileInfo.ModifiedDate+"' where ProfileID = " + profileInfo.ProfileID;
            ExecuteCommand(commandText);
        }
    }
}
