using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;
namespace Trimetric.LifePartner.BLL
{
    public class HealthService
    {
        
        public HealthInfo GetHealth(string ID)
        {

          HealthDAL healthDAL = new HealthDAL();
           HealthInfo healthInfo= healthDAL.GetHealth(ID);
            return healthInfo;
        }
        public void InsertHealth(HealthInfo healthInfo)
        {
            HealthDAL healthDAL = new HealthDAL();
            healthDAL.InsertHealth(healthInfo);
        }
        public void UpdateHealth(HealthInfo healthInfo)
        {
            HealthDAL healthDAL = new HealthDAL();
            healthDAL.UpdateHealth(healthInfo);
        }
    }
}
