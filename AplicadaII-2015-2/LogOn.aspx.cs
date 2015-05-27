using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicadaII_2015_2
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            if ((UserEmail.Text == "enel") && (UserPass.Text == "123"))
            {
                FormsAuthentication.RedirectFromLoginPage(UserEmail.Text, Persist.Checked);
            }
            else
            {
                Msg.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}