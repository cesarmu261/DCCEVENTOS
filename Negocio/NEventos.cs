using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System.Data;

namespace Negocio
{
    public class NEventos
    {
        DataTable eventos;
        public NEventos()
        {
            eventos = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            eventos = ToolsDBContext.ToDataTable<SaEvento>(new DMEvento(contexto).Obtener());

            return eventos;
        }

        public DataTable Obtener2( DateTime fecha)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvento> List = new DMEvento(contexto).Obtener(0, 0,0, "", fecha);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("FECHA");

            foreach (SaEvento ev in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = ev.CodEvento;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = ev.DesEvento;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["FECHA"] = ev.Fecha;
                Table.Rows.Add(row);
            }

            return Table;

        }
        public DataTable Obtener3(int cliente,string descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvento> List = new DMEvento(contexto).Obtener(0,0,cliente,descripcion);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("DESCRIPCION");
            Table.Columns.Add("FECHA");

            foreach (SaEvento ev in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = ev.CodEvento;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DESCRIPCION"] = ev.DesEvento;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["FECHA"] = ev.Fecha;
                Table.Rows.Add(row);
            }

            return Table;

        }
        public InfoCompartidaCapas Guardar(SaEvento evento)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMEvento(contexto).Crear(evento);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public InfoCompartidaCapas Eliminar(SaEvento evento)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMEvento(contexto).Eliminar(evento);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        
        public List<SaEventoDetalle> Obtener1(int codeven = 0)
        {
            EventosContext context = new EventosContext();
            return new DMEventoDetalle(context).Obtener(0,codeven);
        }
    }
}

