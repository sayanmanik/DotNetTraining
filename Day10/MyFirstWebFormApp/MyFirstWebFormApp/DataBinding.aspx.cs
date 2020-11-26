using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class DataBinding : System.Web.UI.Page
    {

        private void PopulateGridView()
        {

            SqlConnection connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Employees", connection);
            SqlDataReader reader = command.ExecuteReader();

            empGridView.DataSource = reader;
            empGridView.DataBind();
            connection.Close();

        }





        private void PopulateDropDown()
        {

            SqlConnection connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Employees", connection);
            SqlDataReader reader = command.ExecuteReader();


            nameDropDown.DataSource = reader;
            nameDropDown.DataTextField = "FirstName";
            nameDropDown.DataValueField = "EmpId";
            nameDropDown.DataBind();
        }

        private void FilterRecords()
        {
            SqlConnection connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Employees where EmpId=@empId", connection);
            command.Parameters.AddWithValue("@empId",Convert.ToInt32(nameDropDown.SelectedValue));

            SqlDataReader reader = command.ExecuteReader();

            empGridView.DataSource = reader;
            empGridView.DataBind();
            connection.Close();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                PopulateGridView();
                PopulateDropDown();
            }
            else
            {
                FilterRecords();
            }


        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {

        }

        
    }
}