<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddShow.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Add a new show?</h1>
        <h3>Select an artist:</h3>
        <asp:DropDownList ID="ArtistDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ArtistDropDownList_SelectedIndexChanged"></asp:DropDownList>
        <asp:Panel ID="AddArtistPanel" runat="server" Visible="False">
            <h2>Add New artist</h2>
            <asp:TextBox ID="ArtistNameBox" runat="server">Artist Name</asp:TextBox><asp:RequiredFieldValidator ID="ArtistRequiredField" runat="server" ErrorMessage="Artist name required" ControlToValidate="ArtistNameBox"></asp:RequiredFieldValidator><br />
            <asp:TextBox ID="ArtistEmailBox" runat="server">Artist Email</asp:TextBox><asp:RequiredFieldValidator ID="ArtistEmailRequiredfield" runat="server" ErrorMessage="Artist email required" ControlToValidate="ArtistEmailBox"></asp:RequiredFieldValidator><br />
            <asp:TextBox ID="ArtistWebpageBox" runat="server">Artist Webpage</asp:TextBox><asp:RequiredFieldValidator ID="ArtistWebpageRequiredField" runat="server" ErrorMessage="Artist email required" ControlToValidate="ArtistWebpageBox"></asp:RequiredFieldValidator><br /><br />
            <asp:Button ID="ArtistSubmitButton" runat="server" Text="Submit" OnClick="ArtistSubmitButton_Click" />
        </asp:Panel>

        <asp:Panel ID="AddShowPanel" runat="server" Visible="False">
        <h2>Please Enter Show Details</h2>
            <asp:TextBox ID="ShowNameBox" runat="server">Name of Show?</asp:TextBox>
                <asp:RequiredFieldValidator ID="ShowNameRequiredFieldValidator1" runat="server" ErrorMessage="Show name required" ControlToValidate="ShowNameBox"></asp:RequiredFieldValidator><br /><br />
            
            <asp:TextBox ID="TimeBox" runat="server">Enter Time [HH:MM]</asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid time (HH:MM)" ValidationExpression="(1[012]|[1-9]):[0-5][0-9]" ControlToValidate="TimeBox"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="TimeRequiredFieldValidator2" runat="server" ErrorMessage="Time required" ControlToValidate="TimeBox"></asp:RequiredFieldValidator><br /><br />
            
            <asp:TextBox ID="AmPmBox" runat="server">AM or PM?</asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="AM or PM required" ValidationExpression="AM|PM|am|pm" ControlToValidate="AmPmBox"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="AmPmRequiredFieldValidator3" runat="server" ErrorMessage="Enter AM or PM" ControlToValidate="AmPmBox"></asp:RequiredFieldValidator><br /><br />
            
            <asp:TextBox ID="DateBox" runat="server">Date[mm/dd/yy]</asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="^([0]?[1-9]|[1][0-2])[./-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0-9]{4}|[0-9]{2})$" ControlToValidate="DateBox"></asp:RegularExpressionValidator>    
                <asp:RequiredFieldValidator ID="DateRequiredFieldValidator4" runat="server" ErrorMessage="Date required" ControlToValidate="DateBox"></asp:RequiredFieldValidator><br /><br />
            
            <asp:TextBox ID="TicketInfoBox" runat="server" Width="200" Height="50">Additional ticket details?</asp:TextBox><br />
            <asp:TextBox ID="AdditionalDetailsBox" runat="server" Width="200" Height="50">Additional show Details?</asp:TextBox>
            
        </asp:Panel>
 <%--       <h2>Enter Performance Details</h2>
        <asp:Panel ID="ShowDetailsPanel1" runat="server" Visible="False">
            <asp:TextBox ID="ArtistBox1" runat="server">Artist Name</asp:TextBox>
            <asp:TextBox ID="ArtistStartTimeBox1" runat="server">Start Time</asp:TextBox>
            <asp:TextBox ID="AdditionalDetailsBox1" runat="server">Additional Details</asp:TextBox>
        </asp:Panel>--%>

    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
    </div>
        <asp:Label ID="ResultLabel" runat="server" Text="."></asp:Label>
        
    </form>
</body>

</html>
