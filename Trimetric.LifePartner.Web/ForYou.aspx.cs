using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class ForYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 GetProfileData();     
            }
   
        }

        public void GetProfileData()
        {
       
            ForYouService forYouService = new ForYouService();
            Repeater1.DataSource = forYouService.GetProfileData();
            Repeater1.DataBind();
            
        }

        public void ProfileMoreInfo(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("Name") as Label).Visible = true;
            (repeaterItem.FindControl("lblFullName") as Label).Visible = true;
            (repeaterItem.FindControl("Sex") as Label).Visible = true;
            (repeaterItem.FindControl("lblSex") as Label).Visible = true;
            (repeaterItem.FindControl("Age") as Label).Visible = true;
            (repeaterItem.FindControl("lblAge") as Label).Visible = true;
            (repeaterItem.FindControl("Address") as Label).Visible = true;
            (repeaterItem.FindControl("lblAddres") as Label).Visible = true;
            (repeaterItem.FindControl("District") as Label).Visible = true;
            (repeaterItem.FindControl("lblDistrict") as Label).Visible = true;
            //COL-6
            (repeaterItem.FindControl("Religion") as Label).Visible = true;
            (repeaterItem.FindControl("lblReligion") as Label).Visible = true;
            (repeaterItem.FindControl("Caste") as Label).Visible = true;
            (repeaterItem.FindControl("lblCaste") as Label).Visible = true;
            (repeaterItem.FindControl("Mobile") as Label).Visible = true;
            (repeaterItem.FindControl("lblMobile") as Label).Visible = true;
            (repeaterItem.FindControl("State") as Label).Visible = true;
            (repeaterItem.FindControl("lblState") as Label).Visible = true;
            (repeaterItem.FindControl("PostalCode") as Label).Visible = true;
            (repeaterItem.FindControl("lblPostalCode") as Label).Visible = true;


        }
        public void ProfileCollapse(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL - 6
            (repeaterItem.FindControl("Name") as Label).Visible = false;
            (repeaterItem.FindControl("lblFullName") as Label).Visible = false;
            (repeaterItem.FindControl("Sex") as Label).Visible = false;
            (repeaterItem.FindControl("lblSex") as Label).Visible = false;
            (repeaterItem.FindControl("Age") as Label).Visible = false;
            (repeaterItem.FindControl("lblAge") as Label).Visible = false;
            (repeaterItem.FindControl("Address") as Label).Visible = false;
            (repeaterItem.FindControl("lblAddres") as Label).Visible = false;
            (repeaterItem.FindControl("District") as Label).Visible = false;
            (repeaterItem.FindControl("lblDistrict") as Label).Visible = false;
            //COL - 6
            (repeaterItem.FindControl("Religion") as Label).Visible = false;
            (repeaterItem.FindControl("lblReligion") as Label).Visible = false;
            (repeaterItem.FindControl("Caste") as Label).Visible = false;
            (repeaterItem.FindControl("lblCaste") as Label).Visible = false;
            (repeaterItem.FindControl("Mobile") as Label).Visible = false;
            (repeaterItem.FindControl("lblMobile") as Label).Visible = false;
            (repeaterItem.FindControl("State") as Label).Visible = false;
            (repeaterItem.FindControl("lblState") as Label).Visible = false;
            (repeaterItem.FindControl("PostalCode") as Label).Visible = false;
            (repeaterItem.FindControl("lblPostalCode") as Label).Visible = false;
        }

        public void EducationMoreInfo(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("Education") as Label).Visible = true;
            (repeaterItem.FindControl("lblEdu") as Label).Visible = true;
            (repeaterItem.FindControl("WorkType") as Label).Visible = true;
            (repeaterItem.FindControl("lblWorkType") as Label).Visible = true;
            (repeaterItem.FindControl("WorkingAt") as Label).Visible = true;
            (repeaterItem.FindControl("lblWorkingAt") as Label).Visible = true;
            //COL-6
            (repeaterItem.FindControl("WorkAddress") as Label).Visible = true;
            (repeaterItem.FindControl("lblWorkAddress") as Label).Visible = true;
            (repeaterItem.FindControl("MonthSalary") as Label).Visible = true;
            (repeaterItem.FindControl("lblMonthSalary") as Label).Visible = true;
            (repeaterItem.FindControl("AnnualSalary") as Label).Visible = true;
            (repeaterItem.FindControl("lblAnnualSalary") as Label).Visible = true;
        }
        public void EducationCollapse(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("Education") as Label).Visible = false;
            (repeaterItem.FindControl("lblEdu") as Label).Visible = false;
            (repeaterItem.FindControl("WorkType") as Label).Visible = false;
            (repeaterItem.FindControl("lblWorkType") as Label).Visible = false;
            (repeaterItem.FindControl("WorkingAt") as Label).Visible = false;
            (repeaterItem.FindControl("lblWorkingAt") as Label).Visible = false;
            //COL-6
            (repeaterItem.FindControl("WorkAddress") as Label).Visible = false;
            (repeaterItem.FindControl("lblWorkAddress") as Label).Visible = false;
            (repeaterItem.FindControl("MonthSalary") as Label).Visible = false;
            (repeaterItem.FindControl("lblMonthSalary") as Label).Visible = false;
            (repeaterItem.FindControl("AnnualSalary") as Label).Visible = false;
            (repeaterItem.FindControl("lblAnnualSalary") as Label).Visible = false;
        }

        public void FamilyMoreInfo(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            (repeaterItem.FindControl("FatherName") as Label).Visible = true;
            (repeaterItem.FindControl("lblFatherName") as Label).Visible = true;
            (repeaterItem.FindControl("FatherWork") as Label).Visible = true;
            (repeaterItem.FindControl("lblFatherWork") as Label).Visible = true;
            (repeaterItem.FindControl("MotherName") as Label).Visible = true;
            (repeaterItem.FindControl("lblMotherName") as Label).Visible = true;
            (repeaterItem.FindControl("MotherWork") as Label).Visible = true;
            (repeaterItem.FindControl("lblMotherWork") as Label).Visible = true;
            (repeaterItem.FindControl("Brother") as Label).Visible = true;
            (repeaterItem.FindControl("lblBrother") as Label).Visible = true;
            //COL-6
            (repeaterItem.FindControl("Sister") as Label).Visible = true;
            (repeaterItem.FindControl("lblSister") as Label).Visible = true;
            (repeaterItem.FindControl("UncleName") as Label).Visible = true;
            (repeaterItem.FindControl("lblUncleName") as Label).Visible = true;
            (repeaterItem.FindControl("UncleCity") as Label).Visible = true;
            (repeaterItem.FindControl("lblUncleCity") as Label).Visible = true;
            (repeaterItem.FindControl("OtherRelatives") as Label).Visible = true;
            (repeaterItem.FindControl("lblOtherRelatives") as Label).Visible = true;
            (repeaterItem.FindControl("Property") as Label).Visible = true;
            (repeaterItem.FindControl("lblProperty") as Label).Visible = true;
        }
        public void FamilyCollapse(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            (repeaterItem.FindControl("FatherName") as Label).Visible = false;
            (repeaterItem.FindControl("lblFatherName") as Label).Visible = false;
            (repeaterItem.FindControl("FatherWork") as Label).Visible = false;
            (repeaterItem.FindControl("lblFatherWork") as Label).Visible = false;
            (repeaterItem.FindControl("MotherName") as Label).Visible = false;
            (repeaterItem.FindControl("lblMotherName") as Label).Visible = false;
            (repeaterItem.FindControl("MotherWork") as Label).Visible = false;
            (repeaterItem.FindControl("lblMotherWork") as Label).Visible = false;
            (repeaterItem.FindControl("Brother") as Label).Visible = false;
            (repeaterItem.FindControl("lblBrother") as Label).Visible = false;
            //COL-6
            (repeaterItem.FindControl("Sister") as Label).Visible = false;
            (repeaterItem.FindControl("lblSister") as Label).Visible = false;
            (repeaterItem.FindControl("UncleName") as Label).Visible = false;
            (repeaterItem.FindControl("lblUncleName") as Label).Visible = false;
            (repeaterItem.FindControl("UncleCity") as Label).Visible = false;
            (repeaterItem.FindControl("lblUncleCity") as Label).Visible = false;
            (repeaterItem.FindControl("OtherRelatives") as Label).Visible = false;
            (repeaterItem.FindControl("lblOtherRelatives") as Label).Visible = false;
            (repeaterItem.FindControl("Property") as Label).Visible = false;
            (repeaterItem.FindControl("lblProperty") as Label).Visible = false;
        }

        public void HealthMoreInfo(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("Height") as Label).Visible = true;
            (repeaterItem.FindControl("lblHeight") as Label).Visible = true;
            (repeaterItem.FindControl("Weight") as Label).Visible = true;
            (repeaterItem.FindControl("lblWeight") as Label).Visible = true;
            (repeaterItem.FindControl("color") as Label).Visible = true;
            (repeaterItem.FindControl("lblcolor") as Label).Visible = true;
            //COL-6
            (repeaterItem.FindControl("BloodType") as Label).Visible = true;
            (repeaterItem.FindControl("lblBloodType") as Label).Visible = true;
            (repeaterItem.FindControl("Diet") as Label).Visible = true;
            (repeaterItem.FindControl("lblDiet") as Label).Visible = true;
            (repeaterItem.FindControl("Glasses") as Label).Visible = true;
            (repeaterItem.FindControl("lblGlasses") as Label).Visible = true;
        }
        public void HealthCollapse(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("Height") as Label).Visible = false;
            (repeaterItem.FindControl("lblHeight") as Label).Visible = false;
            (repeaterItem.FindControl("Weight") as Label).Visible = false;
            (repeaterItem.FindControl("lblWeight") as Label).Visible = false;
            (repeaterItem.FindControl("color") as Label).Visible = false;
            (repeaterItem.FindControl("lblcolor") as Label).Visible = false;
            //COL-6
            (repeaterItem.FindControl("BloodType") as Label).Visible = false;
            (repeaterItem.FindControl("lblBloodType") as Label).Visible = false;
            (repeaterItem.FindControl("Diet") as Label).Visible = false;
            (repeaterItem.FindControl("lblDiet") as Label).Visible = false;
            (repeaterItem.FindControl("Glasses") as Label).Visible = false;
            (repeaterItem.FindControl("lblGlasses") as Label).Visible = false;
        }

        public void HoroScopeMoreInfo(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("NavrasName") as Label).Visible = true;
            (repeaterItem.FindControl("lblNavrasName") as Label).Visible = true;
            (repeaterItem.FindControl("Kuldevat") as Label).Visible = true;
            (repeaterItem.FindControl("lblKuldevat") as Label).Visible = true;
            (repeaterItem.FindControl("Zodic") as Label).Visible = true;
            (repeaterItem.FindControl("lblZodic") as Label).Visible = true;
            (repeaterItem.FindControl("Nadi") as Label).Visible = true;
            (repeaterItem.FindControl("lblNadi") as Label).Visible = true;
            (repeaterItem.FindControl("Charan") as Label).Visible = true;
            (repeaterItem.FindControl("lblCharan") as Label).Visible = true;
            (repeaterItem.FindControl("Constellation") as Label).Visible = true;
            (repeaterItem.FindControl("lblConstellation") as Label).Visible = true;
            //COL-6
            (repeaterItem.FindControl("Gotra") as Label).Visible = true;
            (repeaterItem.FindControl("lblGotra") as Label).Visible = true;
            (repeaterItem.FindControl("Gan") as Label).Visible = true;
            (repeaterItem.FindControl("lblGan") as Label).Visible = true;
            (repeaterItem.FindControl("Mangal") as Label).Visible = true;
            (repeaterItem.FindControl("lblMangal") as Label).Visible = true;
            (repeaterItem.FindControl("Yoni") as Label).Visible = true;
            (repeaterItem.FindControl("lblYoni") as Label).Visible = true;
            (repeaterItem.FindControl("BirthDate") as Label).Visible = true;
            (repeaterItem.FindControl("lblBirthDate") as Label).Visible = true;
            (repeaterItem.FindControl("BirthTime") as Label).Visible = true;
            (repeaterItem.FindControl("lblBirthTime") as Label).Visible = true;
        }
        public void HoroScopeCollapse(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            //COL-6
            (repeaterItem.FindControl("NavrasName") as Label).Visible = false;
            (repeaterItem.FindControl("lblNavrasName") as Label).Visible = false;
            (repeaterItem.FindControl("Kuldevat") as Label).Visible = false;
            (repeaterItem.FindControl("lblKuldevat") as Label).Visible = false;
            (repeaterItem.FindControl("Zodic") as Label).Visible = false;
            (repeaterItem.FindControl("lblZodic") as Label).Visible = false;
            (repeaterItem.FindControl("Nadi") as Label).Visible = false;
            (repeaterItem.FindControl("lblNadi") as Label).Visible = false;
            (repeaterItem.FindControl("Charan") as Label).Visible = false;
            (repeaterItem.FindControl("lblCharan") as Label).Visible = false;
            (repeaterItem.FindControl("Constellation") as Label).Visible = false;
            (repeaterItem.FindControl("lblConstellation") as Label).Visible = false;
            //COL-6
            (repeaterItem.FindControl("Gotra") as Label).Visible = false;
            (repeaterItem.FindControl("lblGotra") as Label).Visible = false;
            (repeaterItem.FindControl("Gan") as Label).Visible = false;
            (repeaterItem.FindControl("lblGan") as Label).Visible = false;
            (repeaterItem.FindControl("Mangal") as Label).Visible = false;
            (repeaterItem.FindControl("lblMangal") as Label).Visible = false;
            (repeaterItem.FindControl("Yoni") as Label).Visible = false;
            (repeaterItem.FindControl("lblYoni") as Label).Visible = false;
            (repeaterItem.FindControl("BirthDate") as Label).Visible = false;
            (repeaterItem.FindControl("lblBirthDate") as Label).Visible = false;
            (repeaterItem.FindControl("BirthTime") as Label).Visible = false;
            (repeaterItem.FindControl("lblBirthTime") as Label).Visible = false;
        }
        protected void MoreInfo_Click(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;
            // Button
            (repeaterItem.FindControl("btnCollapse") as Button).Visible = true;
            (repeaterItem.FindControl("btnMoreInfo") as Button).Visible = false;

            ProfileMoreInfo(sender, e);
            EducationMoreInfo(sender, e);
            FamilyMoreInfo(sender, e);
            HealthMoreInfo(sender, e);
            HoroScopeMoreInfo(sender, e);
        }
        protected void btnCollapse_Click(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as Button).NamingContainer as RepeaterItem;

            //Button
            (repeaterItem.FindControl("btnMoreInfo") as Button).Visible = true;
            (repeaterItem.FindControl("btnCollapse") as Button).Visible = false;

            ProfileCollapse(sender, e);
            EducationCollapse(sender, e);
            FamilyCollapse(sender, e);
            HealthCollapse(sender, e);
            HoroScopeCollapse(sender, e);
        }


        protected void lbLike_Click(object sender, EventArgs e)
        {
            RepeaterItem repeaterItem = (sender as LinkButton).NamingContainer as RepeaterItem;
            (repeaterItem.FindControl("lbLike") as LinkButton).ForeColor = Color.Red;

           string name = (repeaterItem.FindControl("lblFullName") as Label).Text;
            Session["Name"] = name;
           string education = (repeaterItem.FindControl("lblEducation") as Label).Text;
            Session["Education"] = education;
        }
  
    }
}