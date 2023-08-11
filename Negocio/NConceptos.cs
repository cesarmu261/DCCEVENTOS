using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Negocio
{
    public class NConceptos
    {
        DataTable conceptos;
        public static int SSCod =1;
        public static string SSCodcon, SSDescon, SScantidad, SSCategoria, SSCostos;
        public static Action<object, object> PropertyChanged;

        public NConceptos()
        {
            conceptos = new DataTable();
        }
        public DataTable ObtenerConceptos()
        {
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener();
            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("CATEGORIA");
            conceptosTable.Columns.Add("CANTIDAD");
            conceptosTable.Columns.Add("IVA");
            conceptosTable.Columns.Add("PORCIENTO");
            conceptosTable.Columns.Add("PRECIO DE COMPRA");
            conceptosTable.Columns.Add("PRECIO DE TOTAL CONCEPTO");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEveConcepto concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodConceptos;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesConceptos;
                row["CATEGORIA"] = ObtenerNombreTipoCategoria(concepto.CodCategoria);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["CANTIDAD"] = concepto.Cantidad;
                row["IVA"] = ObtenerNombreTipoPorcentaje(concepto.CodPorcentaje);
                row["PORCIENTO"] = concepto.Porciento;
                row["PRECIO DE COMPRA"] = concepto.CostosConceptos;
                row["PRECIO DE TOTAL CONCEPTO"] = concepto.Costoprecio;
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

        }

        public DataTable ObtenerConceptos2(string descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener2(descripcion);

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("Codigos");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("Descripcion");
            conceptosTable.Columns.Add("Cantidad");
            

            foreach (SaEveConcepto concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["Codigos"] = concepto.CodConceptos;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["Descripcion"] = concepto.DesConceptos;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["Cantidad"] = concepto.Cantidad;
                
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

        }

        public InfoCompartidaCapas Modificar(SaEveConcepto concepto)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rconcepto = new DMConceptos(contexto).Modificar(concepto);
            if (String.IsNullOrEmpty(rconcepto.error))
            {
                contexto.SaveChanges();
            }
            return rconcepto;
        }
        public InfoCompartidaCapas Guardar(SaEveConcepto concepto)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rporcentajes = new DMConceptos(contexto).Crear(concepto);
            if (String.IsNullOrEmpty(rporcentajes.error))
            {
                contexto.SaveChanges();
            }
            return rporcentajes;
        }

        public InfoCompartidaCapas Eliminar(SaEveConcepto concepto)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rconcepto = new DMConceptos(contexto).Eliminar(concepto);
            if (String.IsNullOrEmpty(rconcepto.error))
            {
                contexto.SaveChanges();
            }
            return rconcepto;
        }
        public InfoCompartidaCapas GestionarDataTable(DataTable tablaconceptos, DataTable conceptoExistencia)
        {
            EventosContext contexto = new EventosContext();
            tablaconceptos.Merge(conceptoExistencia);
            contexto.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = contexto.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            contexto.TransaccionBR(coneccion, transaccion);
            DMConceptos dmconceptos = new DMConceptos(contexto);
            List<SaEveConcepto> modificarconcepto = (from a in tablaconceptos.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEveConcepto() { CodConceptos = a.Field<int>("Codigo"), CodCategoria = a.Field<int>("Categoria"), DesConceptos = a.Field<String>("Descripcion"), CostosConceptos = a.Field<decimal>("Costos Conceptos"), Costoprecio = a.Field<decimal>("Costos uni"), CodEstado = a.Field<string>("Estado"), CodPorcentaje = a.Field<int>("codPorcentaje"), Porciento = a.Field<decimal>("Porciento") }).ToList();
            InfoCompartidaCapas rModArt = dmconceptos.Modificar(modificarconcepto);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rModArt;
            }
            List<SaEveConcepto> crearcategoria = (from a in tablaconceptos.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEveConcepto() { CodConceptos = a.Field<int>("Codigo"), CodCategoria = a.Field<int>("Categoria"), DesConceptos = a.Field<String>("Descripcion"), CostosConceptos = a.Field<decimal>("Costos Conceptos"), Costoprecio = a.Field<decimal>("Costos uni"), CodEstado = a.Field<string>("Estado"), CodPorcentaje = a.Field<int>("codPorcentaje"), Porciento = a.Field<decimal>("Porciento") }).ToList();
            InfoCompartidaCapas rCreArt = dmconceptos.Crear(crearcategoria);
            if (!String.IsNullOrEmpty(rCreArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rCreArt;
            }
            contexto.SaveChanges();
            contexto.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tablaconceptos };
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
        public string ObtenerNombreTipoCategoria(int? codigo)
        {
            using (var db = new EventosContext()) // Reemplazar TuContextoDeEntityFramework por el nombre de tu contexto de Entity Framework
            {
                var tipoestado = db.SaEveCategoriaimps.FirstOrDefault(t => t.CodCategoria == codigo);
                if (tipoestado != null)
                {
                    return tipoestado.DesCategoria;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string ObtenerNombreTipoPorcentaje(int? codigo)
        {
            using (var db = new EventosContext()) // Reemplazar TuContextoDeEntityFramework por el nombre de tu contexto de Entity Framework
            {
                var tipoestado = db.SaEvePorcentajes.FirstOrDefault(t => t.CodPorcentaje == codigo);
                if (tipoestado != null)
                {
                    return tipoestado.DesPorcentaje;
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
            return new DMConceptos(context).Obtenedescripcion(cod);
        }
        public int? Obtenercategoria(int? cod = 0)
        {
            EventosContext context = new EventosContext();
            return new DMConceptos(context).ObteneCategoria(cod);
        }
        public decimal? ObtenerCostos(int? cod = 0)
        {
            EventosContext context = new EventosContext();
            return new DMConceptos(context).ObteneCostosConceptos(cod);
        }
    }
}
