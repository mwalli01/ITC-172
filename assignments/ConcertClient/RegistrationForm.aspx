<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationForm.aspx.cs" Inherits="RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>You gotta make an account</h1>
        <p>User Name</p><asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Required" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
    <br />
    <br />
        <p>Venue Name</p><asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Venue Name Required" ControlToValidate="VenueNameTextBox"></asp:RequiredFieldValidator>
    <br />
    <br />
        <p>Venue City</p><asp:TextBox ID="VenueCityTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Venue City Required" ControlToValidate="VenueCityTextBox"></asp:RequiredFieldValidator>
        
        <p>Venue State</p>
        <asp:TextBox ID="VenueStateTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Venue state Required" ControlToValidate="VenueStateTextBox"></asp:RequiredFieldValidator>
        
        <p>Venue Address</p>
        <asp:TextBox ID="VenueAddressTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Venue address Required" ControlToValidate="VenueAddressTextBox"></asp:RequiredFieldValidator>
        
        <p>Venue Zipcode</p>
        <asp:TextBox ID="VenueZipcodeTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Venue Zipcode Required" ControlToValidate="VenueZipcodeTextBox"></asp:RequiredFieldValidator>
        
        <p>Phone Number</p>
        <asp:TextBox ID="VenuePhoneNumberTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Venue Phone Number Required" ControlToValidate="VenuePhoneNumberTextBox"></asp:RequiredFieldValidator>
        
        <p>Webpage</p>
        <asp:TextBox ID="VenueWebpageTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Venue Webpage Required" ControlToValidate="VenueWebpageTextBox"></asp:RequiredFieldValidator>
        
        <p>Age Restriction</p>
        <asp:TextBox ID="VenueAgeRestrictionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Venue Age Restriction Required" ControlToValidate="VenueAgeRestrictionTextBox"></asp:RequiredFieldValidator>
        
        <br />
        
    <br />
       <p>Email</p> <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email Required" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Valid Email Required" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <br />
        <p>Password</p><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Password Required" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
        
    <br />
    <br />
        <p>Confirm Password</p><asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password">
        </asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToValidate="ConfirmPasswordTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator>
    <br />
    <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /><asp:Label ID="ErrorLabel" runat="server" Text="."></asp:Label>
        
    </div>
        
    </form>
</body>
</html>
