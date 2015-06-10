using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicadaII_2015_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaludarButton_Click(object sender, EventArgs e)
        {
            SaludoLabel.Text = "<ol>";

            for (int i = 0; i < 2000; i++)
            {
                SaludoLabel.Text += "<li> Hola" + i + "</li>";
            }

            SaludoLabel.Text += "</ol>";
        }
    }
}