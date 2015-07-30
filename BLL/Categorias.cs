using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Categorias
    {
        public int IdCategoria { set; get; }
        public string Descripcion { set; get; }
        public int Cantidad { set; get; }
        public List <SubCategorias> Subcategorias { get; set; }
        private Conexion conexion = new Conexion();
        private int acumulador = 0;

        public Categorias()
        {
            IdCategoria = 0;
            Cantidad = 0;
            Descripcion = "";
            Subcategorias = new List<SubCategorias>();
        }

        public bool Insertar()
        {
            string comando="Insert into Categorias(Descripcion,Cantidad)values('"+this.Descripcion+"','"+this.Cantidad+"');";
            
            foreach(SubCategorias detalle in Subcategorias)
            {
                comando += "insert into SubCategorias(IdCategoria,Descripcion)values((select max(IdCategoria) as IdCategoria from Categorias),'"+detalle.Descripcion+"');";
                acumulador++;
            }
            comando += "update Categorias set Descripcion='" + this.Descripcion + "',Cantidad='" + acumulador + "' where IdCategoria=(select max(IdCategoria) as IdCategoria from Categorias)";
          
            return conexion.EjecutarDB(comando) ;
        }

        public void agregarDetalle(string Descripcion)
        {
           Subcategorias.Add(new SubCategorias(Descripcion));
        }

        public bool Modificar()
        {
           string comando = "update Categorias set Descripcion='"+this.Descripcion+"',Cantidad='"+this.Cantidad+"' where IdCategoria="+this.IdCategoria+"'";
           int acumulador = 0;
            foreach (SubCategorias detalle in Subcategorias)
            {
                comando += "insert into SubCategorias(IdCategoria,Descripcion)values('"+this.IdCategoria+"','" + detalle.Descripcion + "');";
                acumulador++;
            }

           comando += "update Categorias set Descripcion='" + this.Descripcion + "',Cantidad='" + this.Cantidad + "' where IdCategoria=" + this.IdCategoria + "'";

            return conexion.EjecutarDB(comando);
        }

        public bool Eliminar()
        {
            string comando = "delete from SubCategorias where IdCategoria='"+IdCategoria+"'";
            comando+="delete from Categorias where IdCategoria='"+IdCategoria+"'";
            return conexion.EjecutarDB(comando);
        }

        public bool Buscar(int id)
        {
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexion.BuscarDb("select * from Categorias where IdCategoria='"+id+"'");
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                this.IdCategoria =(int)dt.Rows[0]["IdCategoria"];
                this.Descripcion=dt.Rows[0]["Descripcion"].ToString();
                this.Cantidad=(int)dt.Rows[0]["Cantidad"];

            }
            return retorno;
        }

        public static DataTable Listar(string campos, string filtroWhere)
        {
            Conexion conexion = new Conexion();
            return conexion.BuscarDb("select " + campos + " from Categorias where " + filtroWhere);
        }
    }
}
