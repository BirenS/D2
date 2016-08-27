<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v6_redirected_107.aspx.cs" Inherits="WebApplication5.v6_redirected_107" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Greeting Card Maker</title>
</head>
<body>
    <form id="form1" runat="server">
    
      <!-- Here is the card: -->   
         <asp:Panel ID="pnlCard" runat="server" Height="481px" HorizontalAlign="Center"  style="POSITION: absolute; TOP: 16px; LEFT: 400px; width: 369px;">    <br />&nbsp;  
         <asp:Label ID="lblGreeting" runat="server" Width="256px"  Height="150px" /><br /><br /><br /> 
         <asp:Image ID="imgDefault" runat="server" Width="257px" Height="248px" /> 
        </asp:Panel> 
    
    </form>
</body>
</html>
