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
    public partial class v9_2_Sagar_97 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string backcolor, ft, fs, border, forpic, greettext;


            backcolor = (string)Session["bccolor"];
            ft = (string)Session["fonttype"];
            fs = (string)Session["fontsize"];
            border = (string)Session["border"];
            forpic = (string)Session["forpic"];
            greettext = (string)Session["gt"];

            pnlCard.BackColor = Color.FromName(backcolor);

            lblGreeting.Font.Name = ft;

            if (Int32.Parse(fs) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(fs));
            }

            TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(border);

            if (forpic == "true")
            {
                imgDefault.ImageUrl = "defaultpic.png";
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = greettext;
        }
    }
}