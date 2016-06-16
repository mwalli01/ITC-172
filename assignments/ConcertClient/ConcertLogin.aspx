<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConcertLogin.aspx.cs" Inherits="ConcertLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <h1>HI THIS IS THE VENUE LOGIN SERVICE. ENTER LOG IN. THANKS :))</h1>
    <h3>VVV LOGIN GOES HERE VVVV</h3>
        <p>USERNAME</p><asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
    <br />
        <p>PASSWORD</p><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><asp:Label ID="ResultLabel" runat="server" Text="."></asp:Label>
    <br />
    <br />    
        <asp:Button ID="Button1" runat="server" Text="LOGIN :)" OnClick="Button1_Click" />
    <br />
    <asp:LinkButton ID="RegisterLinkButton" runat="server" PostBackUrl="~/RegistrationForm.aspx">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
