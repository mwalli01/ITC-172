<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanPage.aspx.cs" Inherits="FanPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<style>
    ul{
    list-style-type:none;
    }
    span{        
        font-family:'DejaVu Sans';
    }
    h2{        
    }
    #rainbow{
        font-size:4em;        
    }
    .confirmlabel{
        color:red;
    }
    
</style>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:scriptmanager runat="server"></asp:scriptmanager>
    <div id="rainbow"><span style="color:#ff0000;">T</span><span style="color:#ff2000;">h</span><span style="color:#ff4000;">i</span><span style="color:#ff5f00;">s</span><span style="color:#ff7f00;"> </span><span style="color:#ff9f00;">i</span><span style="color:#ffbf00;">s</span><span style="color:#ffdf00;"> </span><span style="color:#ffff00;">t</span><span style="color:#aaff00;">h</span><span style="color:#55ff00;">e</span><span style="color:#00ff00;"> </span><span style="color:#00ff40;">f</span><span style="color:#00ff80;">a</span><span style="color:#00ffbf;">n</span><span style="color:#00ffff;"> </span><span style="color:#00bfff;">p</span><span style="color:#0080ff;">a</span><span style="color:#0040ff;">g</span><span style="color:#0000ff;">e</span></div>
        <p>Display shows by:</p>
        <ul>
        <li><asp:DropDownList ID="ArtistDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ArtistDropDownList_SelectedIndexChanged"></asp:DropDownList></li>
        <li><asp:DropDownList ID="VenueDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="VenueDropDownList_SelectedIndexChanged"></asp:DropDownList></li>
        <li><asp:DropDownList ID="ShowDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ShowDropDownList_SelectedIndexChanged"></asp:DropDownList></li>
            
        </ul>
        <asp:GridView ID="GridView1" runat="server" BackColor="AliceBlue"></asp:GridView>
        <asp:Panel ID="FollowArtistPanel" runat="server">                                    
            <h2>Select an artist above to follow or unfollow</h2>            
                        
            <asp:Button ID="FollowArtistButton" runat="server" Text="Follow" OnClick="FollowArtistButton_Click" />
            <asp:Button ID="UnfollowArtistButton" runat="server" Text="Unfollow" OnClick="UnfollowArtistButton_Click" /><p id="confirmlabel"><asp:Label ID="ConfirmedLabel" runat="server" Text="." ></asp:Label></p>
            
            <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="UnfollowArtistButton" ConfirmText="Are you sure you want to unfollow this artist?" />
            
            <asp:GridView ID="GridView2"  runat="server" BackColor="AliceBlue"></asp:GridView>
            
        </asp:Panel>
        
    </div>
    </form>
</body>
</html>
