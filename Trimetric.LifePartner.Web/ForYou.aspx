<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="ForYou.aspx.cs" Inherits="Trimetric.LifePartner.Web.ForYou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <h1>ForYou</h1>
        </HeaderTemplate>
        <ItemTemplate>

            <section class="features ForYouSection">
                <article class="ForYouArtical">
                    <a href="#" class="image">
                        <img src="Images/RC.jpg.png" alt="" /></a>
                    <div class="row">
                        <div class="col-9">
                            <div>
                                <asp:Label CssClass="Name" ID="lblName" runat="server" Text='<%#Eval("FullName") %>'></asp:Label>
                            </div>
                            <div>
                                <asp:Label ID="Label1" runat="server" Text="Education: "></asp:Label>
                                <asp:Label ID="lblEducation" runat="server" Text='<%#Eval("Education") %>'></asp:Label>

                                <asp:Label ID="Label4" runat="server" Text=",  Address: "></asp:Label>
                                <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>'></asp:Label><br />
                            </div>
                            
                        </div>
                        <div class="col-3">
                            <div id="LikeIcon">
                                <asp:LinkButton ID="lbLike" CssClass="icon fa-2x fa-heart" runat="server" OnClick="lbLike_Click">
                                <%--<i id="LikeICon" class="icon fa-2x fa-heart" runat="server" ></i>--%>
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>

                    <%-- PROFILE DATA--%>
                    <div class=" row ProfileData">
                        <div class="col-12 col-12-small profileColumn">
                            <div>
                                <asp:Label CssClass="label" ID="Name" runat="server" Text="Name: " Visible="false"></asp:Label>
                                <asp:Label ID="lblFullName" runat="server" Text='<%#Eval("FullName") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Sex" runat="server" Text="Sex: " Visible="false"></asp:Label>
                                <asp:Label ID="lblSex" runat="server" Text='<%#Eval("Sex") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Age" runat="server" Text="Age: " Visible="false"></asp:Label>
                                <asp:Label ID="lblAge" runat="server" Text='<%#Eval("Age") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Address" runat="server" Text="Address: " Visible="false"></asp:Label>
                                <asp:Label ID="lblAddres" runat="server" Text='<%#Eval("Address") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="District" runat="server" Text="District: " Visible="false"></asp:Label>
                                <asp:Label ID="lblDistrict" runat="server" Text='<%#Eval("District") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="col-12 col-12-small profileColumn">
                            <div>
                                <asp:Label CssClass="label" ID="Religion" runat="server" Text="Religion: " Visible="false"></asp:Label>
                                <asp:Label ID="lblReligion" runat="server" Text='<%#Eval("Religion") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Caste" runat="server" Text="Caste: " Visible="false"></asp:Label>
                                <asp:Label ID="lblCaste" runat="server" Text='<%#Eval("Caste") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Mobile" runat="server" Text="Mobile: " Visible="false"></asp:Label>
                                <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="State" runat="server" Text="State: " Visible="false"></asp:Label>
                                <asp:Label ID="lblState" runat="server" Text='<%#Eval("State") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="PostalCode" runat="server" Text="PostalCode: " Visible="false"></asp:Label>
                                <asp:Label ID="lblPostalCode" runat="server" Text='<%#Eval("PostalCode") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <%--EDUCATION--%>
                    <div class="row EducationData">
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="Education" runat="server" Text="Education: " Visible="false"></asp:Label>
                                <asp:Label ID="lblEdu" runat="server" Text='<%#Eval("Education") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="WorkType" runat="server" Text="WorkType: " Visible="false"></asp:Label>
                                <asp:Label ID="lblWorkType" runat="server" Text='<%#Eval("WorkType") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="WorkingAt" runat="server" Text="WorkingAt: " Visible="false"></asp:Label>
                                <asp:Label ID="lblWorkingAt" runat="server" Text='<%#Eval("WorkingAt") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="WorkAddress" runat="server" Text="WorkAddress: " Visible="false"></asp:Label>
                                <asp:Label ID="lblWorkAddress" runat="server" Text='<%#Eval("WorkAddress") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Monthsalary" runat="server" Text="Monthsalary: " Visible="false"></asp:Label>
                                <asp:Label ID="lblMonthsalary" runat="server" Text='<%#Eval("Monthsalary") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="AnnualSalary" runat="server" Text="AnnualSalary: " Visible="false"></asp:Label>
                                <asp:Label ID="lblAnnualSalary" runat="server" Text='<%#Eval("AnnualSalary") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <%--FAMILY--%>
                    <div class="row FamilyData">
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="FatherName" runat="server" Text="FatherName: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="FatherWork" runat="server" Text="FatherWork: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblFatherWork" runat="server" Text='<%#Eval("FatherWork") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="MotherName" runat="server" Text="MotherName: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblMotherName" runat="server" Text='<%#Eval("MotherName") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="MotherWork" runat="server" Text="MotherWork: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblMotherWork" runat="server" Text='<%#Eval("MotherWork") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Brother" runat="server" Text="Brother: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblBrother" runat="server" Text='<%#Eval("Brother") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="Sister" runat="server" Text="Sister: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblSister" runat="server" Text='<%#Eval("Sister") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="UncleName" runat="server" Text="UncleName: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblUncleName" runat="server" Text='<%#Eval("UncleName") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="UncleCity" runat="server" Text="UncleCity: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblUncleCity" runat="server" Text='<%#Eval("UncleCity") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="OtherRelatives" runat="server" Text="OtherRelatives: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblOtherRelatives" runat="server" Text='<%#Eval("OtherRelatives") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Property" runat="server" Text="Property: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblProperty" runat="server" Text='<%#Eval("Property") %>' Visible="false"></asp:Label>
                            </div>
                        </div>

                    </div>

                    <%--HEALTH--%>
                    <div class="row HealthData">
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="Height" runat="server" Text="Height: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblHeight" runat="server" Text='<%#Eval("Height") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Weight" runat="server" Text="Weight: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblWeight" runat="server" Text='<%#Eval("Weight") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="color" runat="server" Text="Color: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblcolor" runat="server" Text='<%#Eval("color") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="BloodType" runat="server" Text="BloodType: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblBloodType" runat="server" Text='<%#Eval("BloodType") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Diet" runat="server" Text="Diet: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblDiet" runat="server" Text='<%#Eval("Diet") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Glasses" runat="server" Text="Glasses: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblGlasses" runat="server" Text='<%#Eval("Glasses") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>

                    <%--HoroScope--%>
                    <div class="row HoroScopeData">
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="NavrasName" runat="server" Text="NavrasName: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblNavrasName" runat="server" Text='<%#Eval("NavrasName") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Kuldevat" runat="server" Text="Kuldevat: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblKuldevat" runat="server" Text='<%#Eval("Kuldevat") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Zodic" runat="server" Text="Zodic: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblZodic" runat="server" Text='<%#Eval("Zodic") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Nadi" runat="server" Text="Nadi: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblNadi" runat="server" Text='<%#Eval("Nadi") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Charan" runat="server" Text="Charan: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblCharan" runat="server" Text='<%#Eval("Charan") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Constellation" runat="server" Text="Constellation: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblConstellation" runat="server" Text='<%#Eval("Constellation") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="col-12 col-12-small">
                            <div>
                                <asp:Label CssClass="label" ID="Gotra" runat="server" Text="Gotra: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblGotra" runat="server" Text='<%#Eval("Gotra") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Gan" runat="server" Text="Gan: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblGan" runat="server" Text='<%#Eval("Gan") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Mangal" runat="server" Text="Mangal: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblMangal" runat="server" Text='<%#Eval("Mangal") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="Yoni" runat="server" Text="Yoni: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblYoni" runat="server" Text='<%#Eval("Yoni") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="BirthDate" runat="server" Text="BirthDate: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblBirthDate" runat="server" Text='<%#Eval("BirthDate") %>' Visible="false"></asp:Label>
                            </div>
                            <div>
                                <asp:Label CssClass="label" ID="BirthTime" runat="server" Text="BirthTime: " Visible="false"></asp:Label>
                                <asp:Label CssClass="labelValue" ID="lblBirthTime" runat="server" Text='<%#Eval("BirthTime") %>' Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <%--BUTTONS--%>
                    <div>
                        <asp:Button ID="btnMoreInfo" runat="server" Text="More Info" OnClick="MoreInfo_Click" />
                    </div>
                    <div>
                        <asp:Button ID="btnCollapse" runat="server" Text="Collapse" OnClick="btnCollapse_Click" Visible="false" />
                    </div>

                </article>
            </section>

        </ItemTemplate>


    </asp:Repeater>

</asp:Content>
