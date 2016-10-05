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
    public partial class version7 : System.Web.UI.Page
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

            }
        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4, s5;
            bool s6;
            s1 = lstBackColor.SelectedItem.Text;
            s2 = lstFontName.SelectedItem.Text;
            s3 = lstBorder.SelectedItem.Text;
            s4 = txtFontSize.Text;
            s5 = txtGreeting.Text;
            s6 = chkPicture.Checked;
            Response.Redirect("version71.aspx?val1=" + s1 + "&val2=" + s2 + "&val3=" + s3 + "&val4=" + s4 + "&val5=" + s5 + "&val6=" + s6);
        }
    }
}