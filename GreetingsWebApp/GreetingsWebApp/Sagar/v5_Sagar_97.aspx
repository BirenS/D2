<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v5_Sagar_97.aspx.cs" Inherits="GreetingsWebApp.Sagar.v5_Sagar_97" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         Choose Background Color:<br />
        <asp:DropDownList ID="BClist" runat="server">
        </asp:DropDownList><br />
        Choose the Font:<br />
        <asp:DropDownList ID="Font_list" runat="server">
        </asp:DropDownList>
        <br />
        Give a numeric font size:<br/>
        <asp:TextBox ID="Font_size" runat="server"></asp:TextBox>
        <br />
        Choose a border Style:<br />
        <asp:RadioButtonList ID="Border_style" runat="server" >
        </asp:RadioButtonList><br />
        <asp:CheckBox ID="Checkbox" runat="server" Text="Add Default Picture:" /><br />
        Enter the greeting text Below:<br />
        <asp:TextBox ID="Greeting_text" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
        <br />
        <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
        <br />
        <asp:Panel ID="pnlCard" runat="server" Width="339px" Height="481px" HorizontalAlign="Center"
            style="POSITION: absolute; TOP: 16px; LEFT: 313px;">
        <br />&nbsp;
        <asp:Label ID="lblGreeting" runat="server" Width="256px" Height="150px" /><br /><br /><br />
        <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
