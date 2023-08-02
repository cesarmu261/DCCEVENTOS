using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System.Data;

namespace Negocio
{
    public class NPaDetalle
    {
        public static int SSCod = 1;
        DataTable paquete;
        NPaquete nPaquete;
        NConceptos nConceptos;
        NEstado nEstado;

        public NPaDetalle()
        {
            paquete = new DataTable();
        }
        public int? ObtenerDescripcionesCod()
        {
            EventosContext context = new EventosContext();
            return new DMPaDetalle(context).ObtenerUltimoCodigo();
        }
        public DataTable ObtenerPaquete()
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePaqueteDetalle> paquetelist = new DMPaDetalle(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("PAQUETE");
            Table.Columns.Add("CONCEPTOS");
            Table.Columns.Add("ESTADO");

            foreach (SaEvePaqueteDetalle dat in paquetelist)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = dat.CodDetallepaq;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["PAQUETE"] = nPaquete.ObtenerDescripciones((int)dat.CodPaquete);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["CONCEPTOS"] = nConceptos.ObtenerNombreTipoPorcentaje(dat.CodConceptos);
                row["ESTADO"] = nEstado.ObtenerDescripcione(dat.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;
        }
        public DataTable Obtener(int codpaquete)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePaqueteDetalle> paquetelist = new DMPaDetalle(contexto).Obtener(0, 0, codpaquete);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("PAQUETE");
            Table.Columns.Add("CONCEPTOS");
            Table.Columns.Add("ESTADO");

            foreach (SaEvePaqueteDetalle dat in paquetelist)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = dat.CodDetallepaq;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["PAQUETE"] = nPaquete.ObtenerDescripciones((int)dat.CodPaquete);  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["CONCEPTOS"] = nConceptos.ObtenerNombreTipoPorcentaje(dat.CodConceptos);
                row["ESTADO"] = nEstado.ObtenerDescripcione(dat.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;

        }
        public InfoCompartidaCapas Guardar(SaEvePaqueteDetalle paquete)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rpaquete = new DMPaDetalle(contexto).Crear(paquete);
            if (String.IsNullOrEmpty(rpaquete.error))
            {
                contexto.SaveChanges();
            }
            return rpaquete;
        }
        public bool ExisteRegistro(SaEvePaqueteDetalle concepto)
        {
            // Aquí debes escribir la lógica para verificar si existe un registro con los mismos valores en la base de datos
            // Puedes utilizar una consulta LINQ o realizar una consulta a través de tu ORM o método preferido

            // Ejemplo de verificación utilizando LINQ y Entity Framework
            using (var context = new EventosContext())
            {
                bool existe = context.SaEvePaqueteDetalles.Any(d =>
                    d.CodDp == concepto.CodDp &&
                    d.CodPaquete == concepto.CodPaquete &&
                    d.CodConceptos == concepto.CodConceptos &&
                    d.CodEstado == concepto.CodEstado);

                return existe;
            }
        }

        public InfoCompartidaCapas Eliminar(SaEvePaqueteDetalle paquete)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rpaquete = new DMPaDetalle(contexto).Eliminar(paquete);
            if (String.IsNullOrEmpty(rpaquete.error))
            {
                contexto.SaveChanges();
            }
            return rpaquete;
        }
        public InfoCompartidaCapas Modificar(SaEvePaqueteDetalle paquete)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rpaquete = new DMPaDetalle(contexto).Modificar(paquete);
            if (String.IsNullOrEmpty(rpaquete.error))
            {
                contexto.SaveChanges();
            }
            return rpaquete;
        }
        public DataTable ObtenerPaquete2(int codpa)
        {
            EventosContext contexto = new EventosContext();
            paquete = ToolsDBContext.ToDataTable<SaEvePaqueteDetalle>(new DMPaDetalle(contexto).Obtener2(codpa));

            return paquete;
        }

    }
}
