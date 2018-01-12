using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShareHolderStatus.WebForms
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessLayer.GetInfo getpermission = new BusinessLayer.GetInfo();

            if(getpermission.login(txtboxUserName.Text, txtboxPassword.Text))
            {
                Response.Write("Succesfull");
            }
            else
            {
                Response.Write("Unsuccesfull");
            }            
        }
    }
}