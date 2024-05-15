<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Health.aspx.cs" Inherits="Trimetric.LifePartner.Web.Health" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section runat="server" class="HealthSection">
        <h1>Health Information</h1>
        <div runat="server" class="row">
            <div runat="server" class="column">
                <div runat="server">
                    <div runat="server">
                        <label runat="server" for="height">Height</label>
                        <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Height"
                             ControlToValidate="txtHeight" ForeColor="Yellow"></asp:RequiredFieldValidator>       
                    </div>
                </div>
                <br />
                <div runat="server">
                    <label for="color" runat="server">Color</label>
                    <asp:DropDownList ID="ddlColor" runat="server">
                        <asp:ListItem>White</asp:ListItem>
                        <asp:ListItem>Natural</asp:ListItem>
                        <asp:ListItem>Brown</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                    </asp:DropDownList>
                    
                </div>
                <br />
                <div>
                    <label for="glasses">Glasses</label>
                    <asp:DropDownList ID="ddlGlasses" runat="server">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                 
                </div>
                <br />

            </div>


            <div class="column">
                <div>
                    <label for="txtWeigth">Weight</label>
                    <asp:TextBox ID="txtWeigth" runat="server"></asp:TextBox>
                    
                </div>
                <br />
                <div>
                    <label for="bloodtype">BloodType</label>
                    <asp:DropDownList ID="ddlBloodtype" runat="server">
                        <asp:ListItem>A+</asp:ListItem>
                        <asp:ListItem>B+</asp:ListItem>
                        <asp:ListItem>O+</asp:ListItem>
                        <asp:ListItem>AB+</asp:ListItem>
                        <asp:ListItem>A-</asp:ListItem>
                        <asp:ListItem>B-</asp:ListItem>
                        <asp:ListItem>O-</asp:ListItem>
                        <asp:ListItem>AB-</asp:ListItem>
                    </asp:DropDownList>
                  
                </div>
                <br />

                <div>
                    <label for="diet">Diet</label>
                    <asp:DropDownList ID="ddlDiet" runat="server">
                        <asp:ListItem>Veg</asp:ListItem>
                        <asp:ListItem>NonVeg</asp:ListItem>
                    </asp:DropDownList>
                   
                </div>
                <br />

                <div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_CLick" Action="Insert" HealthId="-1" />
                </div>

            </div>

        </div>

    </section>
</asp:Content>
