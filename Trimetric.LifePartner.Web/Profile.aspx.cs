using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class Profile : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)  
            {
                ProfileService profileService = new ProfileService();
                ProfileInfo profileInfo = profileService.GetProfile(Session["UserID"].ToString());

                if (profileInfo.ProfileID > -1)
                {
                    btnSave.Attributes["Action"] = "update";
                    BindProfilePage(profileInfo);
                }
                else
                {
                    btnSave.Attributes["Action"] = "insert";
                }
                
            }
          
        }
     
        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            if (btnSave.Attributes["Action"] == "update")
                UpdateProfile(ReadProfilePage());
            else
                InsertProfile(ReadProfilePage());

            Response.Redirect("~/Education.aspx");
        }
        public ProfileInfo ReadProfilePage()
        {
            ProfileInfo profileInfo = new ProfileInfo();
            profileInfo.ProfileID = Convert.ToInt32(btnSave.Attributes["ProfileId"]);
            profileInfo.UserID = Convert.ToInt32(Session["UserID"]);
            profileInfo.Name = txtName.Text;
            profileInfo.Sex = ddlSex.Text;
            profileInfo.Age = Convert.ToInt32(ddlAge.SelectedValue);
            profileInfo.Address = txtAddress.Text;
            profileInfo.District = ddlDistrict.Text;
            profileInfo.Religion = ddlReligion.Text;
            profileInfo.Caste = ddlCaste.Text;
            profileInfo.Phone = txtPhone.Text;
            profileInfo.State = ddlState.Text;
            profileInfo.Postalcode = txtPostalCode.Text;
            profileInfo.Date = DateTime.Now;
            profileInfo.ModifiedDate = DateTime.Now;

            
            return profileInfo;
        }
        public void BindProfilePage(ProfileInfo profileInfo)
        {
            txtName.Text = profileInfo.Name;
            ddlSex.SelectedValue = profileInfo.Sex;
            ddlAge.SelectedValue = profileInfo.Age.ToString();
            ddlReligion.SelectedValue = profileInfo.Religion;
            ddlCaste.SelectedValue = profileInfo.Caste;
            txtAddress.Text = profileInfo.Address;
            ddlState.SelectedValue = profileInfo.State;
            ddlDistrict.SelectedValue = profileInfo.District;
            txtPostalCode.Text = profileInfo.Postalcode;
            txtPhone.Text = profileInfo.Phone;
            btnSave.Attributes["ProfileId"] = profileInfo.ProfileID.ToString();

        }
        public void InsertProfile(ProfileInfo profileInfo)
        {
            ProfileService profileService = new ProfileService();
            profileService.InsertProfile(profileInfo);
        }
        public void UpdateProfile(ProfileInfo profileInfo)
        {
            ProfileService profileService = new ProfileService();
            profileService.UpdateProfile(profileInfo);
        }

    }
}