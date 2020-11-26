using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack == true)
            //{
            //    Label1.Text = Label1.Text + TextBox1.Text;
            //    Label1.Text = CheckBox1.Text;

            //}
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + TextBox1.Text;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = CheckBox1.Text;

        }
    }
}