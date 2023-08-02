using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEventoDetalle
    {
        DataTable eventos;
        NPaquete nPaquete;
        NConceptos nConceptos;
        public NEventoDetalle()
        {
            eventos = new DataTable(); 
            nConceptos = new NConceptos();
            nPaquete = new NPaquete();
        
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            eventos = ToolsDBContext.ToDataTable<SaEventoDetalle>(new DMEventoDetalle(contexto).Obtener());
            return eventos;
        }

        public DataTable ObteneEventos(int codevento)
        {
            EventosContext contexto = new EventosContext();
            List<SaEventoDetalle> List = new DMEventoDetalle(contexto).Obtener2(codevento);
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  
            Table.Columns.Add("COD PAQUETE");
            Table.Columns.Add("DES CONCEPTOS");
            Table.Columns.Add("COSTOS CONCEPTO");
            Table.Columns.Add("COSTO DE VENTA");
            Table.Columns.Add("CANTIDAD");
            Table.Columns.Add("DESCUENTO");
            Table.Columns.Add("PRECIO TOTAL");
                
            foreach (SaEventoDetalle ev in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = ev.CodEvento;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["COD PAQUETE"] = nPaquete.ObtenerDescripcione((int)ev.CodDetallepaq);
                row["DES CONCEPTOS"] =nConceptos.ObtenerDescripcione( ev.CodConceptos);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["COSTOS CONCEPTO"] = ev.CostosConcepto;
                row["COSTO DE VENTA"] = ev.Costoprecio;
                row["CANTIDAD"] = ev.Cantidad;
                row["DESCUENTO"] = ev.Descuento;
                row["PRECIO TOTAL"] = ev.CostoTotal;
                Table.Rows.Add(row);
            }

            return Table;

        }
        public InfoCompartidaCapas Guardar(SaEventoDetalle evento)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMEventoDetalle(contexto).Crear(evento);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public InfoCompartidaCapas Eliminar(SaEventoDetalle evento)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMEventoDetalle(contexto).Eliminar(evento);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public bool ExisteRegistro(SaEventoDetalle concepto)
        {
            // Aquí debes escribir la lógica para verificar si existe un registro con los mismos valores en la base de datos
            // Puedes utilizar una consulta LINQ o realizar una consulta a través de tu ORM o método preferido

            // Ejemplo de verificación utilizando LINQ y Entity Framework
            using (var context = new EventosContext())
            {
                bool existe = context.SaEventoDetalles.Any(d =>
                    d.CodConceptos == concepto.CodConceptos &&
                    d.Costoprecio == concepto.Costoprecio &&
                    d.Cantidad == concepto.Cantidad &&
                    d.Descuento == concepto.Descuento &&
                    d.CostoTotal == concepto.CostoTotal);

                return existe;
            }
        }
        public int? ObtenerDescripcionesCod()
        {
            EventosContext context = new EventosContext();
            return new DMEventoDetalle(context).ObtenerUltimoCodigoEvento();
        }
    }
}
