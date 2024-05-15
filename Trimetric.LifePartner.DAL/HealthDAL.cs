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
    public class HealthDAL : BaseDAL
    {
        public HealthInfo GetHealth(string ID)
        {
            string query = $"select * from Health where UserID = {ID}";
            HealthInfo healthInfo = GetById<HealthInfo>(query);
            return healthInfo;

            
        }
        public void InsertHealth(HealthInfo healthInfo)
        {
            
            string commandText = "Insert into Health (UserID,Height, Weight, color, BloodType,Diet, Glasses,Date)" +
                "Values("+healthInfo.UserID+",'" + healthInfo.Height + "','" + healthInfo.Weight + "','" + healthInfo.Color + "','" + healthInfo.BloodType + "','" + healthInfo.Diet + "','" + healthInfo.Glasses + "','"+healthInfo.Date+"')";
           ExecuteCommand(commandText);
        }

        public void UpdateHealth(HealthInfo healthInfo)
        {
            string commadText = "update Health set Height ='"+healthInfo.Height+"', Weight ='"+healthInfo.Weight+"', color ='"+healthInfo.Color+"', BloodType ='"+healthInfo.BloodType+"', Diet ='"+healthInfo.Diet+ "', Glasses='"+healthInfo.Glasses+ "', ModifiedDate='"+healthInfo.ModifiedDate+"'" +
                "where HealthID =" + healthInfo.HealthID;
            ExecuteCommand(commadText);
        }
        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            HealthInfo healthInfo = new HealthInfo();
            healthInfo.HealthID = -1;

            while (dataReader.Read())
            {
                healthInfo.HealthID = Convert.ToInt32(dataReader["HealthID"].ToString());
                healthInfo.Height = dataReader["Height"].ToString();
                healthInfo.Weight = dataReader["Weight"].ToString();
                healthInfo.Color = dataReader["color"].ToString();
                healthInfo.BloodType = dataReader["BloodType"].ToString();
                healthInfo.Diet = dataReader["Diet"].ToString();
                healthInfo.Glasses = dataReader["Glasses"].ToString();
            }
            return healthInfo as T;
        }
    }
}
