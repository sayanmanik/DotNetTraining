using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DropDownList1.Items.Add("Jio");
                DropDownList1.Items.Add("Vodafone");
                DropDownList1.Items.Add("Airtel");

                DropDownList1.Items.Add(new ListItem("Bharti"));
            }
            else
            {
                TextBox1.Text = DropDownList1.SelectedItem.Value;
            }

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            


        }
    }
}