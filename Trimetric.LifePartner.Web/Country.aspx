<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="Trimetric.LifePartner.Web.Country" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section runat="server" class="HealthSection">
        <div  runat="server">
            <asp:Label runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="ddlCountry" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"  >
            </asp:DropDownList>
        </div>
        <div runat="server">
            <asp:Label runat="server" Text="CountryCode"></asp:Label>
<%--            <asp:DropDownList ID="ddlCountryCode" AutoPostBack="true" runat="server" ">
            </asp:DropDownList>--%>
        </div>
    </section>

    <div>
        <asp:Label ID="lblName" runat="server" Text="First Name"></asp:Label><br />
        <asp:Label ID="lblAddress" runat="server" Text="Middle Name"></asp:Label><br />
        <asp:Label ID="lblMobile" runat="server" Text="Last Name"></asp:Label>
    </div>
</asp:Content>
