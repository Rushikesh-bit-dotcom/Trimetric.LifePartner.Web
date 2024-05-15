<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="CreateProfileButtons.aspx.cs" Inherits="Trimetric.LifePartner.Web.CreateProfileButtons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <section class="ProfileSection">
        <div>
            <h1>Create Profile</h1>
        </div>

      <%--  <form class="form-inline">
            <div>
               <a href="SelfProfile.aspx"> <button type="button" onclick="">SelfProfile</button></a>
               <a href="Education.aspx"><button type="button">Education</button></a> 
              <a href="Horoscope.aspx"><button type="button">HoroScope</button></a>  


            </div>
            <br />
            <div>
                <a href="Health.aspx"><button type="button">Health</button></a>
               <a href="Family.aspx"><button type="button">Family</button></a> 
                <button type="button">Photo</button>
            </div>
        </form>--%>
         <div runat="server" class="row">
             <div class="col-4 col-12-small">
                 <asp:Button CssClass="ProfileButtons" ID="btnProfile" runat="server" Text="Profile" OnClick="btnProfile_Click" />
             </div>
             <div class="col-4 col-12-small ">
                 <asp:Button CssClass="ProfileButtons" ID="btnEducation" runat="server" Text="Education" OnClick="btnEducation_Click" />
             </div>
             <div class="col-4 col-12-small">
                 <asp:Button CssClass="ProfileButtons" ID="btnFamily" runat="server" Text="Family" OnClick="btnFamily_Click" />
             </div>
         </div><br />
         <div class="row">
             <div class="col-4 col-12-small">
                 <asp:Button CssClass="ProfileButtons" ID="btnHealth" runat="server" Text="Health" OnClick="btnHealth_Click"  />
             </div>
             <div class="col-4 col-12-small">
                 <asp:Button CssClass="ProfileButtons" ID="btnHoroScope" runat="server" Text="HoroScope" OnClick="btnHoroScope_Click" />
             </div>
             <div class="col-4 col-12-small">
                 <asp:Button CssClass="ProfileButtons" ID="btnPicture" runat="server" Text="Picture" OnClick="btnPicture_Click" />
             </div>
         </div>
      


    </section>
</asp:Content>
