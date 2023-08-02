using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System.Data;

namespace Negocio
{
    public class NPorcentaje
    {
        DataTable porcentajes;
        public static decimal SSCod = 1;
        public NPorcentaje()
        {
            porcentajes = new DataTable();
        }
        public DataTable ObtenerPorcentajes()
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePorcentaje> conceptosList = new DMPorcentaje(contexto).Obtener();
            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("PORCIENTO");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEvePorcentaje concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodPorcentaje;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesPorcentaje;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["PORCIENTO"] = (concepto.Porciento);
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

        }

        public DataTable ObtenerPorcentajes(string descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePorcentaje> conceptosList = new DMPorcentaje(contexto).Obtener(0, descripcion);

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DESCRIPCION");
            conceptosTable.Columns.Add("PORCIENTO");
            conceptosTable.Columns.Add("ESTADO");

            foreach (SaEvePorcentaje concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CODIGO"] = concepto.CodPorcentaje;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = concepto.DesPorcentaje;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["PORCIENTO"] = (concepto.Porciento);
                row["ESTADO"] = ObtenerNombreTipoestado(concepto.CodEstado);
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;

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
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%' And RFC like '%{2}%'", porcentaje.CodPorcentaje, porcentaje.DesPorcentaje, porcentaje.Porciento);
                }
                else
                {
                    porcentaje.Porciento = 0;
                }
                if (filtrarporcentajes.DefaultView.Count > 1)
                {
                    filtrarporcentajes.DefaultView.RowFilter = String.Format("CodigoCliente like '%{0}%' And Nombre like '%{1}%' And Rfc like '%{2}%' And DomicilioFiscal like '%{3}%'", porcentaje.CodPorcentaje, porcentaje.DesPorcentaje, porcentaje.Porciento, porcentaje.CodEstado); ;

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
        public InfoCompartidaCapas Modificar(SaEvePorcentaje porcentaje)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rporcentajes = new DMPorcentaje(contexto).Modificar(porcentaje);
            if (String.IsNullOrEmpty(rporcentajes.error))
            {
                contexto.SaveChanges();
            }
            return rporcentajes;
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
            return new DMPorcentaje(context).Obtenedescripcion(cod);
        }
    }
}

