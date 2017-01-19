using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreetingsWebApp.Sagar
{
    public partial class v7_1_Sagar_97 : System.Web.UI.Page
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
        protected void Update_Click(object sender, EventArgs e)
        {
            string url = "v7_2_Sagar_97.aspx?";
            url += "bccolor=" + Bc_list.SelectedItem.Text;
            url += "&fonttype=" + Font_list.SelectedItem.Text;
            url += "&fontsize=" + Font_size.Text;
            url += "&border=" + Border_style.SelectedItem.Text;
            url += "&gt=" + Greeting_text.Text;
            if (Checkbox.Checked)
            {
                url += "&cb=" + "true";
            }
            else
            {
                url += "&cb=" + "false";
            }

            Response.Redirect(url);
        }

    }
}
