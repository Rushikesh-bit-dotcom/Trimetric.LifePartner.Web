using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;

namespace Trimetric.LifePartner.DAL
{
    public class ForYouDAL : BaseDAL
    {
       public DataSet GetProfileData()
       {
            string commandText = "select * from [User] " +
                "inner join [Profile] on [User].UserID = [Profile].UserID " +
                "inner join Education on [User].UserID = Education.UserID " +
                "inner join Family on [User].UserID = Family.UserID " +
                "inner join Health on [User].UserID = Health.UserID " +
                "inner join HoroScope on [User].UserID = HoroScope.UserID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, _connString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            ExecuteCommand(commandText);
            
            return dataSet;
       }
        
     
        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            throw new NotImplementedException();
        }
    }
}
