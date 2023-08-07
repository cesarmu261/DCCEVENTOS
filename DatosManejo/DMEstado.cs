using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMEstado : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMEstado(EventosContext contexto)
        {
            this.contexto = contexto;
            this.contexto.Database.OpenConnection();
        }
        public List<SaCodEstado> Obtener(string CodEstado = "", string DesEstado = "")
        {
            List<SaCodEstado> porcentajes = new List<SaCodEstado>();
            if (porcentajes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
            {
                porcentajes = contexto.SaCodEstados.AsNoTracking().Where(a => a.CodEstado == CodEstado).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    porcentajes = porcentajes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaCodEstados.AsNoTracking().ToList();
            }
            return porcentajes;
        }
        public string? ObtenerCodigoEstado(string descripcion)
        {
            return contexto.SaCodEstados.Where(a => a.DesEstado == descripcion).FirstOrDefault().CodEstado;
        }
        public string? Obtenedescripcion(string cod)
        {
            var elemento = contexto.SaCodEstados.FirstOrDefault(a => a.CodEstado == cod);
            return elemento != null ? elemento.DesEstado : "ACTIVO";
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
