using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public String Nombres { get; set; }

        public List<Telefonos> Telefonos { get; set; }

        private Conexion conexion = new Conexion();

        public Persona()
        {
            IdPersona = 0;
            Nombres = "";
           Telefonos= new List<Telefonos>();


        }

        public bool Insertar()
        {
            String Comando;

            Comando = "Insert into Persona(Nombres) Values ('" + this.Nombres   + "')";

            foreach (Telefonos tel in Telefonos)
            {
                Comando += "Insert into Telefonos(IdPersona,Telefono) Values (1,'" + tel.Telefono + "')";
            }




            return conexion.EjecutarDB(Comando);
        }

        public bool Modificar()
        {
            String Comando;

            Comando = "Update Personas set Nombres='" + this.Nombres + "' where IdPersona=" + this.IdPersona  ;

            conexion.EjecutarDB("Delete Telefonos where IdPersona=" + this.IdPersona);

            foreach (Telefonos tel in Telefonos)
            {
                Comando += "Insert into Telefonos(IdPersona,Telefono) Values (" + this.IdPersona + ",'" + tel.Telefono + "')";
            }




            return conexion.EjecutarDB(Comando);
        }


        public void AgregarTelefono(int tipo, String telefono)
        {

            this.Telefonos.Add(new Telefonos(tipo, telefono));
        }
    }
}
