using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
using System.Web.SessionState;
namespace GreetingsWebApp.VIVEK
{
    public partial class v9_1_vivek_99 : System.Web.UI.Page
    {
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
        protected void Update_Click(object sender,EventArgs e)
        {
            Session["bccolor"] = Bc_list.SelectedItem.Text;
           Session["fonttype"] = Font_list.SelectedItem.Text;
            Session["fontsize"] = Font_size.Text;
            Session["border"] = Border_style.SelectedItem.Text;
            if (Checkbox.Checked)
            {
                Session["forpic"] = "true";
            }
            else
            {
                Session["forpic"] = "false";
            }
            Session["gt"] = Greeting_text.Text;
            Response.Redirect("~/VIVEK/v9_2_vivek_99.aspx");
        }
    }
}