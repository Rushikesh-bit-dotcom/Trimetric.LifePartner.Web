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
    public class FamilyDAL : BaseDAL
    {
        public FamilyInfo GetFamily(string ID)
        {
            string query = $"select * from Family where UserID = {ID}";
            FamilyInfo familyInfo = GetById<FamilyInfo>(query);
            return familyInfo;
        }
        public void InsertFamily(FamilyInfo familyInfo)
        {           
            string commandText = "Insert into Family (UserID,FatherName, FatherWork, MotherName, MotherWork, Brother, Sister,UncleName,UncleCity,OtherRelatives,Property,Date)" +
                "Values("+familyInfo.UserID+",'" + familyInfo.FatherName + "','" + familyInfo.FatherWork + "','" + familyInfo.MotherName + "','" + familyInfo.MotherWork + "','" + familyInfo.Brother + "','" + familyInfo.Sister + "','" + familyInfo.UncleName + "','" + familyInfo.UncleCity + "','" + familyInfo.OtherRelatives + "','" + familyInfo.Property + "','"+familyInfo.Date+"');";
            ExecuteCommand(commandText);
           
        }
       public void UpdateFamily(FamilyInfo familyInfo)
        {
            string commandText = "update Family set FatherName ='" + familyInfo.FatherName + "', FatherWork ='" + familyInfo.FatherWork + "', MotherName='" + familyInfo.MotherName + "', Brother='" + familyInfo.Brother + "', " +
                "Sister = '"+familyInfo.Sister+"', UncleName = '"+familyInfo.UncleName+ "', OtherRelatives='"+familyInfo.OtherRelatives+ "', Property='"+familyInfo.Property+ "', ModifiedDate='"+familyInfo.ModifiedDate+"' where FamilyID = " + familyInfo.FamilyID;
            ExecuteCommand(commandText);
        }
        protected override T GetEntity<T>(SqlDataReader dataReader) 
        {
            FamilyInfo familyInfo = new FamilyInfo();
            familyInfo.FamilyID = -1;

            while (dataReader.Read())
            {
                familyInfo.FamilyID = Convert.ToInt32(dataReader["FamilyID"].ToString());
                familyInfo.FatherName = dataReader["FatherName"].ToString();
                familyInfo.FatherWork = dataReader["FatherWork"].ToString();
                familyInfo.MotherName = dataReader["MotherName"].ToString();
                familyInfo.MotherWork = dataReader["MotherWork"].ToString();
                familyInfo.Brother = Convert.ToInt32(dataReader["Brother"].ToString());
                familyInfo.Sister = Convert.ToInt32(dataReader["Sister"].ToString());
                familyInfo.UncleName = dataReader["UncleName"].ToString();
                familyInfo.UncleCity = dataReader["UncleCity"].ToString();
                familyInfo.OtherRelatives = dataReader["OtherRelatives"].ToString();
                familyInfo.Property = dataReader["Property"].ToString();
            }

            return familyInfo as T;
        }
    }
}
