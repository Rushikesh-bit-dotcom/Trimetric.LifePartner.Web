using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;
namespace Trimetric.LifePartner.Web
{
    public partial class Family : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FamilyService familyService = new FamilyService();
                FamilyInfo familyInfo = familyService.GetFamily(Session["UserID"].ToString());

                if(familyInfo.FamilyID > -1)
                {
                    btnSave.Attributes["Action"] = "update";
                   BindFamilyPage(familyInfo);                
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
                UpdateFamily(ReadFamilyPage());
            else
                InsertFamily(ReadFamilyPage());
            Response.Redirect("~/Picture.aspx");

        }
        public FamilyInfo ReadFamilyPage()
        {
            FamilyInfo familyinfo = new FamilyInfo();
            familyinfo.FamilyID = Convert.ToInt32(btnSave.Attributes["FamilyId"]);
            familyinfo.UserID = Convert.ToInt32(Session["UserID"]);
            familyinfo.FatherName = txtFatherName.Text;
            familyinfo.FatherWork = ddlFatherwork.Text;
            familyinfo.MotherName= txtMotherName.Text;
            familyinfo.MotherWork = ddlMotherwork.Text;
            familyinfo.Brother = Convert.ToInt32(txtBrother.Text);
            familyinfo.Sister =Convert.ToInt32(txtSister.Text);
            familyinfo.UncleName= txtUncleName.Text;
            familyinfo.UncleCity = txtUncleCity.Text;
            familyinfo.OtherRelatives = txtOtherRelatives.Text;
            familyinfo.Property = txtProperty.Text;
            familyinfo.Date = DateTime.Now;
            familyinfo.ModifiedDate = DateTime.Now;

            return familyinfo;
        }
        public void BindFamilyPage(FamilyInfo familyInfo)
        {
            btnSave.Attributes["FamilyId"]= familyInfo.FamilyID.ToString();
            txtFatherName.Text = familyInfo.FatherName;
            ddlFatherwork.SelectedValue = familyInfo.FatherWork;
            txtMotherName.Text = familyInfo.MotherName;
            ddlMotherwork.SelectedValue = familyInfo.MotherWork;
            txtBrother.Text = Convert.ToInt32(familyInfo.Brother).ToString();
            txtSister.Text = Convert.ToInt32(familyInfo.Sister).ToString();
            txtUncleName.Text = familyInfo.UncleName;
            txtUncleCity.Text = familyInfo.UncleCity;
            txtOtherRelatives.Text = familyInfo.OtherRelatives;
            txtProperty.Text = familyInfo.Property;
        }
        public void InsertFamily(FamilyInfo familyInfo)
        {
            FamilyService familyService = new FamilyService();
            familyService.InsertFamily(familyInfo);
        }
        public void UpdateFamily(FamilyInfo familyInfo)
        {
            FamilyService familyService = new FamilyService();
            familyService.UpdateFamily(familyInfo);
        }
      

    }
}