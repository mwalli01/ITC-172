<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PortalPage.aspx.cs" Inherits="PortalPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
<style>
    /*responsive web design!!!*/
    h1{
        font-family:Impact;
        font-size:4em;
        margin-left:17%;
        margin-right:10%;
    }
    ul{
        list-style-type:none;
        
    }
    li{
        float:left;
        margin:5% 17.5%;
    }
    #listDiv{
       
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to the Show Tracker Site</h1><br />
        
        <div id="listDiv">
            <ul>
            <li><asp:LinkButton ID="FanLoginButton" runat="server" PostBackUrl="~/ConcertLogin.aspx" Font-Size="X-Large">Venue Login</asp:LinkButton></li>                
            <li><asp:LinkButton ID="VenueLoginButton" runat="server" PostBackUrl="~/FanLogin.aspx" Font-Size="X-Large">Fan Login</asp:LinkButton></li>
            </ul>
        </div>

    </div>
    </form>
</body>
</html>
