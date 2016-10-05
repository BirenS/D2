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
    public partial class version61 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox t1, t2;
            RadioButtonList r1;
            DropDownList d1, d2;
            CheckBox c1;
              if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                d1 = (DropDownList)PreviousPage.FindControl("lstBackColor");

                d2 = (DropDownList)PreviousPage.FindControl("lstFontName");
                t1 = (TextBox)PreviousPage.FindControl("txtFontSize");

                t2 = (TextBox)PreviousPage.FindControl("txtGreeting");
                r1 = (RadioButtonList)PreviousPage.FindControl("lstBorder");
                c1 = (CheckBox)PreviousPage.FindControl("chkPicture");


                imgDefault.ImageUrl = "images/dafault.jpg";
                pnlCard.BackColor = Color.FromName(d1.SelectedItem.Text);

                // Update the font.
                lblGreeting.Font.Name = d2.SelectedItem.Text;
                if (Int32.Parse(t1.Text) > 0)
                {
                    lblGreeting.Font.Size =
                    FontUnit.Point(Int32.Parse(t1.Text));
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
                r1.SelectedItem.Text);
                // Update the picture.
                if (c1.Checked)
                {
                    imgDefault.Visible = true;
                }
                else
                {
                    imgDefault.Visible = false;
                }
                // Set the text.
                lblGreeting.Text = t2.Text;


            }
        }
    }
}