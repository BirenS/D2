using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Text;
using System.ComponentModel;
using System.Drawing;
namespace GreetingsWebApp.VIVEK
{
    public partial class v3_vivek_99 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                
                //set the Background color list
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                Bc_list.DataSource = colorArray;
                Bc_list.DataBind();

                //set the Foreground color list
                Fc_list.DataSource = colorArray;
                Fc_list.DataBind();

                //set font options
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                {
                    Font_list.Items.Add(family.Name);
                }

                //Add Border Styles

                string[] borderArray = Enum.GetNames(typeof(BorderStyle));
                Border_style.DataSource = borderArray;
                Border_style.DataBind();

                Border_style.SelectedIndex = 0;

                MultiView1.ActiveViewIndex = 0;
            }
        }
        protected void changeFore(object sender, EventArgs e)
        {
            pnlCard.ForeColor = Color.FromName(Fc_list.SelectedItem.Text);
        }
        protected void changeBack(object sender, EventArgs e)
        { 
            pnlCard.BackColor = Color.FromName(Bc_list.SelectedItem.Text);
        }
        protected void changeBorder(object sender, EventArgs e)
        {

            TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(Border_style.SelectedItem.Text);
        }
        protected void ForImg(object sender,EventArgs e)
        {
            imgDefault.ImageUrl = "index.jpg";

            if (Checkbox.Checked)
            {
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
        }
        
        protected void ViewChanged(object sender,EventArgs e)
        {
           
        }
        protected void Update_Click(object sender,EventArgs e)
        {
            lblGreeting.Font.Name = Font_list.SelectedItem.Text;
            if (Int32.Parse(Font_size.Text) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(Font_size.Text));
            }
            lblGreeting.Text = Greeting_text.Text;
        }





    }
}

    
