<%@ Page Title="Welcome to Trimetric Life Partner" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Trimetric.LifePartner.Web.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <section class="loginsection">
    <%--<form runat="server" class="loginform">--%>
      
        <asp:Label ID="Label1" runat="server" Text="Mobile"></asp:Label>
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        <br />
     
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
         <asp:CheckBox ID="chkboxPersist" runat="server" /> 
        <asp:Button ID="btnLogin" runat="server" Text="LogIn" OnClick="btnLogin_Click" type="button" />
        <p>
            <asp:Label ID="Msg" runat="server" Text="" ForeColor="Yellow"  ></asp:Label>
        </p>
<%--    </form>--%>


</section>
</asp:Content>
