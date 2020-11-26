using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceConsumer.ServiceReference2;

namespace ServiceConsumer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(TextBox1.Text);

            //string name = TextBox2.Text;

            //int copy = Convert.ToInt32(TextBox3.Text);

            //string desc = TextBox4.Text;

            Service1Client client = new Service1Client();
            //proxy.InsertBook(id,name,copy,desc);
            //proxy.InsertBook(id,name,copy,desc);


            WcfExercise.Book[] books = client.GetAllBooks();
            grid1.DataSource = books;
            grid1.DataBind();

        }
    }
}