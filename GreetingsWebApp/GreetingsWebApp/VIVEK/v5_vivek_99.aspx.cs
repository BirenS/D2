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
    public partial class v5_vivek_99 : System.Web.UI.Page
    {
         private string Back_color,Font_type,fontsize,Border,greet_text;
        private Boolean check;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //set the Background color list
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                Bc_list.DataSource = colorArray;
                Bc_list.DataBind();

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


            }
           
        }
        protected void page_preRender(object semder,EventArgs e)
        {
            ViewState["bccolor"] = Back_color;
            ViewState["Fonttype"] = Font_type;
            ViewState["fs"] = fontsize;
            ViewState["bor"] = Border;
            ViewState["gt"] = greet_text;
            if(check==true)
            {
                ViewState["forpic"] ="true";
            }
            else
            {
                ViewState["forpic"] = "false";
            }

        }
        protected void Save_Click(object sender,EventArgs e)
        {
            Back_color =Bc_list.SelectedItem.Text;
            Font_type =Font_list.SelectedItem.Text;
            fontsize =Font_size.Text;
            Border =Border_style.SelectedItem.Text;
            greet_text = Greeting_text.Text;
            if(Checkbox.Checked)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName((string)ViewState["bccolor"]);

            lblGreeting.Font.Name =(string)ViewState["Fonttype"];
            string FS = (string)ViewState["fs"];
            if (Int32.Parse(FS) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(FS));
            }

            TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString((string)ViewState["bor"]);

            if ((string)(ViewState["forpic"])=="true")
            {
                imgDefault.ImageUrl = "index.jpg";
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = (string)ViewState["gt"];
        }
    }
}