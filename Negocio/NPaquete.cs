using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPaquete
    {
        DataTable paquete;
        public NPaquete()
        {
            paquete = new DataTable();
        }
        public DataTable ObtenerPaquete()
        {
            EventosContext contexto = new EventosContext();
            paquete = ToolsDBContext.ToDataTable<SaEvePaquete>(new DMPaquete(contexto).Obtener());
            paquete.Columns.Remove(paquete.Columns[paquete.Columns.Count - 1]);
            paquete.Columns.Remove(paquete.Columns[paquete.Columns.Count - 1]);

            return paquete;
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
            return (from c in new DMPorcentaje(context).Obtener(CodCategoria, Descripcion) select c.DesPorcentaje).ToArray();
        }
        public decimal ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (decimal)new DMPorcentaje(context).ObtenerCodigo(descripcion);
        }
    }
}
