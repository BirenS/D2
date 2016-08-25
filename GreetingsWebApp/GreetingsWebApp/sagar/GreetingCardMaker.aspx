<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GreetingCardMaker.aspx.cs" Inherits="GreetingsWebApp.sagar.GreetingCardMaker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Greeting Card Maker
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Choose a background color:<br />
        <asp:DropDownList ID="lstBackColor" runat="server" Width="194px" Height="22px"/><br /><br />
        Choose a font :<br />
        <asp:DropDownList ID="lstFontName" runat="server" Width="194px" Height="22px"/><br /><br />
        Specify a numeric font size:<br />
        <asp:TextBox ID="txtFontSize" runat="server"/><br /><br/>
        Choose a border Style:<br />
        <asp:RadioButtonList ID="lstBorder" runat="server" Width="177px" Height="59px"/><br /><br />
        <asp:CheckBox ID="chkPicture" runat="server" Text="Add the default picture" /><br /><br />
        Enter The Greeting text Below:<br />
        <asp:TextBox ID="txtGreeting" runat="server" width="240px" Height="85px" TextMode="MultiLine"/><br /><br />
        <asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click" runat="server" Width="71px" Height="24px" Text="update"/>

    </div>
        <asp:Panel ID="pnlCard" runat="server" Width="339px" Height="481px" HorizontalAlign="Center" Style="position:absolute;top:20px; left:305px"><br />&nbsp;
        <asp:Label ID="lblGreeting" runat="server" Width="256px" Height="150px"/><br /><br /><br />
        <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" />
        </asp:Panel>
    </form>
</body>
</html>
