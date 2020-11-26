using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingServiceConsumer.ServiceReference1;

namespace ShoppingServiceConsumer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Service1Client proxy = new Service1Client();
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ShoppingItem item = new ShoppingItem { ID=Convert.ToInt32(TextBox1.Text), ItemName= TextBox2.Text, ItemPrice= Convert.ToDouble(TextBox3.Text)};
            bool status = proxy.AdditemToCart(item);

            if (status)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key1","<script>alert('item added')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key1", "<script>alert('Error in adding')</script>");
            }


        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            bool status = proxy.RemoveItemToCart(id);


            if (status)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key1", "<script>alert('item removed')</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key1", "<script>alert('Error in Removing')</script>");
            }

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShoppingItem[] items = proxy.ShowAllItems();
            grid1.DataSource = items;
            grid1.DataBind();
        }
    }
}