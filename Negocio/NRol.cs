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
    public class NRol
    {
        public static int SSCod = 1;
        DataTable Menu;
        public NRol()
        {
            Menu = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<Rol> List = new DMRol(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("ESTADO");
            foreach (Rol datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdRol;
                row["NOMBRE"] = datos.Nombre;
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }
            return Table;
        }
        public DataTable Obtener(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<Rol> List = new DMRol(contexto).Obtener(0, Descripcion);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("ESTADO");
            foreach (Rol datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdRol;
                row["NOMBRE"] = datos.Nombre;
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }
            return Table;
        }
        public InfoCompartidaCapas Guardar(Rol datos)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMRol(contexto).Crear(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Modificar(Rol datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMRol(contexto).Modificar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Eliminar(Rol datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMRol(contexto).Eliminar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public Object[] ObtenerDescripciones(int Cod = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMRol(context).Obtener(Cod, Descripcion) select c.Nombre).ToArray();
        }
        public int ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (int)new DMRol(context).ObtenerCodigo(descripcion);
        }
        public string ObtenerNombreTipoestado(string codigoestado)
        {
            using (var db = new EventosContext()) // Reemplazar TuContextoDeEntityFramework por el nombre de tu contexto de Entity Framework
            {
                var tipoestado = db.SaCodEstados.FirstOrDefault(t => t.CodEstado == codigoestado);
                if (tipoestado != null)
                {
                    return tipoestado.DesEstado;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string ObtenerDescripcione(int? cod = 0)
        {
            EventosContext context = new EventosContext();
            return new DMRol(context).Obtenedescripcion(cod);
        }
    }
}