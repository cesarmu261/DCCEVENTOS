using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        NCategoria nCategoria;
        public NEventoDetalle()
        {
            eventos = new DataTable();
            nConceptos = new NConceptos();
            nPaquete = new NPaquete();
            nCategoria = new NCategoria();

        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            eventos = ToolsDBContext.ToDataTable<SaEventoDetalle>(new DMEventoDetalle(contexto).Obtener());
            return eventos;
        }
        public DataTable ObtenePagoEventos2(int cod)
        {
            EventosContext contexto = new EventosContext();
            List<SaEventoDetalle> List = new DMEventoDetalle(contexto).Obtener(0, cod);

            //DataTable eventos = ToolsDBContext.ToDataTable<SaEventoDetalle>(List);
            DataTable eventos = new DataTable();
            eventos.Columns.Add("COD PAQUETE");
            eventos.Columns.Add("DES CONCEPTOS");
            eventos.Columns.Add("COSTO DE VENTA");
            eventos.Columns.Add("CANTIDAD");
            eventos.Columns.Add("DESCUENTO");
            eventos.Columns.Add("PRECIO TOTAL");

            foreach (SaEventoDetalle ev in List)
            {
                DataRow row = eventos.NewRow();
                int? codDetallepaq = ev.CodDetallepaq;

                // Obtener la descripción del paquete si el valor no es nul-l, o un valor vacío si es null.
                string descripcionPaquete = codDetallepaq.HasValue
                    ? nPaquete.ObtenerDescripcione(codDetallepaq.Value)
                    : string.Empty;

                // Asignar el valor a la columna "COD PAQUETE" en la fila "row".
                row["COD PAQUETE"] = descripcionPaquete;
                row["DES CONCEPTOS"] = nConceptos.ObtenerDescripcione(ev.CodConceptos);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["COSTO DE VENTA"] = ev.Costoprecio;
                row["CANTIDAD"] = ev.Cantidad;
                row["DESCUENTO"] = ev.Descuento;
                row["PRECIO TOTAL"] = ev.CostoTotal;
                eventos.Rows.Add(row);
            }

            return eventos;

        }
        public DataTable ObteneEventos2(int cod)
        {
            EventosContext contexto = new EventosContext();
            List<SaEventoDetalle> List = new DMEventoDetalle(contexto).Obtener(0,cod);

            //DataTable eventos = ToolsDBContext.ToDataTable<SaEventoDetalle>(List);
            DataTable eventos = new DataTable();
            eventos.Columns.Add("CC");
            eventos.Columns.Add("CODIGO");
            eventos.Columns.Add("COD PAQUETE");
            eventos.Columns.Add("DES CONCEPTOS");
            eventos.Columns.Add("CATEGORIA");
            eventos.Columns.Add("COSTOS CONCEPTO");
            eventos.Columns.Add("COSTO DE VENTA");
            eventos.Columns.Add("CANTIDAD");
            eventos.Columns.Add("DESCUENTO");
            eventos.Columns.Add("PRECIO TOTAL");

            foreach (SaEventoDetalle ev in List)
            {
                DataRow row = eventos.NewRow();
                row["CC"] = ev.CodDetalles;
                row["CODIGO"] = ev.CodEvento;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir

                int? codDetallepaq = ev.CodDetallepaq;

                // Obtener la descripción del paquete si el valor no es nul-l, o un valor vacío si es null.
                string descripcionPaquete = codDetallepaq.HasValue
                    ? nPaquete.ObtenerDescripcione(codDetallepaq.Value)
                    : string.Empty;

                // Asignar el valor a la columna "COD PAQUETE" en la fila "row".
                row["COD PAQUETE"] = descripcionPaquete;
                //row["COD PAQUETE"] = nPaquete.ObtenerDescripcione((int)ev.CodDetallepaq);
                row["DES CONCEPTOS"] = nConceptos.ObtenerDescripcione(ev.CodConceptos);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["CATEGORIA"] = nCategoria.ObtenerDescripcione(ev.CodCategoria);
                row["COSTOS CONCEPTO"] = ev.CostosConcepto;
                row["COSTO DE VENTA"] = ev.Costoprecio;
                row["CANTIDAD"] = ev.Cantidad;
                row["DESCUENTO"] = ev.Descuento;
                row["PRECIO TOTAL"] = ev.CostoTotal;
                eventos.Rows.Add(row);
            }

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

                int? codDetallepaq = ev.CodDetallepaq;

                // Obtener la descripción del paquete si el valor no es null, o un valor vacío si es null.
                string descripcionPaquete = codDetallepaq.HasValue
                    ? nPaquete.ObtenerDescripcione(codDetallepaq.Value)
                    : string.Empty;

                // Asignar el valor a la columna "COD PAQUETE" en la fila "row".
                row["COD PAQUETE"] = descripcionPaquete;
                //row["COD PAQUETE"] = nPaquete.ObtenerDescripcione((int)ev.CodDetallepaq);
                row["DES CONCEPTOS"] = nConceptos.ObtenerDescripcione(ev.CodConceptos);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
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
        public InfoCompartidaCapas GestionarDataTable(DataTable tabla, DataTable Existencia)
        {
            EventosContext eventosContext = new EventosContext();
            tabla.Merge(Existencia);
            eventosContext.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = eventosContext.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            eventosContext.TransaccionBR(coneccion, transaccion);
            DMEventoDetalle dm = new DMEventoDetalle(eventosContext);
            List<SaEventoDetalle> modificar = (from a in tabla.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>()
                                               select new SaEventoDetalle()
                                               {
                                                   CodDetalles = a.Field<int>("CodDetalles"),
                                                   CodEvento = a.Field<int>("CodEvento"),
                                                   CodDetallepaq = a.Field<int>("CodDetallepaq"),
                                                   CodConceptos = a.Field<int>("CodConceptos"),
                                                   CostosConcepto = a.Field<decimal>("CostosConcepto"),
                                                   Costoprecio = a.Field<decimal>("Costoprecio"),
                                                   Cantidad = a.Field<decimal>("Cantidad"),
                                                   CodCategoria = a.Field<int>("CodCategoria"),
                                                   Descuento = a.Field<decimal>("Descuento"),
                                                   CostoTotal = a.Field<decimal>("CostoTotal")

                                                   //CodDetalles = a.Field<int>("CC"),
                                                   //CodEvento = a.Field<int?>("CODIGO"),
                                                   //CodDetallepaq = a.Field<int?>("COD PAQUETE"),
                                                   //CodConceptos = a.Field<int?>("DES CONCEPTOS"),
                                                   //CostosConcepto = a.Field<decimal?>("COSTOS CONCEPTO"),
                                                   //Costoprecio = a.Field<decimal?>("COSTO DE VENTA"),
                                                   //Cantidad = a.Field<decimal?>("CANTIDAD"),
                                                   //CodCategoria = a.Field<int?>("CATEGORIA"),
                                                   //Descuento = a.Field<decimal?>("DESCUENTO"),
                                                   //CostoTotal = a.Field<decimal?>("PRECIO TOTAL")

                                               }).ToList();

            InfoCompartidaCapas rModArt = dm.Modificar(modificar);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                eventosContext.Database.RollbackTransaction();
                return rModArt;
            }
            eventosContext.SaveChanges();
            eventosContext.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tabla };
        }

        public InfoCompartidaCapas Modificar(SaEventoDetalle entidad)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMEventoDetalle(contexto).Modificar(entidad);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        
    }
}


