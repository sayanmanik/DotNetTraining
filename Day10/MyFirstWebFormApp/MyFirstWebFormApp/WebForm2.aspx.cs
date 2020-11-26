using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // page load will be fired each time after the page is requested
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                //Response.Write("Page Loaded For first time!");
                lblmsg.Text = "Page Loaded For first time!";


            }
            else
            {
                //Response.Write("Page Loaded on postback request!");
                lblmsg.Text = "Page Loaded on postback request!";
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Submit button clicked");
        }
    }
}