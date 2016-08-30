﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Text;
using System.ComponentModel;

namespace GreetingsWebApp.sagar
{
    public partial class GreetingCardMaker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();



              /*  lstBackColor.Items.Add("white");
                lstBackColor.Items.Add("red");
                lstBackColor.Items.Add("green");
                lstBackColor.Items.Add("blue");
                lstBackColor.Items.Add("yellow");
                */
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);

                }

                /*
                lstFontName.Items.Add("Times New roman");
                lstFontName.Items.Add("Arial");
                lstFontName.Items.Add("Verdana");
                lstFontName.Items.Add("Tahoma");
                */

                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();

                /*
                ListItem item = new ListItem();

                item.Text = BorderStyle.None.ToString();

                item.Value = ((int)BorderStyle.None).ToString();

                lstBorder.Items.Add(item);

                lstBorder.SelectedIndex = 0;*/
                imgDefault.ImageUrl = "default.JPG";
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
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(lstBorder.SelectedItem.Text);
            /*int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);
            pnlCard.BorderStyle = (BorderStyle)borderValue;
            */
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