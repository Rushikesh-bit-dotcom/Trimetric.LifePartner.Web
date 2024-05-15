<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="CustomerData.aspx.cs" Inherits="Trimetric.LifePartner.Web.CustomerData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="DataViewSection" style="margin: 10%; padding: 5%; margin-left: auto; margin-right: auto;">
        <asp:GridView ID="GridView1" runat="server" PageSize="3" AllowPaging="true"
            OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>

    </section>

    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
            <h1>DataList</h1>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="row">
                    <div class="col-4">
                        <h1>
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("FullName") %>'></asp:Label>
                        </h1>
                    </div>
                    <div class="col-4">
                        <h1>
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Sex") %>'></asp:Label>
                        </h1>
                    </div>
                    <div class="col-4">
                        <h1>
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                        </h1>
                    </div>
                </div>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

    </div>

    <br />
    <br />
    <asp:ListView ID="ListView1" runat="server" >
       
  
        <ItemTemplate>
           

            <div class="row">
                <div class="col-4">
                    <h1>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("FullName") %>'></asp:Label>
                    </h1>
                </div>
                <div class="col-4">
                    <h1>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Sex") %>'></asp:Label>
                    </h1>
                </div>
                <div class="col-4">
                    <h1>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                    </h1>
                </div>
            </div>
        </ItemTemplate>

    </asp:ListView>
    <%--Demo--%>

<%--    <asp:ListView ID="lvCustomers" runat="server" GroupPlaceholderID="groupPlaceHolder1"
     ItemPlaceholderID="itemPlaceHolder1" OnPagePropertiesChanging="OnPagePropertiesChanging">
    <LayoutTemplate>
        <table cellpadding="0" cellspacing="0">
            <tr>
                <th>CustomerId</th>
                <th>ContactName</th>
                <th>Country</th>
            </tr>
            <asp:PlaceHolder runat="server" ID="groupPlaceHolder1"></asp:PlaceHolder>
            <tr>
                <td colspan="3">
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lvCustomers" PageSize="3">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true"
                                 ShowNextPageButton="false" />
                            <asp:NumericPagerField ButtonType="Link" />
                            <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false"
                                 ShowPreviousPageButton="false" />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
        </table>
    </LayoutTemplate>
    <GroupTemplate>
        <tr>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
        </tr>
    </GroupTemplate>
    <ItemTemplate>
        <td><%# Eval("FullName") %></td>
        <td><%# Eval("Sex") %></td>
        <td><%# Eval("Address") %></td>
    </ItemTemplate>
</asp:ListView>--%>
</asp:Content>
