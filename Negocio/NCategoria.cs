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
    public class NCategoria
    {
        DataTable categorias;
        public NCategoria()
        {
            categorias= new DataTable();
        }
        public DataTable ObtenerCategoria()
        {
            EventosContext contexto = new EventosContext();
            categorias = ToolsDBContext.ToDataTable<SaEveCategoriaimp>(new DMCategoria(contexto).Obtener());
            categorias.Columns.Remove(categorias.Columns[categorias.Columns.Count - 1]);
            categorias.Columns.Remove(categorias.Columns[categorias.Columns.Count - 1]);

            return categorias;
        }
        public InfoCompartidaCapas Guardar(SaEveCategoriaimp categoria)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rcategoria = new DMCategoria(contexto).Crear(categoria);
            if (String.IsNullOrEmpty(rcategoria.error))
            {
                contexto.SaveChanges();
            }
            return rcategoria;
        }
        public InfoCompartidaCapas FiltrosPorcentajes(DataTable filtrarcategoria, SaEveCategoriaimp categoria)
        {
            try
            {
                if (categoria.CodCategoria != 0)
                {
                    filtrarcategoria.DefaultView.RowFilter = String.Format("CodCategoria like '%{0}%'", categoria.CodCategoria);
                }
                else
                {
                    categoria.DesCategoria =  "%"; 
                }
                if (filtrarcategoria.DefaultView.Count > 1 && !String.IsNullOrEmpty(categoria.DesCategoria))
                {
                    filtrarcategoria.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%'", categoria.CodCategoria, categoria.DesCategoria);
                }
                return new InfoCompartidaCapas() { informacion = filtrarcategoria };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Ocurrio un error al intentar buscar el o los clientes" };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveCategoriaimp categoria)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rcategoria = new DMCategoria(contexto).Eliminar(categoria);
            if (String.IsNullOrEmpty(rcategoria.error))
            {
                contexto.SaveChanges();
            }
            return rcategoria;
        }
        public InfoCompartidaCapas GestionarDataTable(DataTable tablacategorias, DataTable CategoriaExistencia)
        {
            EventosContext contexto = new EventosContext();
            tablacategorias.Merge(CategoriaExistencia);
            contexto.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = contexto.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            contexto.TransaccionBR(coneccion, transaccion);
            DMCategoria dmCategoria= new DMCategoria(contexto);
            List<SaEveCategoriaimp> modificarcategoria= (from a in tablacategorias.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEveCategoriaimp() { CodCategoria = a.Field<int>("Codigo"), DesCategoria = a.Field<String>("Descripcion"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rModArt = dmCategoria.Modificar(modificarcategoria);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rModArt;
            }
            List<SaEveCategoriaimp> crearClientes = (from a in tablacategorias.Select(null, null, DataViewRowState.Added).ToList<DataRow>() select new SaEveCategoriaimp() { CodCategoria = a.Field<int>("Codigo"), DesCategoria = a.Field<String>("Descripcion"), CodEstado = a.Field<string>("Estado") }).ToList();
            InfoCompartidaCapas rCreArt = dmCategoria.Crear(crearClientes);
            if (!String.IsNullOrEmpty(rCreArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rCreArt;
            }
            contexto.SaveChanges();
            contexto.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tablacategorias };
        }
        public Object[] ObtenerDescripciones(int CodCategoria = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMCategoria(context).Obtener(CodCategoria, Descripcion) select c.DesCategoria).ToArray();
        }
        public decimal ObtenerDescripcionesCod(string descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (decimal)new DMCategoria(context).ObtenerCodigo(descripcion);
        }
    }
}
