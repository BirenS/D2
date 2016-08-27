<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v4_Vidhi_107.aspx.cs" Inherits="WebApplication5.v4_Vidhi_107" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Greeting Card Maker</title> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:MultiView ID="MultiView1" runat="server" > 

    <asp:View ID="View1" runat="server">
    Choose a background color:<br  />   
    <asp:DropDownList ID="lstBackColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" />
        <br />
        <br />
    <asp:Button ID="Button1" runat="server" CommandArgument="View2" CommandName="SwitchViewByID" Text="Next >" OnClick="Button1_Click" /> 
    </asp:View>

    <asp:View ID="View2" runat="server"> 
    Choose a border style: <br  />  
    <asp:RadioButtonList ID="lstBorder" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" RepeatColumns="2" /> 
    <br  />    <asp:CheckBox ID="chkPicture" runat="server" AutoPostBack="True" OnCheckedChanged="ControlChanged" Text="Add the Default Picture"  />
        <br />
    <asp:Button ID="Button2" runat="server" CommandArgument="View1" CommandName="SwitchViewByID" Text="< Prev" OnClick="Button2_Click" /> 
    <asp:Button ID="Button3" runat="server" CommandArgument="View3" CommandName="SwitchViewByID" Text="Next >" OnClick="Button3_Click" /> 
    </asp:View>

    <asp:View ID="View3" runat="server">    
    Choose a font name:<br  />   
    <asp:DropDownList ID="lstFontName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" /> 
    <br  /><br  />    Specify a font size:<br  />  
    <asp:TextBox ID="txtFontSize" runat="server" AutoPostBack="True" OnTextChanged="ControlChanged" />   
    <br  /><br  />    Enter the greeting text below:<br  />   
    <asp:TextBox ID="txtGreeting" runat="server" AutoPostBack="True" TextMode="MultiLine" /> 
        <br />
    <asp:Button ID="Button4" runat="server" CommandArgument="View2" CommandName="SwitchViewByID" Text="< Prev" OnClick="Button4_Click" /> 
    <asp:Button ID="Button5" runat="server" Text="Next >" OnClick="Button5_Click" />
    </asp:View> 

    </asp:MultiView> 
    </div>
      <!-- Here is the card: -->   
         <asp:Panel ID="pnlCard" runat="server" Width="339px" Height="481px" HorizontalAlign="Center"  style="POSITION: absolute; TOP: 16px; LEFT: 313px;">    <br />&nbsp;  
         <asp:Label ID="lblGreeting" runat="server" Width="256px"  Height="150px" /><br /><br /><br /> 
         <asp:Image ID="imgDefault" runat="server" Width="257px" Height="248px" /> 
        </asp:Panel> 
    </form>
</body>
</html>
