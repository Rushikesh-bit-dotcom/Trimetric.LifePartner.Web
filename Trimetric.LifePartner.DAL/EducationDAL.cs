using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using System.Data.Common;
using System.CodeDom.Compiler;
namespace Trimetric.LifePartner.DAL
{
    public class EducationDAL : BaseDAL 
    {
        
        public EducationInfo GetEducation(string userID)
        {
            string query = $"SELECT *  FROM  [dbo].[Education] where UserID = {userID}";
            EducationInfo educationInfo = GetById<EducationInfo>(query);
            return educationInfo;                 
        }

        public void InsertEducation(EducationInfo educationInfo)
        {         
            string commandText = "Insert into Education(UserID,Education, WorkType, WorkingAt,WorkAddress,MonthSalary,AnnualSalary,Date)" +
                "Values("+educationInfo.UserID+",'" + educationInfo.Education + "','" + educationInfo.WorkType + "','" + educationInfo.WorkingAt + "','" + educationInfo.WorkAddress + "','" + educationInfo.MonthlySalary + "','" + educationInfo.AnnualSalary + "','"+educationInfo.Date+"')";
            ExecuteCommand(commandText);
        }

        public void UpdateEducation(EducationInfo educationInfo)
        {         
            string commandText = "update Education set Education = '" + educationInfo.Education + "', WorkType = '" + educationInfo.WorkType + "', WorkingAt = '" + educationInfo.WorkingAt + "', WorkAddress ='" + educationInfo.WorkAddress + "'," +
                "MonthSalary = '" + educationInfo.MonthlySalary + "', AnnualSalary = '" + educationInfo.AnnualSalary + "',ModifiedDate='"+educationInfo.ModifiedDate+"' where EducationID = " + educationInfo.EducationID;
            ExecuteCommand(commandText);        
        }

        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            EducationInfo educationInfo = new EducationInfo();
            educationInfo.EducationID = -1;
            while (dataReader.Read())
            {
                educationInfo.EducationID = Convert.ToInt32(dataReader["EducationID"]);
                educationInfo.Education = dataReader["Education"].ToString();
                educationInfo.WorkType = dataReader["WorkType"].ToString();
                educationInfo.WorkingAt = dataReader["WorkingAt"].ToString();
                educationInfo.WorkAddress = dataReader["WorkAddress"].ToString();
                educationInfo.MonthlySalary = Convert.ToInt32(dataReader["MonthSalary"].ToString());
                educationInfo.AnnualSalary = Convert.ToInt32(dataReader["AnnualSalary"].ToString());
            }
            return educationInfo as T;
        }

    }
}
