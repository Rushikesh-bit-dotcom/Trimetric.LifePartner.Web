using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;

namespace Trimetric.LifePartner.DAL
{
    public class CreateProfileButtonsDAL : BaseDAL
    {


        //public void GetValue(CreateProfileButtonsInfo createProfileButtonsInfo)
        //  {
        //      string commandText = "TableJoining";
        //      ExecuteStoredProceduce(commandText);
        //  }

        public CreateProfileButtonsInfo GetValue(string ID)
        {
            string query = $"SELECT * FROM Profile where UserID = {ID}";
            CreateProfileButtonsInfo createProfileButtonsInfo = GetById<CreateProfileButtonsInfo>(query);
            return createProfileButtonsInfo;
        }

        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            //throw new NotImplementedException();
            CreateProfileButtonsInfo createProfileButtonsInfo = new CreateProfileButtonsInfo();
            createProfileButtonsInfo.UserID = -1;
            while (dataReader.Read())
            {
                createProfileButtonsInfo.UserID = Convert.ToInt32(dataReader["UserID"]);
                createProfileButtonsInfo.Name = dataReader["FullName"].ToString();
                createProfileButtonsInfo.Sex = dataReader["Sex"].ToString();
                createProfileButtonsInfo.Age = Convert.ToInt32(dataReader["Age"]);
                createProfileButtonsInfo.Religion = dataReader["Religion"].ToString();
                createProfileButtonsInfo.Caste = dataReader["Caste"].ToString();
                createProfileButtonsInfo.Address = dataReader["Address"].ToString();
                createProfileButtonsInfo.State = dataReader["State"].ToString();
                createProfileButtonsInfo.District = dataReader["District"].ToString();
                createProfileButtonsInfo.Postalcode = dataReader["PostalCode"].ToString();
                createProfileButtonsInfo.Phone = dataReader["Mobile"].ToString();

            }
            return createProfileButtonsInfo as T;

        }

      
    }
}
