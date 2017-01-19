<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="v4_vivek_99.aspx.cs" Inherits="GreetingsWebApp.VIVEK.v4_vivek_99" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" OnFinishButtonClick="FinishButtonClick">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                                    Choose Foreground Color:<br />
                     <asp:DropDownList ID="Fc_list" runat="server"  >
                    </asp:DropDownList>
                    <br />
                    Choose a background color:<br />
                    <asp:DropDownList ID="Bc_list" runat="server"  >
                   </asp:DropDownList>
 
                   <br />
               
              </asp:WizardStep>
                  
              <asp:WizardStep runat="server" title="Step 2">
                     Choose a border Style:<br />
                    <asp:RadioButtonList ID="Border_style" runat="server"   >
                   </asp:RadioButtonList>
                   <asp:CheckBox ID="Checkbox" runat="server"  Text="Add the Default Picture:"  />
                   <br />
              </asp:WizardStep>

              <asp:WizardStep runat="server" Title="Step3" StepType="Finish">
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
              </asp:WizardStep>
             <asp:WizardStep runat="server" Title="GreetingsWebApp" StepType="Complete">
                   
                     <asp:Panel ID="pnlCard" runat="server" HorizontalAlign="Center"
   style="POSITION: absolute; TOP: 123px; LEFT: 10px; height: 500x; width: 310px;">
<br />&nbsp;
<asp:Label ID="lblGreeting" runat="server" Width="256px"
Height="150px" /><br /><br /><br />
<asp:Image ID="imgDefault" runat="server" Width="212px"
Height="160px" />
</asp:Panel>
               </asp:WizardStep> 
               
            </WizardSteps>
        </asp:Wizard>
         
    
    </div>
    </form>
</body>
</html>
