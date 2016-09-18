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

    public partial class v6_2_Sagar_97 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {

                pnlCard.BackColor = Color.FromName(PreviousPage.bccolor);

                lblGreeting.Font.Name = PreviousPage.fonttype;

                if (Int32.Parse(PreviousPage.fontsize) > 0)
                {
                    lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(PreviousPage.fontsize));
                }

                TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
                pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(PreviousPage.borderstyle);

                if (PreviousPage.Cb == true)
                {
                    imgDefault.ImageUrl = "defaultpic.png";
                    imgDefault.Visible = true;

                }
                else
                {
                    imgDefault.Visible = false;
                }
                lblGreeting.Text = PreviousPage.gt;

            }
        }
    }
}