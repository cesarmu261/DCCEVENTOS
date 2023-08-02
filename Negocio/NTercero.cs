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
    public class NTercero
    {
        DataTable tercero;
        public static int SSCod = 1;
        public static string SSCodcon, SSDescon, SScantidad;
        public static Action<object, object> PropertyChanged;

        public NTercero()
        {
            tercero = new DataTable();
        }
        public DataTable Obtener()
        {
            CuotasV100Context contexto = new CuotasV100Context();
            List<SaTercero> List = new DMTercero(contexto).Obtener();
            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("DOMICILIO");
            Table.Columns.Add("TELEFONO");

            foreach (SaTercero tercero in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = tercero.CodTercero; 
                row["NOMBRE"] = tercero.NomTercero;
                row["DOMICILIO"] = tercero.Domicilio;  
                row["TELEFONO"] = tercero.Telefono;
                
                Table.Rows.Add(row);
            }

            return Table;

        }

        public DataTable Obtener2(string nombre)
        {
            CuotasV100Context contexto = new CuotasV100Context();
            List<SaTercero> List = new DMTercero(contexto).Obtener("",nombre); ;

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");  
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("DOMICILIO");
            Table.Columns.Add("TELEFONO");

            foreach (SaTercero tercero in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = tercero.CodTercero;  
                row["NOMBRE"] = tercero.NomTercero;
                row["DOMICILIO"] = tercero.Domicilio;  
                row["TELEFONO"] = tercero.Telefono;

                Table.Rows.Add(row);
            }

            return Table;

        }
    }
}
