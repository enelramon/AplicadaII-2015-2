using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicadaII_2015_2
{
    public partial class EjemploValidaciones : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void InitializeCulture()
        {
            if (Session["Lang"] != null)
            {
                this.UICulture = Session["Lang"].ToString();
            }
            else
            {
                Session["Lang"] = this.UICulture.Substring(0, 2);
            }

          //  this.UICulture = "EN";
           
            base.InitializeCulture();
        }    


    }
}