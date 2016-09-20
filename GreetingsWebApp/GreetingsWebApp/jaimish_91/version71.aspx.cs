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
    public partial class version71 : System.Web.UI.Page
    {
        string s1, s2, s3, s4, s5, s6;
        protected void Page_Load(object sender, EventArgs e)
        {
            s1 = Request.QueryString["val1"].ToString();

            s2 = Request.QueryString["val2"].ToString();

            s3 = Request.QueryString["val3"].ToString();

            s4 = Request.QueryString["val4"].ToString();

            s5 = Request.QueryString["val5"].ToString();
            s6 = Request.QueryString["val6"].ToString();
            pnlCard.BackColor = Color.FromName(s1);
            imgDefault.ImageUrl = "images/dafault.jpg";
            // Update the font.
            lblGreeting.Font.Name = s2;
            if (Int32.Parse(s4) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(s4));
            }
            // Update the border style. This requires two conversion steps.
            // First, the value of the list item is converted from a string
            // into an integer. Next, the integer is converted to a value in
            // the BorderStyle enumeration.
            // Find the appropriate TypeConverter for the BorderStyle enumeration.
            TypeConverter converter =
            TypeDescriptor.GetConverter(typeof(BorderStyle));
            // Update the border style using the value from the converter.
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(
            s3);
            // Update the picture.
            if (s6 == "True")
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.
            lblGreeting.Text = s5;
        }
    }
}