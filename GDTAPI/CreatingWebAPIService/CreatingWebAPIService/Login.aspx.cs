using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevetchAPI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Comman.RestartWindowsService("mysql");

            if (!IsPostBack)
                lblError.Text = "";
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtusername.Text == "devtechapi" || txtusername.Text == "DEVTECHAPI") && txtpassword.Text == "api")
                {
                    lblError.Text = "";
                    Response.Redirect("Help.aspx", false);
                }
                else
                {
                    lblError.Text = "Wrong Username or Password";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Wrong Username or Password";
            }
            finally
            {

            }
        }
    }
}