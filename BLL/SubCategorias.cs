using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class SubCategorias
    {
       public int IdSubCategoria { set; get; }
       public string Descripcion { set; get; }

       public SubCategorias(string Descripcion)
       {
           this.Descripcion = Descripcion;
       }
    }
}
