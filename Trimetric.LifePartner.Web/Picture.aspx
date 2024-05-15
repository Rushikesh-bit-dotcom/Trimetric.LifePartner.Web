<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Picture.aspx.cs" Inherits="Trimetric.LifePartner.Web.Picture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <section runat="server" class="PictureSection">
        <div class="demo-wrap upload-demo">
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <div id="cropped-result">
                            <%--Result:<br>--%>
                            <img id="cropimage" runat="server" />
                        </div>
                    </div>
                    <div class="col-12">
                        <div class="upload-demo-wrap">
                            <div id="upload-demo"></div>
                        </div>
                    </div>
                    <br />
                    <div class="col-12">
                        <div runat="server">
                            <label for="upload" runat="server">
                                <span class="icon solid fa-upload" style="font-size: 2em; color: #003333;"></span>
                            </label>
                        </div>
                        <div class="upload">
                            <%-- <a class="btn file-btn">
                                </a>--%>
                            <input id="upload" type="file" accept="image/*" />
                            
                        </div>
                    </div>
                    <div class="col-12">
                        <div>
<%--                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="uploadbtn" OnClick="btnSave_Click1" Action="insert" PictureId="-1" />--%>
                            <%--  <button class="upload-result">Save</button>--%>
                            <button id="btnSave" class="uploadbtn">Save</button>
                            <input type="hidden" id="userprofile" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

