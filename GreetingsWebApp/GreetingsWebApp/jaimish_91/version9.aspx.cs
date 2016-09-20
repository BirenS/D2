using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
using System.Net;

namespace GreetingsWebApp.jaimish_91
{
    public partial class version9 : System.Web.UI.Page
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
            Session["backcolor"] = lstBackColor.SelectedItem.Text;
            Session["fontname"] = lstFontName.SelectedItem.Text;
            Session["fontsize"] = txtFontSize.Text;
            Session["borderstyle"] = lstBorder.SelectedItem.Text;
            Session["greetingtext"] = txtGreeting.Text;
            Session["chkpic"] = chkPicture.Checked;
            //   if(!Session.IsNewSession)
            Response.Redirect("version91.aspx");
        }
    }
}