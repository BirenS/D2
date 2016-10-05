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
    public partial class version3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            if (!this.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                // Set color options.
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstForeColor.DataSource = colorArray;
                lstForeColor.DataBind();

                string[] colorArray1 = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray1;
                lstBackColor.DataBind();
                // Set font options.
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }

                // Set border style options
                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                // Select the first border option.
                lstBorder.SelectedIndex = 0;
                // Set the picture.
                imgDefault.ImageUrl = "images/dafault.jpg";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
        }

        protected void ControlChangedfore(object sender, EventArgs e)
        {
            pnlCard2.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);

        }

        protected void ControlChangedBack(object sender, EventArgs e)
        {
            pnlCard2.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

        }

        protected void ControlChangedBorder(object sender, EventArgs e)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard2.BorderStyle = (BorderStyle)converter.ConvertFromString(
            lstBorder.SelectedItem.Text);

        }

        protected void ControlChangedPicture(object sender, EventArgs e)
        {
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }

        }

        protected void ControlChangedFontName(object sender, EventArgs e)
        {
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;

        }

        protected void ControlChangedFontSize(object sender, EventArgs e)
        {

            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }
        }

        protected void ControlChangedTxtGreeting(object sender, EventArgs e)
        {
            lblGreeting.Text = txtGreeting.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View3);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
        }
    }
}