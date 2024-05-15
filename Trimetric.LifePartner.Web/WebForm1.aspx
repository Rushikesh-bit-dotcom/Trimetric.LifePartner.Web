<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Trimetric.LifePartner.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page Method</title>
    
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>  
    <script type="text/javascript">
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/PageMethod",
                data: "",
                contentType: "application/json; charset=utf-8",
                datatype: "json",
                //success: function (msg) {
                //    $("#Hello").text(msg.d);
                //}
                //success: function (responseFromServer) {
                //    alert(responseFromServer.d);
                //}
                success: function (result) {
                    alert('Sucessfull');
                },
                error: function (result) {
                    alert("error" + result);
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Hello">
        </div>
    </form>



   
</body>
</html>
