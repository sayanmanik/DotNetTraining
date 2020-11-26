using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebFormApp
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            StringBuilder msg = new StringBuilder();
            msg.Append(txtName.Text);
            foreach(ListItem r in rdbGender.Items)
            {
                if (r.Selected == true)
                {
                    msg.Append(r.Text);
                }
            }

            foreach (ListItem c in chkHobbies.Items)
            {
                if(c.Selected == true)
                {
                    msg.Append(c.Text+",");
                }
            }

            msg.Append(dropdownlist1.SelectedItem.Text);
            msg.Append(calDOB.SelectedDate.ToString());

            ClientScript.RegisterStartupScript(this.GetType(),"key1","<script>alert('"+msg+"')</script>");
        }
    }
}