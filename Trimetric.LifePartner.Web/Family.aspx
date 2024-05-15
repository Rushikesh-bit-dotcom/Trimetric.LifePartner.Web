<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Family.aspx.cs" Inherits="Trimetric.LifePartner.Web.Family" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="FamilySection">
        <h1>Family Information</h1>
        <div class="row ">
            <div class="col-3 col-12-small">
                <label>Father Name</label>
            </div>
            <div class="col-6 col-12-small">
                <asp:TextBox ID="txtFatherName" runat="server" placeholder="Full Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter FatherName"
                     ControlToValidate="txtFatherName" ForeColor="Yellow"></asp:RequiredFieldValidator>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlFatherwork" runat="server">
                    <asp:ListItem>Job</asp:ListItem>
                    <asp:ListItem>Bussiness</asp:ListItem>
                    <asp:ListItem>Engineer</asp:ListItem>
                    <asp:ListItem>Farmer</asp:ListItem>
                    <asp:ListItem>Teacher</asp:ListItem>
                    <asp:ListItem>Doctor</asp:ListItem>
                </asp:DropDownList>
               
            </div>

        </div>
        <br />
        <div class="row ">
            <div class="col-3 col-12-small">
                <label>Mother Name</label>
            </div>
            <div class="col-6 col-12-small">
                <asp:TextBox ID="txtMotherName" runat="server" placeholder="Full Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter MotherWork"
                     ControlToValidate="txtMotherName" ForeColor="Yellow"></asp:RequiredFieldValidator>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlMotherwork" runat="server">
                    <asp:ListItem>HouseWife</asp:ListItem>
                    <asp:ListItem>Job</asp:ListItem>
                    <asp:ListItem>Bussiness</asp:ListItem>
                    <asp:ListItem>Engineer</asp:ListItem>
                    <asp:ListItem>Farmer</asp:ListItem>
                    <asp:ListItem>Teacher</asp:ListItem>
                    <asp:ListItem>Doctor</asp:ListItem>                 
                </asp:DropDownList>
               
            </div>

        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Brother</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtBrother" runat="server" TextMode="Number" style="background-color: #2e3141"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter How Many Brother's Do You Have"
                     ControlToValidate="txtBrother" ForeColor="Yellow"></asp:RequiredFieldValidator>
            </div>
            <div class="col-3 col-12-small">
                <label>Sister</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtSister" runat="server" TextMode="Number" style="background-color: #2e3141"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter How Many Sister's Do You Have"
                     ControlToValidate="txtSister"></asp:RequiredFieldValidator>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Uncle Name</label>
            </div>
            <div class="col-5 col-12-small">
                <asp:TextBox ID="txtUncleName" runat="server" placeholder="Full Name"></asp:TextBox>

            </div>
            <div class="col-4 col-12-small">
                <asp:TextBox ID="txtUncleCity" runat="server" placeholder="Uncle City"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Other Relatives</label>
            </div>
            <div class="col-9 col-12-small">
                <asp:TextBox ID="txtOtherRelatives" runat="server" placeholder="Surnames"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Property</label>
            </div>
            <div class="col-9 col-12-small">
                <asp:TextBox ID="txtProperty" runat="server" placeholder="House Farm Plot etc"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Your ProperTy"
                     ControlToValidate="txtProperty" ForeColor="Yellow"></asp:RequiredFieldValidator>
            </div>
        </div>
        <br />

        <div>
            <asp:Button ID="btnSave" runat="server" Text="Next" OnClick="btnSave_Click" Action="Insert"  FamilyId="-1" />

        </div>

    </section>
</asp:Content>
