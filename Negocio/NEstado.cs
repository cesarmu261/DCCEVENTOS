using Datos;
using DatosManejo;

namespace Negocio
{
    public class NEstado
    {
        public Object[] ObtenerDescripciones(string CodEstado = "", string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return (from c in new DMEstado(context).Obtener(CodEstado, DesEstado) select c.DesEstado).ToArray();
        }
        public string ObtenerDescripcionesCod(string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return new DMEstado(context).ObtenerCodigoEstado(DesEstado);
        }
        public string ObtenerDescripcione(string DesEstado = "")
        {
            EventosContext context = new EventosContext();
            return new DMEstado(context).Obtenedescripcion(DesEstado);
        }
    }
}
