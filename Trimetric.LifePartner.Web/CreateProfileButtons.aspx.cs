using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BLL;
using Trimetric.LifePartner.BDO;
using System.Drawing;


namespace Trimetric.LifePartner.Web
{
    public partial class CreateProfileButtons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckProfileData();
            CheckEducationData();
            CheckFamilyData();
            CheckHealthData();
            CheckHoroScopeData();
        }

        public void CheckProfileData()
        {
            BDO.ProfileInfo profileInfo = new BDO.ProfileInfo();
            ProfileService profileService = new ProfileService();
            profileInfo = profileService.GetProfile(Session["UserID"].ToString());         
            if (string.IsNullOrEmpty(profileInfo.Name) || string.IsNullOrEmpty(profileInfo.Sex) || string.IsNullOrEmpty(profileInfo.Address)
               || string.IsNullOrEmpty(profileInfo.District) || string.IsNullOrEmpty(profileInfo.State) || string.IsNullOrEmpty(profileInfo.Religion)
               || string.IsNullOrEmpty(profileInfo.Caste) || string.IsNullOrEmpty(profileInfo.Phone) || string.IsNullOrEmpty(profileInfo.Postalcode) == null)
            {
                btnProfile.BackColor = Color.OrangeRed;
            }
            else
            {
                btnProfile.BackColor = Color.DarkSeaGreen;
            }
        }
        public void CheckEducationData()
        {
            BDO.EducationInfo educationInfo = new BDO.EducationInfo();
            EducationService educationService = new EducationService();
            educationInfo = educationService.GetEducation(Session["UserID"].ToString());
            if (string.IsNullOrEmpty(educationInfo.Education) || string.IsNullOrEmpty(educationInfo.WorkType) || string.IsNullOrEmpty(educationInfo.WorkingAt)
                || string.IsNullOrEmpty(educationInfo.WorkAddress) || string.IsNullOrEmpty(Convert.ToInt32(educationInfo.MonthlySalary).ToString()) 
                || string.IsNullOrEmpty(Convert.ToInt32(educationInfo.AnnualSalary).ToString()) == null)
            {
                btnEducation.BackColor = Color.OrangeRed;
            }
            else
            {
                btnEducation.BackColor = Color.DarkSeaGreen;

            }
        }
        public void CheckFamilyData()
        {
            BDO.FamilyInfo familyInfo = new BDO.FamilyInfo();
            FamilyService familyService = new FamilyService();
            familyInfo = familyService.GetFamily(Session["UserID"].ToString());
            if (string.IsNullOrEmpty(familyInfo.FatherName) || string.IsNullOrEmpty(familyInfo.FatherWork) || string.IsNullOrEmpty(familyInfo.MotherName)
                || string.IsNullOrEmpty(familyInfo.MotherWork) || string.IsNullOrEmpty(Convert.ToInt32(familyInfo.Brother).ToString()) || string.IsNullOrEmpty(Convert.ToInt32(familyInfo.Sister).ToString())
                || string.IsNullOrEmpty(familyInfo.UncleName) || string.IsNullOrEmpty(familyInfo.UncleCity) || string.IsNullOrEmpty(familyInfo.OtherRelatives)
                || string.IsNullOrEmpty(familyInfo.Property) == null)
            {
                btnFamily.BackColor = Color.OrangeRed;
            }
            else
            {
                btnFamily.BackColor = Color.DarkSeaGreen;

            }
          
        }
        public void CheckHealthData()
        {
            BDO.HealthInfo healthInfo = new BDO.HealthInfo();
            HealthService healthService = new HealthService();
            healthInfo = healthService.GetHealth(Session["UserID"].ToString());
            if(string.IsNullOrEmpty(healthInfo.Height) || string.IsNullOrEmpty(healthInfo.Weight) || string.IsNullOrEmpty(healthInfo.Color)
                || string.IsNullOrEmpty(healthInfo.BloodType) || string.IsNullOrEmpty(healthInfo.Diet) || string.IsNullOrEmpty(healthInfo.Glasses)
                == null)
            {
                btnHealth.BackColor = Color.OrangeRed;
            }
            else
            {
                btnHealth.BackColor = Color.DarkSeaGreen;

            }
         
        }
        public void CheckHoroScopeData()
        {
            BDO.HoroScopeInfo horoScopeInfo = new BDO.HoroScopeInfo();
            HoroScopeService horoScopeService = new HoroScopeService();
            horoScopeInfo = horoScopeService.GetHoroScope(Session["UserID"].ToString());
            if(string.IsNullOrEmpty(horoScopeInfo.NavrasName) || string.IsNullOrEmpty(horoScopeInfo.Kuldevat) || string.IsNullOrEmpty(horoScopeInfo.Zodic)
                || string.IsNullOrEmpty(horoScopeInfo.Nadi) || string.IsNullOrEmpty(horoScopeInfo.Charan) || string.IsNullOrEmpty(horoScopeInfo.Constellation)
                || string.IsNullOrEmpty(horoScopeInfo.Gotra) || string.IsNullOrEmpty(horoScopeInfo.Gan) || string.IsNullOrEmpty(horoScopeInfo.Mangal)
                || string.IsNullOrEmpty(horoScopeInfo.Yoni) == null)
            {
                btnHoroScope.BackColor = Color.OrangeRed;

            }
            else
            {
                btnHoroScope.BackColor = Color.DarkSeaGreen;

            }
           
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profile.aspx");

        }
        protected void btnEducation_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Education.aspx");

        }
        protected void btnHoroScope_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HoroScope.aspx");
        }
        protected void btnHealth_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Health.aspx");

        }
        protected void btnFamily_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Family.aspx");
        }
        protected void btnPicture_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Picture.aspx");

        }

    }
   
}