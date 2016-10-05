<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="version4.aspx.cs" Inherits="GreetingsWebApp.jaimish_91.version4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" BackColor="LemonChiffon" BorderStyle="Groove" BorderWidth="2px" CellPadding="10" OnFinishButtonClick="Wizard1_FinishButtonClick">
            <WizardSteps>
            <asp:WizardStep runat="server" Title="Step 1 - Colors">
            Choose a foreground (text) color:<br />
            <asp:DropDownList ID="lstForeColor" runat="server" />
            <br />
            Choose a background color:<br />
            <asp:DropDownList ID="lstBackColor" runat="server" />
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Step 2 - Background">
            Choose a border style:<br />

            <asp:RadioButtonList ID="lstBorder" runat="server" RepeatColumns="2" />
            <br /><br />
            <asp:CheckBox ID="chkPicture" runat="server"
            Text="Add the Default Picture" />
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Step 3 - Text">
            Choose a font name:<br />
            <asp:DropDownList ID="lstFontName" runat="server" />
            <br /><br />
            Specify a font size:<br />
            <asp:TextBox ID="txtFontSize" runat="server" />
            <br /><br />
            Enter the greeting text below:<br />
            <asp:TextBox ID="txtGreeting" runat="server"
            TextMode="MultiLine" />
            </asp:WizardStep>
            <asp:WizardStep runat="server" StepType="Complete" Title="Greeting Card">
             <asp:Panel ID="pnlCard" runat="server"
            Width="339px" Height="481px" HorizontalAlign="Center"
            style="POSITION: absolute; TOP: 16px; LEFT: 360px;">
            <br />&nbsp;
            <asp:Label ID="lblGreeting" runat="server" Width="256px"
            Height="150px" /><br /><br /><br />
            <asp:Image ID="imgDefault" runat="server" Width="212px" Visible="false"
            Height="160px" />
            </asp:Panel>
            </asp:WizardStep>
            </WizardSteps>
            </asp:Wizard>    

    </div>
    </form>
</body>
</html>
