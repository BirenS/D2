using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
namespace GreetingsWebApp.VIVEK
{
    public partial class v6_2_vivek_99 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(PreviousPage!=null && PreviousPage.IsCrossPagePostBack)
            {
                
                pnlCard.BackColor = Color.FromName(PreviousPage.bccolor);

                lblGreeting.Font.Name = PreviousPage.fonttype;
                
                if (Int32.Parse(PreviousPage.fontsize) > 0)
                {
                    lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(PreviousPage.fontsize));
                }

                TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
                pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(PreviousPage.borderstyle);

                if (PreviousPage.Cb==true)
                {
                    imgDefault.ImageUrl = "index.jpg";
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