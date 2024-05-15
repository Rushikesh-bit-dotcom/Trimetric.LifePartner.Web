using System;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class LogIn : System.Web.UI.Page
    {
                                             
        protected void Page_Load(object sender, EventArgs e)    
        {
            var se = Session["UserID"];
            //if (Session["LogIn"] != null)
            //{
            //    Session.Abandon();
            //    Session.Clear();
            //}
        }

        public UserInfo GetProfileIdByUser(UserInfo signUpInfo)
        {
       
            LogInService logInService = new LogInService();
            return logInService.GetProfileIdByUser(signUpInfo); 
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Mobile = Convert.ToInt64(txtMobile.Text);
            userInfo.Password = txtPassword.Text;

            userInfo.UserID = GetProfileIdByUser(userInfo).UserID;
            if (userInfo.UserID != -1)
            {
                Session["UserID"] = userInfo.UserID;
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Msg.Text = "Invalid Mobile OR Password";
            }
        } 
    }
         
}