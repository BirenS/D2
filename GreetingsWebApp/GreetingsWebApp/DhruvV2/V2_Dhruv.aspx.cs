using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace GreetingsWebApp.DhruvV2
{
    public partial class V2_Dhruv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
              {
                // Set color options. 
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();
                
                 // Set font options.  
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }
                
               // Set border style options by adding a series of     
               // ListItem objects.         
                ListItem item = new ListItem();
                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                
                // Select the ﬁrst border option.       
                lstBorder.SelectedIndex = 0;
                // Set the picture.          
                //imgDefault.ImageUrl = "imgDefault.jpeg";
                imgDefault.Visible = false;
                }
  
            }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Update the color.  
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
            // Update the font.        
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }

            // Find the appropriate TypeConverter for the BorderStyle enumeration.
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            // Update the border style using the value from the converter.
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(lstBorder.SelectedItem.Text);
            // int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);  
            // pnlCard.BorderStyle = (BorderStyle)borderValue;       
            // Update the picture.
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
                imgDefault.ImageUrl = "v2_1.jpg";
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.     
            lblGreeting.Text = txtGreeting.Text;
            UpdateCard();

        }
        protected void ControlChanged(object sender, System.EventArgs e)
        {    // Refresh the greeting card (because a control was changed). 
            UpdateCard();
        }

        private void UpdateCard()
        {    // (The code that draws the greeting card goes here.) 
        }
    }
}