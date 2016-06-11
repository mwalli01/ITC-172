<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanLogin.aspx.cs" Inherits="FanLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to Fan Login</h1>
        <p>USERNAME</p><asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
    <br />
        <p>PASSWORD</p><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><asp:Label ID="ResultLabel" runat="server" Text="."></asp:Label>
    <br />
    <br />    
        <asp:Button ID="Button1" runat="server" Text="LOGIN :)" OnClick="Button1_Click" />
    <br />
    <asp:LinkButton ID="RegisterLinkButton" runat="server" PostBackUrl="~/FanRegistrationForm.aspx">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
