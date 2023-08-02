using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Negocio
{
    public class NCliente
    {
        public static int SSCod =1;
        public static string SSCodcon, SSDescon, SScantidad;
        DataTable paquete;
        public NCliente()
        {
            paquete = new DataTable();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener();
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("DOMICILIO");
            Table.Columns.Add("TELEFONO");

            foreach (SaEveCliente cliente in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = cliente.CodCliente;
                row["NOMBRE"] = cliente.NomCliente;
                row["DOMICILIO"] = cliente.Domicilio;
                row["TELEFONO"] = cliente.Telefono;

                Table.Rows.Add(row);
            }

            return Table;

        }

        public DataTable Obtener2(string nombre)
        {
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(0,"",nombre);
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("DOMICILIO");
            Table.Columns.Add("TELEFONO");

            foreach (SaEveCliente cliente in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = cliente.CodCliente;
                row["NOMBRE"] = cliente.NomCliente;
                row["DOMICILIO"] = cliente.Domicilio;
                row["TELEFONO"] = cliente.Telefono;

                Table.Rows.Add(row);
            }

            return Table;

        }
        public InfoCompartidaCapas Guardar(SaEveCliente cliente)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMCliente(contexto).Crear(cliente);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public InfoCompartidaCapas Eliminar(SaEveCliente cliente)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMCliente(contexto).Eliminar(cliente);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public int ObtenerDescripcione(string  nombre  = "")
        {
            EventosContext context = new EventosContext();
            return new DMCliente(context).Obtenedescripcion(nombre);
        }
        public InfoCompartidaCapas Modificar(SaEveCliente cliente)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rconcepto = new DMCliente(contexto).Modificar(cliente);
            if (String.IsNullOrEmpty(rconcepto.error))
            {
                contexto.SaveChanges();
            }
            return rconcepto;
        }
    }
}

