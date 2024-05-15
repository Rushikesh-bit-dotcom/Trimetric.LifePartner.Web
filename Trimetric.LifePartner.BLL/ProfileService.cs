using System;
using System.Data;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{

    // this type or class allows us to execute sql operations, developers can modify based on application requirement
    public class ProfileService
    {
        public ProfileInfo GetProfile(string ID)
        {
            ProfileDAL profileDAL = new ProfileDAL();
            return profileDAL.GetProfile(ID);              
        }
       
        public void InsertProfile(ProfileInfo profileInfo)
        {
            ProfileDAL profileDAL = new ProfileDAL();
            profileDAL.InsertProfile(profileInfo);
            
        }
        public void UpdateProfile(ProfileInfo profileInfo)
        {
            ProfileDAL profileDAL = new ProfileDAL();
            profileDAL.UpdateProfile(profileInfo);
        }
        public DataTable SetProfile()
        {
            ProfileDAL profileDAL = new ProfileDAL();
            return profileDAL.SetProfile();
        }

        public void GetProfile(Action readData)
        {
            throw new NotImplementedException();
        }
    }
}