using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace GreetingsWebApp.Ravinder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                lstBackColor.Items.Add("White");
                lstBackColor.Items.Add("Red");
                lstBackColor.Items.Add("Green");
                lstBackColor.Items.Add("Blue");
                lstBackColor.Items.Add("Yellow");

                lstFontName.Items.Add("Times New Roman");
                lstFontName.Items.Add("Arial");
                lstFontName.Items.Add("Verdana");
                lstFontName.Items.Add("Tahoma");


                ListItem item = new ListItem();

                item.Text = BorderStyle.None.ToString();

                item.Value = ((int)BorderStyle.None).ToString();
                lstBorder.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Double.ToString();
                item.Value = ((int)BorderStyle.Double).ToString();
                lstBorder.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Solid.ToString();
                item.Value = ((int)BorderStyle.Solid).ToString();
                lstBorder.Items.Add(item);

                lstBorder.SelectedIndex = 0;

                imgDefault.ImageUrl = "defaultpic.png";
            }
        }


        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;

            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }

            int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);
            pnlCard.BorderStyle = (BorderStyle)borderValue;


            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }

            lblGreeting.Text = txtGreeting.Text;


        }
    }
}