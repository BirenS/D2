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
    public partial class version8 : System.Web.UI.Page
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
            HttpCookie Cookie = Request.Cookies["Attributes"];
            if (Cookie == null)
            {
                Cookie = new HttpCookie("Attributes");
            }
            Cookie["backcolor"] = lstBackColor.SelectedItem.Text;
            Cookie["fontname"] = lstFontName.SelectedItem.Text;
            Cookie["fontsize"] = txtFontSize.Text;
            Cookie["borderstyle"] = lstBorder.SelectedItem.Text;
            Cookie["greetingtext"] = txtGreeting.Text;
            Cookie["chkpic"] = chkPicture.Checked.ToString();
            Cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(Cookie);
            Response.Redirect("version81.aspx");
        }
    }
}