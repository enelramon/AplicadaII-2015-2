using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicadaII_2015_2.ControlPanel
{
    public partial class AjaxTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //toastr["error"]("Ariel se quemara en  A", "lalalalal");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.error('There was an error', 'Error')", true);﻿
        }

        [System.Web.Services.WebMethod]
        public static string GetCurrentTime(string name)
        {

            return "Hola " + name + " Fecha: " + DateTime.Now.ToString();
        }

    }
}