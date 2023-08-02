using Datos;
using DatosManejo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRegimen
    {
        public Object[] ObtenerDescripciones(string CodEstado = "", string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMRegimen(context).Obtener(CodEstado, DesEstado) select c.DesReg).ToArray();
        }
        public string ObtenerDescripcionesCod(string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return new DMRegimen(context).ObtenerCodigoEstado(DesEstado);
        }
        public string ObtenerDescripcione(string DesEstado = "")
        {   
                EventosContext context = new EventosContext();
                return new DMRegimen(context).Obtenedescripcion(DesEstado);
            
            
        }
    }
}
