<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Trimetric.LifePartner.Web.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="loginsection">

        <%--   <label for="password">Password</label>
                <input / type="password" id="password" name="password" placeholder="Create Password">--%>
        <asp:Label ID="Label1" runat="server" Text="Label">Mobile</asp:Label>
        <asp:TextBox ID="txtMobile" runat="server" TextMode="Phone"></asp:TextBox>
        <br />
        <%--   <label for="password">Password</label>
                <input / type="password" id="password" name="password" placeholder="Create Password">--%>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Create Password"></asp:TextBox>
        <br />
        <%--                <button type="button" id="submitbutton">Submit</button>--%>
        <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Yellow"></asp:Label>
        </p>

    </section>
</asp:Content>
