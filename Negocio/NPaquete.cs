using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Negocio
{
    public class NPaquete
    {
        public static int SSCod = 1;
        DataTable paquete;
        public NPaquete()
        {
            paquete = new DataTable();
        }
        public DataTable ObtenerPaquete()
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePaquete> List = new DMPaquete(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("ESTADO");

            foreach (SaEvePaquete concepto in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = concepto.CodPaquete;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesPaquete;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;
        }
        public DataTable ObtenerPaquete(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePaquete> conceptosList = new DMPaquete(contexto).Obtener2(Descripcion);

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO"); 
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEvePaquete concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodPaquete;  
                row["DESCRIPCION"] = concepto.DesPaquete;  
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

        }
        public InfoCompartidaCapas Guardar(SaEvePaquete paquete)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rpaquete = new DMPaquete(contexto).Crear(paquete);
            if (String.IsNullOrEmpty(rpaquete.error))
            {
                contexto.SaveChanges();
            }
            return rpaquete;
        }
        public InfoCompartidaCapas Modificar(SaEvePaquete paquete)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rcategorias = new DMPaquete(contexto).Modificar(paquete);
            if (String.IsNullOrEmpty(rcategorias.error))
            {
                contexto.SaveChanges();
            }
            return rcategorias;
        }
        public InfoCompartidaCapas Eliminar(SaEvePaquete paquete)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rpaquete = new DMPaquete(contexto).Eliminar(paquete);
            if (String.IsNullOrEmpty(rpaquete.error))
            {
                contexto.SaveChanges();
            }
            return rpaquete;
        }
        public InfoCompartidaCapas GestionarDataTable(DataTable tablapaquete, DataTable PaqueteExistencia)
        {
            EventosContext contexto = new EventosContext();
            tablapaquete.Merge(PaqueteExistencia);
            contexto.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = contexto.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            contexto.TransaccionBR(coneccion, transaccion);
            DMPaquete dmPaquete = new DMPaquete(contexto);
            List<SaEvePaquete> modificarpaquete = (from a in tablapaquete.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEvePaquete() { CodPaquete = a.Field<int>("Codigo"), DesPaquete = a.Field<String>("Descripcion"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rModArt = dmPaquete.Modificar(modificarpaquete);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rModArt;
            }
            List<SaEvePaquete> crearpaquete = (from a in tablapaquete.Select(null, null, DataViewRowState.Added).ToList<DataRow>() select new SaEvePaquete() { CodPaquete = a.Field<int>("Codigo"), DesPaquete = a.Field<String>("Descripcion"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rCreArt = dmPaquete.Crear(modificarpaquete);
            if (!String.IsNullOrEmpty(rCreArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rCreArt;
            }
            contexto.SaveChanges();
            contexto.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tablapaquete };
        }
        public Object[] ObtenerDescripciones(int CodCategoria = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMPaquete(context).Obtener(CodCategoria, Descripcion) select c.DesPaquete).ToArray();
        }
        public decimal ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (decimal)new DMPaquete(context).ObtenerCodigo(descripcion);
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
            return new DMPaquete(context).Obtenedescripcion(cod);
        }
        
    }
}
