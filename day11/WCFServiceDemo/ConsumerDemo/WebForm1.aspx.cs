﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsumerDemo.ServiceReference1;

namespace ConsumerDemo
{
public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
     {
            
            ServiceClient proxyObject = new ServiceClient();
            string result = proxyObject.Greet(TextBox1.Text);
            Label1.Text = result;
     }
}
}