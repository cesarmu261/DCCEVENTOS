using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosManejo
{
     public class DMRegimen : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMRegimen(EventosContext contexto)
        {
            this.contexto = contexto;
            this.contexto.Database.OpenConnection();
        }
        public List<SaCodReg> Obtener(string Cod = "", string DesEstado = "")
        {
            List<SaCodReg> porcentajes = new List<SaCodReg>();
            if (porcentajes.Count > 1 && !String.IsNullOrEmpty(Cod))
            {
                porcentajes = contexto.SaCodRegs.AsNoTracking().Where(a => a.CodReg == Cod).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(Cod))
                {
                    porcentajes = porcentajes.Where(a => a.CodReg.Contains(Cod)).ToList();
                }
            }
            else
            {
                return contexto.SaCodRegs.AsNoTracking().ToList();
            }
            return porcentajes;
        }
        public string? ObtenerCodigoEstado(string descripcion)
        {
            return contexto.SaCodRegs.Where(a => a.DesReg == descripcion).FirstOrDefault().CodReg;
        }
        public string? Obtenedescripcion(string cod)
        {

            var elemento = contexto.SaCodRegs.FirstOrDefault(a => a.CodReg == cod);
            return elemento != null ? elemento.DesReg : "612";

        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}

