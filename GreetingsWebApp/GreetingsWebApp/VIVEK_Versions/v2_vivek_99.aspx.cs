using System;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
namespace GreetingsWebApp.VIVEK
{
    public partial class v2_vivek_99 : System.Web.UI.Page
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
                foreach(FontFamily family in fonts.Families )
                {
                    Font_list.Items.Add(family.Name);
                }

                //Add Border Styles

                string[] borderArray = Enum.GetNames(typeof(BorderStyle));
                Border_style.DataSource = borderArray;
                Border_style.DataBind();

                Border_style.SelectedIndex = 0;


            }
            else
            {
                imgDefault.ImageUrl = "index.jpg";

            }
        }

        protected void Update_Click(Object sender, EventArgs e)
        {
            


            pnlCard.BackColor =Color.FromName(Bc_list.SelectedItem.Text);

            lblGreeting.Font.Name = Font_list.SelectedItem.Text;
            if (Int32.Parse(Font_size.Text) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(Font_size.Text));
            }

            TypeConverter converter2 = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter2.ConvertFromString(Border_style.SelectedItem.Text);

            if (Checkbox.Checked)
            {
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = Greeting_text.Text;
        }
    }
}
   
