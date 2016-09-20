<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="version3.aspx.cs" Inherits="GreetingsWebApp.jaimish_91.version3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Panel ID="PnlCard1" runat="server"
                Width="339px" Height="481px" HorizontalAlign="left"
                style="POSITION: absolute; TOP: 16px; ">
                <br />&nbsp;
                <asp:MultiView ID="MultiView1" runat="server" >
                <asp:View ID="View1" runat="server" >
                Choose a foreground (text) color:<br />
                <asp:DropDownList ID="lstForeColor" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ControlChangedfore" Width="194px" Height="22px"/>
                <br /><br />
                Choose a background color:<br />
                <asp:DropDownList ID="lstBackColor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChangedBack" Width="194px" Height="22px"/>
                <br/>
                    <asp:Button ID="Button1" runat="server" Text="Next >" CommandName="NextView"  ></asp:Button>
                </asp:View>
                <asp:View ID="View2" runat="server">
                Choose a border style:<br />
                <asp:RadioButtonList ID="lstBorder" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChangedBorder" RepeatColumns="2" Width="177px" Height="59px" />
                <br />
                <asp:CheckBox ID="chkPicture" runat="server" AutoPostBack="True"
                OnCheckedChanged="ControlChangedPicture" Text="Add the Default Picture" />
                    <br/>
                    <asp:Button ID="Button2" runat="server" Text="Prev <" CommandName="PrevView" ></asp:Button>
                      <asp:Button ID="Button3" runat="server" Text="Next >" CommandName="NextView"  ></asp:Button>
                </asp:View>
                <asp:View ID="View3" runat="server">
                Choose a font name:<br />
                <asp:DropDownList ID="lstFontName" runat="server" AutoPostBack="True" Width="194px" Height="22px" OnSelectedIndexChanged="ControlChangedFontName" />
                <br /><br />
                Specify a font size:<br />
                <asp:TextBox ID="txtFontSize" runat="server" AutoPostBack="True" Width="240px"  OnTextChanged="ControlChangedFontSize" />
                <br /><br />
                Enter the greeting text below:<br />
                <asp:TextBox ID="txtGreeting" runat="server" AutoPostBack="True"  Width="240px" Height="85px" OnTextChanged="ControlChangedTxtGreeting" TextMode="MultiLine" />
                <br/>
                    <asp:Button ID="Button4" runat="server" Text="Prev <" CommandName="PrevView"  ></asp:Button>
      
                </asp:View>
                </asp:MultiView>
                     </asp:Panel>
                </div>
                    <asp:Panel ID="pnlCard2" runat="server"
                Width="339px" Height="481px" HorizontalAlign="Center"
                style="POSITION: absolute; TOP: 16px; LEFT: 360px;">
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
