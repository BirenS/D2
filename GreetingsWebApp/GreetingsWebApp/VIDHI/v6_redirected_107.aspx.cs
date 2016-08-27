using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace WebApplication5
{
    public partial class v6_redirected_107 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Greetings"];
            if (cookie != null)
            {
                // Update the color.  
                pnlCard.BackColor = Color.FromName(cookie["color"]);
                // Update the font.        
                lblGreeting.Font.Name = cookie["fname"];
                if (Int32.Parse(cookie["fsize"]) > 0)
                {
                    lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(cookie["fsize"]));
                }

                // Find the appropriate TypeConverter for the BorderStyle enumeration.
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
                // Update the border style using the value from the converter.
                pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(cookie["border"]);
                // int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);  
                // pnlCard.BorderStyle = (BorderStyle)borderValue;       
                // Update the picture.
                imgDefault.ImageUrl = "imgDefault.jpeg";
                if (cookie["pic"] == "True")
                {
                    imgDefault.Visible = true;
                }
                else
                {
                    imgDefault.Visible = false;
                }
                // Set the text.     
                lblGreeting.Text = cookie["text"];
            }
            UpdateCard();
        }
        protected void ControlChanged(object sender, System.EventArgs e)
        {    // Refresh the greeting card (because a control was changed). 
            UpdateCard();
        }

        private void UpdateCard()
        {
            // (The code that draws the greeting card goes here.) 
        }
    }
}