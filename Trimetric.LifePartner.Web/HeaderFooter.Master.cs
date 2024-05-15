using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trimetric.LifePartner.Web
{
    public partial class HeaderFooter : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                createprofile.Visible = true;
                mychoice.Visible = true;
                foryou.Visible = true;
                logout.Visible = true;
                //Button1.Visible=true;
                login.Visible = false;
                signup.Visible = false;


            }
            else
            {
                createprofile.Visible = false;
                mychoice.Visible = false;
                foryou.Visible = false;
                logout.Visible = false;
                //Button1.Visible=false;
                login.Visible = true;
                signup.Visible = true;
            }

        }

        protected void Logout(object sender, EventArgs e )
        {
            Session["UserID"] = null;
            Response.Redirect("Index.aspx");
            Response.Cache.SetNoStore();
            Response.CacheControl = "no-cache";
        } 
    }
}