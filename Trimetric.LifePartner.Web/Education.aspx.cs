using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class Education : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EducationService educationService = new EducationService();
                EducationInfo educationInfo = educationService.GetEducation(Session["UserID"].ToString());

                if (educationInfo.EducationID > -1)
                {
                    // all input controls .txt = info.property
                    btnSave.Attributes["Action"] = "update";
                    BindEducationPage(educationInfo);
                 
                }
                else
                {
                    btnSave.Attributes["Action"] = "Insert";
                }
            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Attributes["Action"] == "update")
                UpdateEducation(ReadEducation());
            else
                InsertEducation(ReadEducation());

            Response.Redirect("~/HoroScope.aspx");
        }

        public EducationInfo ReadEducation()
        {
            EducationInfo educationInfo = new EducationInfo();
            educationInfo.EducationID = Convert.ToInt32(btnSave.Attributes["EducationId"]);
            educationInfo.UserID = Convert.ToInt32(Session["UserID"]);
            educationInfo.Education = txtEducation.Text;
            educationInfo.WorkType = ddlWorktype.Text;
            educationInfo.WorkingAt= txtWorkingAt.Text;
            educationInfo.WorkAddress = txtWorkAddress.Text;
            educationInfo.MonthlySalary = Convert.ToInt32(txtMonthlySalary.Text);
            educationInfo.AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text);
            educationInfo.Date = DateTime.Now;
            educationInfo.ModifiedDate = DateTime.Now;
            return educationInfo;
        }
        public void BindEducationPage(EducationInfo educationInfo)
        {
            btnSave.Attributes["EducationId"] = educationInfo.EducationID.ToString();
            txtEducation.Text = educationInfo.Education;
            ddlWorktype.SelectedValue = educationInfo.WorkType;
            txtWorkingAt.Text = educationInfo.WorkingAt;
            txtWorkAddress.Text = educationInfo.WorkAddress;
            txtMonthlySalary.Text = educationInfo.MonthlySalary.ToString();
            txtAnnualSalary.Text = educationInfo.AnnualSalary.ToString();

        }

        public void InsertEducation(EducationInfo educationInfo)
        {
            EducationService educationService = new EducationService();
            educationService.InsertEducation(educationInfo);
        }

       public void UpdateEducation(EducationInfo educationInfo)
        {
            EducationService educationService = new EducationService();
            educationService.UpdateEducation(educationInfo);
        }
    }
}