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
    public class CountryDAL : BaseDAL
    {
        public DataSet GetCountry()
        {
            string commandText = "Select CountryName, CountryCode from Country";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, _connString);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ExecuteCommand(commandText);
            return dataSet;
        }

        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
            throw new NotImplementedException();
        }
    }
}
