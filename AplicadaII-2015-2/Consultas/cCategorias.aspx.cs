using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AplicadaII_2015_2.Consultas
{
    public partial class cCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void buscarButton_Click(object sender, EventArgs e)
        {
            CategoriasDataList.DataSource = Categorias.Listar("*", "1=1");
            CategoriasDataList.DataBind();
        }

        protected void CategoriasDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataListItem item = CategoriasDataList.Items[CategoriasDataList.SelectedIndex];
            Label Id = (Label )item.FindControl("CodigoLabel");

           ErrorLabel .Text = "entro: "+ Id.Text ;
            //categoria.Agregaritem(id.text);
        }


    }
}