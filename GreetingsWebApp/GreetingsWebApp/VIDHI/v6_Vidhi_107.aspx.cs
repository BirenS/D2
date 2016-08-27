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


namespace WebApplication5
{
    public partial class v6_Vidhi_107 : System.Web.UI.Page
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
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Create the Request.QueryString object. 
            HttpCookie cookie = new HttpCookie("Greetings");
            cookie["color"] = lstBackColor.SelectedItem.Text;
            cookie["fname"] = lstFontName.SelectedItem.Text;
            cookie["fsize"] = txtFontSize.Text;
            cookie["border"] = lstBorder.SelectedItem.Text;
            cookie["pic"] =  chkPicture.Checked.ToString();
            cookie["text"] = txtGreeting.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("v6_redirected_107.aspx");
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