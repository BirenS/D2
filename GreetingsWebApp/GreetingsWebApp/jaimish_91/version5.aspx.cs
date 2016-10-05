using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace GreetingsWebApp.jaimish_91
{
    public partial class version5 : System.Web.UI.Page
    {
        private string backcolor, fontname, borderstyle, greetingtext;
        private Int32 fontsize;
        protected void cmdSave_Click(object sender, EventArgs e)
        {
            backcolor = lstBackColor.SelectedItem.Text;
            fontname = lstFontName.SelectedItem.Text;
            fontsize = Int32.Parse(txtFontSize.Text);
            borderstyle = lstBorder.SelectedItem.Text;
            greetingtext = txtGreeting.Text;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            if (!this.IsPostBack)
            {

                // Set color options.
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();
                // Set font options.
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }

                // Set border style options
                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                // Select the first border option.
                lstBorder.SelectedIndex = 0;
                // Set the picture.
                imgDefault.ImageUrl = "images/dafault.jpg";
            }
            else
            {
                backcolor = (string)ViewState["backcolor"];
                fontname = (string)ViewState["fontname"];
                fontsize = (Int32)ViewState["fontsize"];
                borderstyle = (string)ViewState["borderstyle"];
                greetingtext = (string)ViewState["greetingtext"];
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["backcolor"] = backcolor;
            ViewState["fontname"] = fontname;
            ViewState["fontsize"] = fontsize;
            ViewState["borderstyle"] = borderstyle;
            ViewState["greetingtext"] = greetingtext;

        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName(backcolor);

            // Update the font.
            lblGreeting.Font.Name = fontname;
            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(fontsize);
            }
            // Update the border style. This requires two conversion steps.
            // First, the value of the list item is converted from a string
            // into an integer. Next, the integer is converted to a value in
            // the BorderStyle enumeration.
            // Find the appropriate TypeConverter for the BorderStyle enumeration.
            TypeConverter converter =
            TypeDescriptor.GetConverter(typeof(BorderStyle));
            // Update the border style using the value from the converter.
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(borderstyle);
            // Update the picture.
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.
            lblGreeting.Text = greetingtext;
        }

       
        
    }
}