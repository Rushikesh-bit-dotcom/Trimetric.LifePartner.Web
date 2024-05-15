using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using System.Data.Common;

namespace Trimetric.LifePartner.DAL
{
    public class HoroScopeDAL : BaseDAL
    {
       
        public HoroScopeInfo GetHoroScope(string ID)
        {
            string query = $"select * from HoroScope where UserID = {ID}";
            HoroScopeInfo horoScopeInfo = GetById<HoroScopeInfo>(query);
            return horoScopeInfo;
        
        }
        public void InsertHoroScope(HoroScopeInfo horoScopeInfo)
        {

            string commandText = "insert into HoroScope(UserID,NavrasName,Kuldevat,Zodic,Nadi,Charan,Constellation,Gotra,Gan,Mangal,Yoni,BirthDate,BirthTime,Date)" +
                "Values("+horoScopeInfo.UserID+",N'" + horoScopeInfo.NavrasName + "',N'" + horoScopeInfo.Kuldevat + "',N'" + horoScopeInfo.Zodic + "',N'" + horoScopeInfo.Nadi + "',N'" + horoScopeInfo.Charan + "',N'" + horoScopeInfo.Constellation + "',N'" + horoScopeInfo.Gotra + "',N'" + horoScopeInfo.Gan + "',N'" + horoScopeInfo.Mangal + "',N'" + horoScopeInfo.Yoni + "','" + horoScopeInfo.BirthDate + "','"+horoScopeInfo.BirthTime+"','"+horoScopeInfo.Date+"')";
            ExecuteCommand(commandText);
          
        }

       public void UpdateHoroScope(HoroScopeInfo horoScopeInfo)
        {
            string commandText = "update HoroScope set NavrasName =N'"+horoScopeInfo.NavrasName+"', Kuldevat = N'"+horoScopeInfo.Kuldevat+"', Zodic = N'"+horoScopeInfo.Zodic+"', Nadi = N'"+horoScopeInfo.Nadi+"', Charan = N'"+horoScopeInfo.Charan+"', Constellation = N'"+horoScopeInfo.Constellation+"',Gotra = N'"+horoScopeInfo.Gotra+"', Gan = N'"+horoScopeInfo.Gan+"',Mangal = N'"+horoScopeInfo.Mangal+"', Yoni = N'"+horoScopeInfo.Yoni+"',BirthDate = '"+horoScopeInfo.BirthDate.ToString("yyyy-MM-dd") + "',BirthTime ='"+horoScopeInfo.BirthTime.ToString("HH:mm")+ "',ModifiedDate='"+horoScopeInfo.ModifiedDate+"'" +
                " where HoroScopeID = " + horoScopeInfo.HoroScopeID;
            ExecuteCommand(commandText);
        }
        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            HoroScopeInfo horoScopeInfo = new HoroScopeInfo();
            horoScopeInfo.HoroScopeID = -1;

            while (dataReader.Read())
            {
                horoScopeInfo.HoroScopeID = Convert.ToInt32(dataReader["HoroScopeID"].ToString());
                horoScopeInfo.NavrasName = dataReader["NavrasName"].ToString();
                horoScopeInfo.Kuldevat = dataReader["Kuldevat"].ToString();
                horoScopeInfo.Zodic = dataReader["Zodic"].ToString();
                horoScopeInfo.Nadi = dataReader["Nadi"].ToString();
                horoScopeInfo.Charan = dataReader["Charan"].ToString();
                horoScopeInfo.Constellation = dataReader["Constellation"].ToString();
                horoScopeInfo.Gotra = dataReader["Gotra"].ToString();
                horoScopeInfo.Gan = dataReader["Gan"].ToString();
                horoScopeInfo.Mangal = dataReader["Mangal"].ToString();
                horoScopeInfo.Yoni = dataReader["Yoni"].ToString();
                horoScopeInfo.BirthDate = DateTime.Parse(dataReader["BirthDate"].ToString());
                horoScopeInfo.BirthTime = DateTime.Parse(dataReader["BirthTime"].ToString());
            }
            return horoScopeInfo as T;
        }
    }
}
