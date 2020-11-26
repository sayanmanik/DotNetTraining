using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["visitorCount"] = (int)Application["visitorCount"] + 1;


            Response.Write(Application["visitorCount"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Response.Redirect("WebForm4.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}