using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreetingsWebApp.Sagar
{
    public partial class v7_2_Sagar_97 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName(Request.QueryString["bccolor"]);

            lblGreeting.Font.Name = Request.QueryString["fonttype"];

            if (Int32.Parse(Request.QueryString["fontsize"]) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(Request.QueryString["fontsize"]));
            }

            TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(Request.QueryString["border"]);

            if (Request.QueryString["cb"] == "true")
            {
                imgDefault.ImageUrl = "defaultpic.png";
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = Request.QueryString["gt"];

        }
    }
}