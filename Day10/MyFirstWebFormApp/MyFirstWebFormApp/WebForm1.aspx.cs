using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
		//Asp.net server objects
		//1.Request Object -- to send request to the server/application
		//2.Response Object -- to retrieve response from the server/ application



		string msg = "Page Life Cycle Events : <br/>";
		protected void Page_Init(object sender, EventArgs e)
		{
			msg += "Page Init  <br/>";
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			//Response.Write("<p style='color:red'>"+"Welcome to Asp .net programming!"+"</p>");

			msg += "Page Load  <br/>";


			string name = Request.QueryString["name"].ToString();
			string city = Request.QueryString["city"].ToString();

			Response.Write(name + "," + city);
			
        }

		protected void Page_PreRender(object sender, EventArgs e)
		{
			msg += "Page PreRender  <br/>";
			Response.Write(msg);
		}

		protected void Page_Render(object sender, EventArgs e)
		{
			msg += "Page Render  <br/>";
			//Response.Write(msg);
		}

		protected void Page_Unload(object sender, EventArgs e)
		{
			msg += "Page Unload  <br/>";

		}


		protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
	}
}