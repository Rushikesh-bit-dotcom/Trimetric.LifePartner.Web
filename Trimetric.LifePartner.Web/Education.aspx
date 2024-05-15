<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="Trimetric.LifePartner.Web.Education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <section runat="server" class="EducationSection">
        <h1>Education Information</h1>
        <div runat="server" class="row">
            <div runat="server" class="educationcolumn">
                <div  runat="server" class="healthtags" >
                    <label for="education">Education</label>
                    <asp:TextBox ID="txtEducation" runat="server" placeholder="SSC HSS BSC BA MCA BCA MBBS etc" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Your Education"
                         ControlToValidate="txtEducation" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div><br />
                <div class="healthtags" >
                    <label for="ddlWorktype">WorkType</label>
                    <asp:DropDownList ID="ddlWorktype" runat="server">
                        <asp:ListItem>Job</asp:ListItem>
                        <asp:ListItem>Bussiness</asp:ListItem>
                    </asp:DropDownList>
                    
                </div><br />

                <div class="healthtags">
                    <label>WorkingAt</label>
                    <asp:TextBox ID="txtWorkingAt" runat="server" placeholder="Company Name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Where You Work"
                         ControlToValidate="txtWorkingAt" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div><br />
                <div class="healthtags" >
                    <label for="txtWorkAddress">Work Address</label>
                    <asp:TextBox ID="txtWorkAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter WorkAddress"
                         ControlToValidate="txtWorkAddress" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div><br />
                <div class="healthtags" ">
                    <label>Salary</label>
                    <asp:TextBox ID="txtMonthlySalary" runat="server" placeholder="MonthlySalary"></asp:TextBox>        
                    &nbsp &nbsp
                    <asp:TextBox ID="txtAnnualSalary" runat="server" placeholder="AnnualSalary"></asp:TextBox>                   
                </div><br />
           </div>
        </div>
         <div>
              <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Action="Insert" EducationId="-1" />
     
        </div>
    </section>
</asp:Content>
