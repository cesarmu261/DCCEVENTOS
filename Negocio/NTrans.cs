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
    public  class NTrans
    {
        DataTable table;
        public static int SSCod = 1;
        public static string SSCodcon, SSDescon;

        public NTrans()
        {
            table = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<SaEvTipoTransaccion> List = new DMTrans(contexto).Obtener();
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");

            foreach (SaEvTipoTransaccion datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodTipoTransaccion;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesTipoTransaccion;
                Table.Rows.Add(row);
            }
            return Table;

        }
        public DataTable Obtener(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvTipoTransaccion> List = new DMTrans(contexto).Obtener(0, Descripcion);
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");

            foreach (SaEvTipoTransaccion datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodTipoTransaccion;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesTipoTransaccion;
                Table.Rows.Add(row);
            }

            return Table;

        }
        public Object[] ObtenerDescripciones(int Cod = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMTrans(context).Obtener(Cod, Descripcion) select c.DesTipoTransaccion).ToArray();
        }
        public InfoCompartidaCapas Modificar(SaEvTipoTransaccion tran)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMTrans(contexto).Modificar(tran);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Guardar(SaEvTipoTransaccion tra)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMTrans(contexto).Crear(tra);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public InfoCompartidaCapas Eliminar(SaEvTipoTransaccion tra)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMTrans(contexto).Eliminar(tra);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public int ObtenerDescripcionesCod(string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return new DMTrans(context).Obtenedescripcion(DesEstado);
        }
        public string ObtenerDescripcione(int? cod)
        {
            EventosContext context = new EventosContext();
            return new DMTrans(context).Obtenedescripcioncod(cod);
        }

    }
}
