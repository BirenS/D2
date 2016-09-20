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
    public partial class version91 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgDefault.ImageUrl = "images/dafault.jpg";
            pnlCard.BackColor = Color.FromName(Session["backcolor"].ToString());

            // Update the font.
            lblGreeting.Font.Name = Session["fontname"].ToString();
            if (Int32.Parse(Session["fontsize"].ToString()) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(Session["fontsize"].ToString()));
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
            Session["borderstyle"].ToString());
            // Update the picture.
            if (Session["chkpic"].ToString() == "True")
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.
            lblGreeting.Text = Session["greetingtext"].ToString();

            //Session.Abandon();
        }
    }
}