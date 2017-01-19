<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v3_vivek_99.aspx.cs" Inherits="GreetingsWebApp.VIVEK.v3_vivek_99" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Panel ID="Panel1" runat="server"
     Width="339px" Height="481px" HorizontalAlign="Left"
 style="POSITION: absolute; TOP: 16px; LEFT: 0px;">
    
        <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="ViewChanged">
            <asp:View ID="View1" runat="server" >
                Choose Foreground Color:<br />
             <asp:DropDownList ID="Fc_list" runat="server" AutoPostBack="true" OnSelectedIndexChanged="changeFore">
             </asp:DropDownList>
             <br />
            Choose a background color:<br />
            <asp:DropDownList ID="Bc_list" runat="server" AutoPostBack="true" OnSelectedIndexChanged    ="changeBack">
            </asp:DropDownList>

            <br />
                <asp:Button ID="Button1" runat="server" Text="Next" CommandName="NextView" />
            <br />
            </asp:View>

            <asp:View ID="View2" runat="server">
                 Choose a border Style:<br />
            <asp:RadioButtonList ID="Border_style" runat="server" AutoPostBack="true" OnSelectedIndexChanged="changeBorder" >
            </asp:RadioButtonList>
                  <asp:CheckBox ID="Checkbox" runat="server" AutoPostback="true" Text="Add the Default Picture:"  OnCheckedChanged="ForImg"/>
            <br />
                 <asp:Button ID="Button2" runat="server" Text="Prev" CommandName="PrevView" />
                 <asp:Button ID="Button3" runat="server" Text="Next" CommandName="NextView" />
                 <br />
            </asp:View>

            <asp:View ID="View3" runat="server">
            Choose a font Name:
                <asp:DropDownList ID="Font_list" runat="server">
            </asp:DropDownList>
            <br />
                
                specify a numeric font size:<br/>
            <asp:TextBox ID="Font_size" runat="server"></asp:TextBox>
              
            <br />
            Enter the greeting text Below:<br />
            <asp:TextBox ID="Greeting_text" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button" runat="server" Text="Update" OnClick="Update_Click" />
            <br />
            <br />
            </asp:View>
        </asp:MultiView>
          </asp:Panel>
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
