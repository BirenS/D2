<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v6_1_Sagar_97.aspx.cs" Inherits="GreetingsWebApp.Sagar.v6_1_Sagar_97" %>

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
            </asp:DropDownList>
            <br />
            Choose a Font:<br />
            <asp:DropDownList ID="Font_list" runat="server">
            </asp:DropDownList>
            <br />
            Provide numeric font size:<br/>
            <asp:TextBox ID="Font_size" runat="server"></asp:TextBox>
            <br />
           Choose a border Style:<br />
            <asp:RadioButtonList ID="Border_style" runat="server" >
            </asp:RadioButtonList>
            <br />
         
            <asp:CheckBox ID="Checkbox" runat="server" Text="Add the Default Picture:" />
            <br />
            Enter the greeting text Below:<br />
            <asp:TextBox ID="Greeting_text" runat="server"></asp:TextBox>
            <br />
       
            <asp:Button ID="Update" runat="server" Text="Generate"  PostBackUrl="~/Sagar/v6_2_Sagar_97.aspx" />
            <br />
            <br />
    </div>
    </form>
</body>
</html>
