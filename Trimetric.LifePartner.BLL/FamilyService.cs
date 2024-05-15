using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class FamilyService
    {

        public FamilyInfo GetFamily(string ID)
        {
            FamilyDAL familyDAL = new FamilyDAL();
            return familyDAL.GetFamily(ID);

        }
        public void InsertFamily(FamilyInfo familyInfo)
        {
            FamilyDAL familyDAL = new FamilyDAL();
            familyDAL.InsertFamily(familyInfo);
        }
        public void UpdateFamily(FamilyInfo familyInfo)
        {
            FamilyDAL familyDAL = new FamilyDAL();
            familyDAL.UpdateFamily(familyInfo);
        }
    }
}
