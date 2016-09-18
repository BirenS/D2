<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v1_Sagar_97.aspx.cs" Inherits="GreetingsWebApp.Sagar.v1_Sagar_97" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <!-- Here are the controls: -->
            Choose a background color:<br />
            <asp:DropDownList ID="lstBackColor" runat="server" Width="194px"
            Height="22px"/><br /><br />
            Choose a font:<br />
            <asp:DropDownList ID="lstFontName" runat="server" Width="194px"
            Height="22px" /><br /><br />
            Specify a numeric font size:<br />
            <asp:TextBox ID="txtFontSize" runat="server" /><br /><br />
            Choose a border style:<br />
            <asp:RadioButtonList ID="lstBorder" runat="server" Width="177px"
            Height="59px" /><br /><br />
            <asp:CheckBox ID="chkPicture" runat="server"
            Text="Add the Default Picture"></asp:CheckBox><br /><br />
            Enter the greeting text below:<br />
            <asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px"
            TextMode="MultiLine" /><br /><br />
            <asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click"
            runat="server" Width="71px" Height="24px" Text="Update" />
      </div>
        <div>
            <!-- Here is the card: -->
            <asp:Panel ID="pnlCard" runat="server"
            Width="339px" Height="481px" HorizontalAlign="Center"
            style="POSITION: absolute; TOP: 16px; LEFT: 313px;">
            <br />&nbsp;
            <asp:Label ID="lblGreeting" runat="server" Width="256px"
            Height="150px" /><br /><br /><br />
            <asp:Image ID="imgDefault" runat="server" Width="212px"
            Height="160px" />
            </asp:Panel>
    </div>
    </form>
</body>
</html>
