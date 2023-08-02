using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Negocio
{
    public class NCategoria
    {
        public static int SSCod = 1;
        DataTable categorias;
        public NCategoria()
        {
            categorias = new DataTable();
        }
        public DataTable ObtenerCategoria()
        {
            EventosContext contexto = new EventosContext();
            List<SaEveCategoriaimp> conceptosList = new DMCategoria(contexto).Obtener();

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEveCategoriaimp concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodCategoria;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesCategoria;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;
        }
        public DataTable ObtenerCategoria(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEveCategoriaimp> conceptosList = new DMCategoria(contexto).Obtener(0, Descripcion);

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEveCategoriaimp concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodCategoria;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesCategoria;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

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
                    categoria.DesCategoria = "%";
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
        public InfoCompartidaCapas Modificar(SaEveCategoriaimp Categoria)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rcategorias = new DMCategoria(contexto).Modificar(Categoria);
            if (String.IsNullOrEmpty(rcategorias.error))
            {
                contexto.SaveChanges();
            }
            return rcategorias;
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
            DMCategoria dmCategoria = new DMCategoria(contexto);
            List<SaEveCategoriaimp> modificarcategoria = (from a in tablacategorias.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEveCategoriaimp() { CodCategoria = a.Field<int>("Codigo"), DesCategoria = a.Field<String>("Descripcion"), CodEstado = a.Field<string>("Estado") }).ToList();
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
            return new DMCategoria(context).Obtenedescripcion(cod);
        }
    }
}
