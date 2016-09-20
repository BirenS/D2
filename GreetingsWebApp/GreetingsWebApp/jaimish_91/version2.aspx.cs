using System;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace GreetingsWebApp.jaimish_91
{
    public partial class version2 : System.Web.UI.Page
    {
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
        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Update the color.
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

            // Update the font.
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }
            // Update the border style. This requires two conversion steps.
            // First, the value of the list item is converted from a string
            // into an integer. Next, the integer is converted to a value in
            // the BorderStyle enumeration.
            // Find the appropriate TypeConverter for the BorderStyle enumeration.
            TypeConverter converter =TypeDescriptor.GetConverter(typeof(BorderStyle));
            // Update the border style using the value from the converter.
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(
            lstBorder.SelectedItem.Text);
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
            lblGreeting.Text = txtGreeting.Text;
        }
    }
}