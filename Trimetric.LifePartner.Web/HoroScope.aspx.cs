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
    public partial class HoroScope : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                HoroScopeService horoScopeService = new HoroScopeService();
                HoroScopeInfo horoScopeInfo = horoScopeService.GetHoroScope(Session["UserID"].ToString());

                if(horoScopeInfo.HoroScopeID > -1)
                {
                    btnSave.Attributes["Action"] = "update";
                    BindHoroScopePage(horoScopeInfo);                  
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
                UpdateHoroScope(ReadHoroScope());
            else
                InsertHoroScope(ReadHoroScope());
            Response.Redirect("~/Health.aspx");
        }

     

        public HoroScopeInfo ReadHoroScope()
        {
            HoroScopeInfo horoScopeInfo = new HoroScopeInfo();
            horoScopeInfo.HoroScopeID = Convert.ToInt32(btnSave.Attributes["HoroScopeId"]);
            horoScopeInfo.UserID = Convert.ToInt32(Session["UserID"]);
            horoScopeInfo.NavrasName = txtNavrasName.Text;
            horoScopeInfo.Kuldevat = txtKuldevat.Text;
            horoScopeInfo.Zodic = ddlZodic.Text;
            horoScopeInfo.Nadi= ddlNadi.Text;
            horoScopeInfo.Charan = ddlCharan.Text;
            horoScopeInfo.Constellation= ddlConstellation.Text;
            horoScopeInfo.Gotra = ddlGotra.Text;
            horoScopeInfo.Gan= ddlGan.Text;
            horoScopeInfo.Mangal = ddlMangal.Text;
            horoScopeInfo.Yoni = ddlYoni.Text;
            horoScopeInfo.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
            horoScopeInfo.BirthTime = Convert.ToDateTime(txtBirthTime.Text);
            horoScopeInfo.Date = DateTime.Now;
            horoScopeInfo.ModifiedDate = DateTime.Now;
            return horoScopeInfo;
        }
        public void BindHoroScopePage(HoroScopeInfo horoScopeInfo)
        {
            btnSave.Attributes["HoroScopeId"] = horoScopeInfo.HoroScopeID.ToString();
            txtNavrasName.Text = horoScopeInfo.NavrasName;
            txtKuldevat.Text = horoScopeInfo.Kuldevat;
            ddlZodic.SelectedValue = horoScopeInfo.Zodic;
            ddlNadi.SelectedValue = horoScopeInfo.Nadi;
            ddlCharan.SelectedValue = horoScopeInfo.Charan;
            ddlConstellation.SelectedValue = horoScopeInfo.Constellation;
            ddlGotra.SelectedValue = horoScopeInfo.Gotra;
            ddlGan.SelectedValue = horoScopeInfo.Gan;
            ddlMangal.SelectedValue = horoScopeInfo.Mangal;
            ddlYoni.SelectedValue = horoScopeInfo.Yoni;
            txtBirthDate.Text = horoScopeInfo.BirthDate.ToString("yyyy-MM-dd");
            txtBirthTime.Text = horoScopeInfo.BirthTime.ToString("HH:mm");
       
        }
        public void InsertHoroScope(HoroScopeInfo horoScopeInfo)
        {
            HoroScopeService horoScopeService = new HoroScopeService();
            horoScopeService.InsertHoroScope(horoScopeInfo);
        }
        public void UpdateHoroScope(HoroScopeInfo horoScopeInfo)
        {
            HoroScopeService horoScopeService = new HoroScopeService();
            horoScopeService.UpdateHoroScope(horoScopeInfo);
        }
     
    }
}