using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class Country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CountryService countryService = new CountryService();
                ddlCountry.DataSource = countryService.GetCountry();               
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryCode";
                
                ddlCountry.DataBind();
                
            }   

        }
          
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(ddlCountry.SelectedValue);
        }
    }
} 