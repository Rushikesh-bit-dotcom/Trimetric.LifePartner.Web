using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class CreateProfileButtonsService
    {
        //public void GetValue(CreateProfileButtonsInfo createProfileButtonsInfo)
        //{
        //    CreateProfileButtonsDAL createProfileButtonsDAL = new CreateProfileButtonsDAL();    
        //    createProfileButtonsDAL.GetValue(createProfileButtonsInfo);

        //}
        public CreateProfileButtonsInfo GetValue(string ID)
        {
            CreateProfileButtonsDAL createProfileButtonsDAL = new CreateProfileButtonsDAL();
            return createProfileButtonsDAL.GetValue(ID);
        }
    }
}
