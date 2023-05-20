using Datos;
using DatosManejo;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Negocio
{
    public class NPorcentaje
    {
        DataTable porcentajes;
        public NPorcentaje()
        {
            porcentajes = new DataTable();
        }
        public DataTable ObtenerPorcentajes()
        {
            EventosContext contexto = new EventosContext();
            porcentajes = ToolsDBContext.ToDataTable<SaEvePorcentaje>(new DMPorcentaje(contexto).Obtener());

            porcentajes.Columns.Remove(porcentajes.Columns[porcentajes.Columns.Count - 1]);
            porcentajes.Columns.Remove(porcentajes.Columns[porcentajes.Columns.Count - 1]);

            return porcentajes;
        }
        public InfoCompartidaCapas Guardar(SaEvePorcentaje porcentaje)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rporcentajes = new DMPorcentaje(contexto).Crear(porcentaje);
            if (String.IsNullOrEmpty(rporcentajes.error))
            {
                contexto.SaveChanges();
            }
            return rporcentajes;
        }
        public InfoCompartidaCapas FiltrosPorcentajes(DataTable filtrarporcentajes, SaEvePorcentaje porcentaje)
        {
            try
            {
                if (porcentaje.CodPorcentaje != 0)
                {
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%'", porcentaje.CodPorcentaje);
                }
                else
                {
                    porcentaje.CodPorcentaje = 0;
                }
                if (filtrarporcentajes.DefaultView.Count > 1 && !String.IsNullOrEmpty(porcentaje.DesPorcentaje))
                {
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%'", porcentaje.CodPorcentaje, porcentaje.DesPorcentaje);
                }
                else
                {
                    porcentaje.DesPorcentaje = "%";
                }
                if (filtrarporcentajes.DefaultView.Count > 1 && (porcentaje.Porciento != 0))
                {
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%' And RFC like '%{2}%'", porcentaje.CodPorcentaje, porcentaje.DesPorcentaje,porcentaje.Porciento);
                }
                else
                {
                    porcentaje.Porciento = 0;
                }
                if (filtrarporcentajes.DefaultView.Count > 1)
                {
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%' And Rfc like '%{2}%' And DomicilioFiscal like '%{3}%'", porcentaje.CodPorcentaje, porcentaje.DesPorcentaje, porcentaje.Porciento,porcentaje.CodEstado); ;
                    
                }
                return new InfoCompartidaCapas() { informacion = filtrarporcentajes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Ocurrio un error al intentar buscar el o los clientes" };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvePorcentaje porcentaje)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rporcentaje = new DMPorcentaje(contexto).Eliminar(porcentaje);
            if (String.IsNullOrEmpty(rporcentaje.error))
            {
                contexto.SaveChanges();
            }
            return rporcentaje;
        }
        public InfoCompartidaCapas GestionarDataTable(DataTable tablaporcentajes, DataTable porcentajeExistencia)
        {
            EventosContext contexto = new EventosContext();
            tablaporcentajes.Merge(porcentajeExistencia);
            contexto.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = contexto.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            contexto.TransaccionBR(coneccion, transaccion);
            DMPorcentaje dmClientes = new DMPorcentaje(contexto);
            List<SaEvePorcentaje> modificarClientes = (from a in tablaporcentajes.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEvePorcentaje() { CodPorcentaje = a.Field<int>("CodPorcentaje"), DesPorcentaje = a.Field<String>("Descripcion"), Porciento = a.Field<decimal>("Porciento"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rModArt = dmClientes.Modificar(modificarClientes);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rModArt;
            }
            List<SaEvePorcentaje> crearClientes = (from a in tablaporcentajes.Select(null, null, DataViewRowState.Added).ToList<DataRow>() select new SaEvePorcentaje() { CodPorcentaje = a.Field<int>("CodPorcentaje"), DesPorcentaje = a.Field<String>("Descripcione"), Porciento = a.Field<decimal>("Porciento"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rCreArt = dmClientes.Crear(crearClientes);
            if (!String.IsNullOrEmpty(rCreArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rCreArt;
            }
            contexto.SaveChanges();
            contexto.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tablaporcentajes };
        }
        public Object[] ObtenerDescripciones(int codporcentaje = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMPorcentaje(context).Obtener(codporcentaje, Descripcion) select c.DesPorcentaje).ToArray();
        }
        public decimal ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (decimal)new DMPorcentaje(context).ObtenerCodigo(descripcion);
        }
        public decimal Obtenerporciento(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (decimal)new DMPorcentaje(context).Obteneriva(descripcion);
        }

    }
}

