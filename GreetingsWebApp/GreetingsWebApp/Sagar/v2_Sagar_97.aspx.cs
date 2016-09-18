using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Drawing.Text;
using System.Drawing;

namespace GreetingsWebApp.Sagar
{
    public partial class v2_Sagar_97 : System.Web.UI.Page
    {
          
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                lstFontName.Items.Add(family.Name);
            }
            string[] colorArray = Enum.GetNames(typeof(KnownColor));
            lstBackColor.DataSource = colorArray;
            lstBackColor.DataBind();

            string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
            lstBorder.DataSource = borderStyleArray;
            lstBorder.DataBind();

        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            if (int.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }

            TypeConverter conv =TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle =(BorderStyle)conv.ConvertFromString(lstBorder.SelectedItem.Text);
            
            if (chkPicture.Checked)
            {
                imgDefault.ImageUrl = "defaultpic.png";
                imgDefault.Visible = true;  
            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = txtGreeting.Text;
        }
    }
}