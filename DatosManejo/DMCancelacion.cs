using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosManejo
{
    public class DMCancelacion
    {

        private EventosContext contexto { get; set; }
        public DMCancelacion(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<SaEveCancelacione> Obtener(int Cod = 0, string Des = "", string CodEstado = "")
        {
            List<SaEveCancelacione> entidad = new List<SaEveCancelacione>();
            if (Cod != 0)
            {
                entidad = contexto.SaEveCancelaciones.AsNoTracking().Where(a => a.CodCancelacion == Cod).ToList();

                if (entidad.Count > 1 && !String.IsNullOrEmpty(Des))
                {
                    entidad = entidad.Where(a => a.DesCancelacion.Contains(Des)).ToList();
                    if (entidad.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        entidad = entidad.Where(a => a.DesCancelacion.Contains(CodEstado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Des))
            {
                entidad = contexto.SaEveCancelaciones.AsNoTracking().Where(a => a.DesCancelacion.Contains(Des)).ToList();
                if (entidad.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    entidad = entidad.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEveCancelaciones.AsNoTracking().ToList();
            }
            return entidad;
        }
        public decimal? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEveCancelaciones.Where(a => a.DesCancelacion == descripcion).FirstOrDefault().CodCancelacion;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEveCancelaciones.Where(a => a.CodCancelacion == cod).FirstOrDefault().DesCancelacion;
        }
        public InfoCompartidaCapas Crear(SaEveCancelacione entidad)
        {
            try
            {
                contexto.SaEveCancelaciones.Add(entidad);
                return new InfoCompartidaCapas() { informacion = entidad };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {entidad.DesCancelacion}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEveCancelacione> entidad)
        {
            try
            {
                foreach (var item in entidad)
                {
                    contexto.SaEveCancelaciones.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = entidad };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEveCancelacione entidad)
        {
            try
            {
                contexto.SaEveCancelaciones.Attach(entidad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = entidad };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {entidad.DesCancelacion}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEveCancelacione> entidad)
        {
            try
            {
                foreach (var item in entidad)
                {
                    contexto.SaEveCancelaciones.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = entidad };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveCancelacione entidad)
        {
            try
            {
                contexto.SaEveCancelaciones.Remove(entidad);
                return new InfoCompartidaCapas() { informacion = entidad };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {entidad.DesCancelacion}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
