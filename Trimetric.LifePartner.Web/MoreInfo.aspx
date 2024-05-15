<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="MoreInfo.aspx.cs" Inherits="Trimetric.LifePartner.Web.MoreInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%--<asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <asp:Label ID="Name" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="lblFullName" runat="server"></asp:Label>
            <asp:Label ID="Education" runat="server" Text="Education: "></asp:Label>
            <asp:Label ID="lblEducation" runat="server"></asp:Label>
        </ItemTemplate>
    </asp:ListView>--%>


    <section class="photosection">
        <div class="form-group">
            <div id="image_user_profile" class="custom-input-file text-center">
                <input id="fileInput" name="fileInput" type="file" size="1" class="input-file" />
                <img id="img_user" alt="Upload user image" src="" width="50%" height="50%" style="background-color: #eee; min-height: 100px" />
            </div>
        </div>
        
        <div class="row">
            <div class="col-xs-12">
                <div id="img-user-prueba2">
                </div>
            </div>
        </div>
    </section>
</asp:Content>




