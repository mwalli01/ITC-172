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
            
        

        </asp:Panel>

        <asp:Panel ID="AddShowPanel" runat="server" Visible="False">
        <h2>Please Enter Show Details</h2>
            <asp:TextBox ID="ShowNameBox" runat="server">Name of Show?</asp:TextBox><br />
            <asp:TextBox ID="TimeBox" runat="server">Enter Time [HH:MM]</asp:TextBox><br />
            <asp:TextBox ID="AmPmBox" runat="server">AM or PM?</asp:TextBox><br />
            <asp:TextBox ID="DateBox" runat="server">Date[mm/dd/yy]</asp:TextBox><br />
            <asp:TextBox ID="TicketInfoBox" runat="server" Height="200px" Width="200px">Additional info?</asp:TextBox><br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            
        </asp:Panel>
    </div>
        
    </form>
</body>

</html>
