using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Telefonos
    {
        public int Tipo { get; set; }
        public String Telefono { get; set; }

        public Telefonos(int tipo,String telefono)
        {
            this.Tipo = tipo;
            this.Telefono = telefono;

        }
    }
}
