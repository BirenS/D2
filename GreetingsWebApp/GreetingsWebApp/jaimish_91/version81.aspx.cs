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
    public partial class version81 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["Attributes"];
            if (Cookie == null)
            {
                Response.Redirect("GreetingCardMaker_version8.aspx");
            }
            else
            {
                imgDefault.ImageUrl = "images/dafault.jpg";
                pnlCard.BackColor = Color.FromName(Cookie["backcolor"]);

                // Update the font.
                lblGreeting.Font.Name = Cookie["fontname"];
                if (Int32.Parse(Cookie["fontsize"]) > 0)
                {
                    lblGreeting.Font.Size =
                    FontUnit.Point(Int32.Parse(Cookie["fontsize"]));
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
                Cookie["borderstyle"]);
                // Update the picture.
                if (Cookie["chkpic"] == "True")
                {
                    imgDefault.Visible = true;
                }
                else
                {
                    imgDefault.Visible = false;
                }
                // Set the text.
                lblGreeting.Text = Cookie["greetingtext"];

            }
        }
    }
}