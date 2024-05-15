using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class EducationService
    {

        public EducationInfo GetEducation(string userID)
        {
            EducationDAL educationDAL = new EducationDAL();
            return educationDAL.GetEducation(userID);
        }
        public void InsertEducation(EducationInfo educationInfo)
        {
            EducationDAL educationDAL = new EducationDAL();
            educationDAL.InsertEducation(educationInfo);
        }
        public void UpdateEducation(EducationInfo educationInfo)
        {
            EducationDAL educationDAL = new EducationDAL();
            educationDAL.UpdateEducation(educationInfo);
        }
    }
}
