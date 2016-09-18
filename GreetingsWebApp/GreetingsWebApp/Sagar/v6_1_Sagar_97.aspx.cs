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
    public partial class v6_1_Sagar_97 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //set the Background color list
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                BClist.DataSource = colorArray;
                BClist.DataBind();

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
        
        public string bccolor
        {
            get
            {
                return BClist.SelectedItem.Text;
            }
        }

        public string fonttype
        {
            get { return Font_list.SelectedItem.Text; }
        }

        public string fontsize
        {
            get { return Font_size.Text; }
        }

        public string borderstyle
        {
            get { return Border_style.SelectedItem.Text; }
        }
        public bool Cb
        {
            get
            {
                if (Checkbox.Checked)
                    return true;
                else
                    return false;
            }


        }

        public string gt
        {
            get { return Greeting_text.Text; }
        }

    }
}
