using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class StateManagementDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtName.Text;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["name"].ToString();

        }




        protected void btn1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("myCookie");
            cookie.Value = TextBox2.Text;
            cookie.Expires = DateTime.Now.AddSeconds(30);
            Response.Cookies.Add(cookie);
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            
            HttpCookie cookie = Request.Cookies["myCookie"];
            
            if(cookie!=null)
            TextBox3.Text = cookie.Value;

        }


        protected void btn2_Click(object sender, EventArgs e)
        {

            Response.Redirect("WebForm1.aspx?name=Sayan&city=Kolkata");

        }
    }
}