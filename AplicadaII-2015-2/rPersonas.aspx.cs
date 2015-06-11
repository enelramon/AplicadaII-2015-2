using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AplicadaII_2015_2
{
    public partial class rPersonas : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
             Persona persona = new Persona ();

            if (Session["persona"] != null )
            {
                persona = (Persona)Session["persona"] ;
            }

            persona.AgregarTelefono(1, TelefonoTextBox.Text);

            TelefonosGridView.DataSource = persona.Telefonos;
            TelefonosGridView.DataBind();
                
                Session["persona"]= persona;
                TelefonoTextBox.Text = "";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            if (Session["persona"] != null)
            {
                persona = (Persona)Session["persona"];
            }

            persona.Nombres = NombreTextBox.Text;

            //persona.AgregarTelefono(1,"809-588-2012");

            if (persona.Insertar())
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.error('Guardo', 'Error')", true);﻿
      
            }
        }


    }
}