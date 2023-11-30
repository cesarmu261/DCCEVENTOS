using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMenu
    {
        public static int SSCod = 1;
        DataTable Menu;
        public NMenu()
        {
            Menu = new DataTable();
        }
        public DataTable Obtenerparapermisos()
        {
            EventosContext contexto = new EventosContext();
            List<Menu> List = new DMMenu(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("NOMBRE");
            foreach (Menu datos in List)
            {
                DataRow row = Table.NewRow();
                row["NOMBRE"] = datos.Nombre;
                Table.Rows.Add(row);
            }
            return Table;
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<Menu> List = new DMMenu(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("NOMBRE DE FORMULARIO");
            foreach (Menu datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdMenu;
                row["NOMBRE"] = datos.Nombre;
                row["NOMBRE DE FORMULARIO"] = datos.NombreFormulario;
                Table.Rows.Add(row);
            }
            return Table;
        }
        public DataTable Obtener(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<Menu> List = new DMMenu(contexto).Obtener(0, Descripcion);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("NOMBRE DE FORMULARIO");
            foreach (Menu datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdMenu;
                row["NOMBRE"] = datos.Nombre;
                row["NOMBRE DE FORMULARIO"] = datos.NombreFormulario;
                Table.Rows.Add(row);
            }
            return Table;
        }
        public InfoCompartidaCapas Guardar(Menu datos)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMMenu(contexto).Crear(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Modificar(Menu datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMMenu(contexto).Modificar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Eliminar(Menu datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMMenu(contexto).Eliminar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public Object[] ObtenerDescripciones(int Cod = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMMenu(context).Obtener(Cod, Descripcion) select c.Nombre).ToArray();
        }
        //public int ObtenerDescripcionesCod(string descripcion = "")
        //{
        //    EventosContext context = new EventosContext();
        //    return (int)new DMMenu(context).ObtenerCodigo(descripcion);
        //}
        public int ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();

            // Obtén el valor nullable y usa ?? para proporcionar un valor predeterminado (en este caso, 0).
            int? codigoNullable = new DMMenu(context).ObtenerCodigo(descripcion) ?? 0;

            // Ahora puedes convertir el valor nullable a un entero sin problemas.
            return (int)codigoNullable;
        }
        public string ObtenerDescripcione(int? cod = 0)
        {
            EventosContext context = new EventosContext();
            return new DMMenu(context).Obtenedescripcion(cod);
        }
    }
}
