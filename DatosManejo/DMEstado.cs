using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;

namespace DatosManejo
{
    public class DMEstado
    {
        private EventosContext contexto { get; set; }
        public DMEstado(EventosContext contexto)
        {
            this.contexto = contexto;
            this.contexto.Database.OpenConnection();
        }
        public List<SaCodEstado> Obtener(string CodEstado ="", string DesEstado = "")
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
    }
}
