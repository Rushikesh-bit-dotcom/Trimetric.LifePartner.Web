<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="HoroScope.aspx.cs" Inherits="Trimetric.LifePartner.Web.HoroScope" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="HoroSection">
        <h1>Horoscope</h1>
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Navras Name नावरस नाम </label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtNavrasName" runat="server"></asp:TextBox>

            </div>
            <div class="col-3 col-12-small">
                <label>Kuldevat Name कुलदेवत </label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtKuldevat" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Zodic रास </label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlZodic" runat="server">
                    <asp:ListItem>Aries मेष</asp:ListItem>
                    <asp:ListItem>Taurus वृषभ</asp:ListItem>
                    <asp:ListItem>Gemini मिथुन</asp:ListItem>
                    <asp:ListItem>Cancer कर्क</asp:ListItem>
                    <asp:ListItem>Leo सिंह </asp:ListItem>
                    <asp:ListItem>Virgo कन्या</asp:ListItem>
                    <asp:ListItem>Libra तूळ</asp:ListItem>
                    <asp:ListItem>Scorpio वृश्चिक</asp:ListItem>
                    <asp:ListItem>Sagittarius धनु</asp:ListItem>
                    <asp:ListItem>Capricorn मकर</asp:ListItem>
                    <asp:ListItem>Aquarius कुंभ</asp:ListItem>
                    <asp:ListItem>Pisces मीन</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div class="col-3 col-12-small">
                <label>Nadi नाडी</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlNadi" runat="server">
                    <asp:ListItem>Aadi आदी</asp:ListItem>
                    <asp:ListItem>Madhya मध्य</asp:ListItem>
                    <asp:ListItem>Antya अंत्य</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Charan चरण</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlCharan" runat="server">
                    <asp:ListItem>Pahla पहला</asp:ListItem>
                    <asp:ListItem>Dusra दुसरा</asp:ListItem>
                    <asp:ListItem>Teesra तिसरा</asp:ListItem>
                    <asp:ListItem>Chotha चोथा</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div class="col-3 col-12-small">
                <label>Constellation नक्षत्र</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlConstellation" runat="server">
                    <asp:ListItem>Ashwini अश्विनी</asp:ListItem>
                    <asp:ListItem>Bharani भरणी</asp:ListItem>
                    <asp:ListItem>Krittika कृत्तिका</asp:ListItem>
                    <asp:ListItem>Rohini रोहिणी</asp:ListItem>
                    <asp:ListItem>Mrigashirsha मृगशीर्ष</asp:ListItem>
                    <asp:ListItem>Ardra आर्द्रा</asp:ListItem>
                    <asp:ListItem>Punarvasu पुनर्वसू</asp:ListItem>
                    <asp:ListItem>Pushya पुष्य</asp:ListItem>
                    <asp:ListItem>Ashlesha आश्लेषा</asp:ListItem>
                    <asp:ListItem>Magha मघा</asp:ListItem>
                    <asp:ListItem>Purva Falguni पूर्वा फाल्गुनी</asp:ListItem>
                    <asp:ListItem>Uttara Falguni उत्तरा फाल्गुनी</asp:ListItem>
                    <asp:ListItem>Hasta हस्त</asp:ListItem>
                    <asp:ListItem>Chitra चित्रा</asp:ListItem>
                    <asp:ListItem>Swati स्वाती</asp:ListItem>
                    <asp:ListItem>Vishakha विशाखा</asp:ListItem>
                    <asp:ListItem>Anuradha अनुराधा</asp:ListItem>
                    <asp:ListItem>Jyeshtha ज्येष्ठा</asp:ListItem>
                    <asp:ListItem>Root मूळ</asp:ListItem>
                    <asp:ListItem>Purvashadha पूर्वाषाढा</asp:ListItem>
                    <asp:ListItem>Uttarashadha उत्तराषाढा</asp:ListItem>
                    <asp:ListItem>Shravan श्रवण</asp:ListItem>
                    <asp:ListItem>Dhanishtha धनिष्ठा</asp:ListItem>
                    <asp:ListItem>Shattaraka शततारका</asp:ListItem>
                    <asp:ListItem>Purvabhadrapada पूर्वाभाद्रपदा</asp:ListItem>
                    <asp:ListItem>Uttarabhadrapada उत्तराभाद्रपदा</asp:ListItem>
                    <asp:ListItem>Revati रेवती</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Gotra गोत्र</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlGotra" runat="server">
                    <asp:ListItem>Atri अत्रि</asp:ListItem>
                    <asp:ListItem>Kaushik कौशिक</asp:ListItem>
                    <asp:ListItem>Babravya बाभ्रव्य</asp:ListItem>
                    <asp:ListItem>Vishnu Vriddha विष्णुवृद्ध</asp:ListItem>
                    <asp:ListItem>Cup कपि</asp:ListItem>
                    <asp:ListItem>Gargya गार्ग्य</asp:ListItem>
                    <asp:ListItem>Bhardwaj भारद्वाज</asp:ListItem>
                    <asp:ListItem>Shandilya शांडिल्य</asp:ListItem>
                    <asp:ListItem>Kashyap काश्यप</asp:ListItem>
                    <asp:ListItem>Jamadagnya जामदग्न्य</asp:ListItem>
                    <asp:ListItem>Vatsa वत्स</asp:ListItem>
                    <asp:ListItem>Kaundinya कौंडिण्य</asp:ListItem>
                    <asp:ListItem>Nityundan नित्युन्दन</asp:ListItem>
                    <asp:ListItem>Vasistha वसिष्ठ</asp:ListItem>

                </asp:DropDownList>

            </div>
            <div class="col-3 col-12-small">
                <label>Gan गण</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlGan" runat="server">
                    <asp:ListItem>Dev देव</asp:ListItem>
                    <asp:ListItem>Manavमानव</asp:ListItem>
                    <asp:ListItem>akshash राक्षस</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Mangal मंगळ </label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlMangal" runat="server">
                    <asp:ListItem>Yes होय</asp:ListItem>
                    <asp:ListItem>No नाही</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div class="col-3 col-12-small">
                <label>Yoni योनि </label>
            </div>
            <div class="col-3 col-12-small">
                <asp:DropDownList ID="ddlYoni" runat="server">
                    <asp:ListItem>Horse अश्व</asp:ListItem>
                    <asp:ListItem>Gaja गज</asp:ListItem>
                    <asp:ListItem>Cow गौ</asp:ListItem>
                    <asp:ListItem>Snake सर्प</asp:ListItem>
                    <asp:ListItem>Dog श्वान</asp:ListItem>
                    <asp:ListItem>Marjar मार्जार</asp:ListItem>
                    <asp:ListItem>Aries मेष</asp:ListItem>
                    <asp:ListItem>Mouse मूषक</asp:ListItem>
                    <asp:ListItem>Lion सिंह</asp:ListItem>
                    <asp:ListItem>Ox महिष</asp:ListItem>
                    <asp:ListItem>Tiger व्याघ्र</asp:ListItem>
                    <asp:ListItem>Deer मृग</asp:ListItem>
                    <asp:ListItem>Monkey वानर</asp:ListItem>
                    <asp:ListItem>Nakula नकुल</asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-3 col-12-small">
                <label>Birth Date</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtBirthDate" runat="server" TextMode="Date" Style="background-color: #2e3141"></asp:TextBox>
            </div>
            <div class="col-3 col-12-small">
                <label>Birth Time</label>
            </div>
            <div class="col-3 col-12-small">
                <asp:TextBox ID="txtBirthTime" runat="server" TextMode="Time" Style="background-color: #2e3141"></asp:TextBox>
            </div>
        </div>
        <br />
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Action="insert" HoroScopeId="-1" />
        </div>


    </section>
</asp:Content>
