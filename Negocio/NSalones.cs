using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSalones
    {
        DataTable table;
        public static int SSCod = 1;
        public static string SSCodcon, SSDescon;

        public NSalones()
        {
            table = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<SaEventoSalone> List = new DMSalones(contexto).Obtener();
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("DESCRIPCION LARGA");
            Table.Columns.Add("ESTADO");

            foreach (SaEventoSalone datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodSalon;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesSalon;
                row["DESCRIPCION LARGA"] = datos.DeslarSalon;
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;

        }
        public DataTable Obtener(string Descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEventoSalone> List = new DMSalones(contexto).Obtener(0, Descripcion);
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("DESCRIPCION LARGA");
            Table.Columns.Add("ESTADO");

            foreach (SaEventoSalone datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.CodSalon;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = datos.DesSalon;
                row["DESCRIPCION LARGA"] = datos.DeslarSalon;
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado);
                Table.Rows.Add(row);
            }

            return Table;

        }
       

        public InfoCompartidaCapas Modificar(SaEventoSalone salones)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMSalones(contexto).Modificar(salones);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Guardar(SaEventoSalone salones)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMSalones(contexto).Crear(salones);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public InfoCompartidaCapas Eliminar(SaEventoSalone salones)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMSalones(contexto).Eliminar(salones);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
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
        public Object[] ObtenerDescripciones(int Codsalones = 0, string Descripcion = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMSalones(context).Obtener(Codsalones, Descripcion) select c.DesSalon).ToArray();
        }
        public int ObtenerDescripcione(string nombre = "" )
        {
            EventosContext context = new EventosContext();
            return new DMSalones(context).Obtenedescripcion(nombre);
        }
        public string ObtenerDescripcioneCod(int? cod = 0)
        {
            EventosContext context = new EventosContext();
            return new DMSalones(context).Obtenedescripcioncod(cod);
        }
        public string ObtenerNombreTipoSalon(int codigo)
        {
            using (var db = new EventosContext()) // Reemplazar TuContextoDeEntityFramework por el nombre de tu contexto de Entity Framework
            {
                var tipoestado = db.SaEventoSalones.FirstOrDefault(t => t.CodSalon == codigo);
                if (tipoestado != null)
                {
                    return tipoestado.DeslarSalon;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

    }
}
