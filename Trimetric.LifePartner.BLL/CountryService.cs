using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class CountryService
    {
        public DataSet GetCountry()
        {
            CountryDAL countryDAL = new CountryDAL();
            return countryDAL.GetCountry();
        }
    }
}
