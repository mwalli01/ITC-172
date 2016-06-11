<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanRegistrationForm.aspx.cs" Inherits="FanRegistrationForm" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <h1>Fan Registration</h1>
        <asp:TextBox ID="FanUsernameTextBox" runat="server">Enter Username</asp:TextBox>
        <asp:RequiredFieldValidator ID="UserNameValidator" runat="server" ErrorMessage="Username Required" ControlToValidate="FanUsernameTextBox"></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="FanNameTextBox" runat="server">Enter Name</asp:TextBox>
        <asp:RequiredFieldValidator ID="FanNameValidator" runat="server" ErrorMessage="Name Required" ControlToValidate="FanNameTextBox"></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="FanEmailTextBox" runat="server">Enter Email</asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Valid Email Required" ControlToValidate="FanEmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="FanEmailValidator" runat="server" ErrorMessage="Email Required" ControlToValidate="FanEmailTextBox"></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="FanPasswordTextBox" runat="server" >Enter Password</asp:TextBox>
        <asp:RequiredFieldValidator ID="FanPasswordValidator" runat="server" ErrorMessage="Password Required" ControlToValidate="FanPasswordTextBox"></asp:RequiredFieldValidator><br />
        <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" >Confirm pass
        </asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToValidate="ConfirmPasswordTextBox" ControlToCompare="FanPasswordTextBox"></asp:CompareValidator><br />
        <ajaxToolkit:NoBot ID="NoBot1" runat="server" />
        <asp:Button ID="FanSubmitButton" runat="server" Text="Submit" OnClick="FanSubmitButton_Click" /><asp:Label ID="ErrorLabel" runat="server" Text="."></asp:Label>
    </div>
    </form>
</body>
</html>
