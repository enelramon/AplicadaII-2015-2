using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public String Nombres { get; set; }

        public List<Telefonos> Telefonos { get; set; }


        public bool Insertar()
        {
            String Comando;

            Comando = "Insert into Personas(Nombres) Values (" + this.Nombres   + ")";

            foreach (Telefonos tel in Telefonos)
            {
                Comando += "Insert into Telefonos(IdPersona,Telefono) Values (" + this.IdPersona + ",'" + tel.Telefono  +"')";
            }

            //DAL.SaveData(Comando);

            return true;
        }

        public bool Modificar()
        { 

        }


        public void AgregarTelefono(int tipo, String telefono)
        {

            this.Telefonos.Add(new Telefonos(tipo, telefono));
        }
    }
}
