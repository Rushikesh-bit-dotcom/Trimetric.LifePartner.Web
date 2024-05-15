using System;
using System.Web.UI;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;
namespace Trimetric.LifePartner.Web
{
    public partial class Health : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                HealthService healthService = new HealthService();
                HealthInfo healthInfo = healthService.GetHealth(Session["UserID"].ToString());

                if(healthInfo.HealthID > -1)
                {
                    btnSave.Attributes["Action"] = "update";  
                    BindHealthPage(healthInfo);
                }
                else
                {
                    btnSave.Attributes["Action"] = "insert";
                }
            }

        }
        protected void btnSave_CLick(object sender, EventArgs e)
        {
            if (btnSave.Attributes["Action"] == "update")
                UpdateHealth(ReadHealth());
            else
                InsertHealth(ReadHealth());

            Response.Redirect("~/Family.aspx");
        }
        public HealthInfo ReadHealth()
        {
            HealthInfo healthInfo = new HealthInfo();
            healthInfo.HealthID = Convert.ToInt32(btnSave.Attributes["HealthId"]);
            healthInfo.UserID = Convert.ToInt32(Session["UserID"]);
            healthInfo.Weight = txtWeigth.Text;
            healthInfo.Height = txtHeight.Text;
            healthInfo.Color = ddlColor.Text;
            healthInfo.BloodType = ddlBloodtype.Text;
            healthInfo.Diet = ddlDiet.Text;
            healthInfo.Glasses= ddlGlasses.Text;
            healthInfo.Date = DateTime.Now;
            healthInfo.ModifiedDate = DateTime.Now;
            return healthInfo;
        }
        public void BindHealthPage(HealthInfo healthInfo)
        {
            btnSave.Attributes["HealthId"] = healthInfo.HealthID.ToString();
            txtHeight.Text = healthInfo.Height;
            txtWeigth.Text = healthInfo.Weight;
            ddlColor.SelectedValue = healthInfo.Color;
            ddlDiet.SelectedValue = healthInfo.Diet;
            ddlGlasses.SelectedValue = healthInfo.Glasses;
        }
        public void InsertHealth(HealthInfo healthInfo)
        {
            HealthService healthService = new HealthService();
            healthService.InsertHealth(healthInfo);
        }
        public void UpdateHealth(HealthInfo healthInfo)
        {
            HealthService healthService=new HealthService();
            healthService.UpdateHealth(healthInfo);
        }

     
    }
}