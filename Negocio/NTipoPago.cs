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
    public class NTipoPago
    {
        public static int SSCod = 1;
        DataTable table;
        public NTipoPago()
        {
            table = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<SaEveTipoPago> List = new DMTipoPago(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("ESTADO");

            foreach (SaEveTipoPago datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodPago;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesPago;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;
        }
        public DataTable Obtener(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEveTipoPago> List = new DMTipoPago(contexto).Obtener(0, Descripcion);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("ESTADO");

            foreach (SaEveTipoPago datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodPago;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesPago;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }
            return Table;
        }


        public InfoCompartidaCapas Guardar(SaEveTipoPago comp)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rguardar = new DMTipoPago(contexto).Crear(comp);
            if (String.IsNullOrEmpty(rguardar.error))
            {
                contexto.SaveChanges();
            }
            return rguardar;
        }

        public InfoCompartidaCapas Modificar(SaEveTipoPago comp)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rmodificar = new DMTipoPago(contexto).Modificar(comp);
            if (String.IsNullOrEmpty(rmodificar.error))
            {
                contexto.SaveChanges();
            }
            return rmodificar;
        }
        public InfoCompartidaCapas Eliminar(SaEveTipoPago comp)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas reliminar = new DMTipoPago(contexto).Eliminar(comp);
            if (String.IsNullOrEmpty(reliminar.error))
            {
                contexto.SaveChanges();
            }
            return reliminar;
        }

        public Object[] ObtenerDescripciones(int Cod = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMTipoPago(context).Obtener(Cod, Descripcion) select c.DesPago).ToArray();
        }
        public int? ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return new DMTipoPago(context).ObtenerCodigo(descripcion);
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
            return new DMTipoPago(context).Obtenedescripcion(cod);
        }
    }
}

