using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMPorcentaje : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMPorcentaje(EventosContext contexto)
        {
            this.contexto = contexto;
            this.contexto.Database.OpenConnection();
        }
        public decimal? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEvePorcentajes.Where(a => a.DesPorcentaje == descripcion).FirstOrDefault().CodPorcentaje;
        }
        public decimal? Obteneriva(string descripcion)
        {
            return contexto.SaEvePorcentajes.Where(a => a.DesPorcentaje == descripcion).FirstOrDefault().Porciento;
        }

        public List<SaEvePorcentaje> Obtener(decimal CodPorcentaje = 0, string DesPorcentaje = "", decimal porciento = 0, string CodEstado = "")
        {
            List<SaEvePorcentaje> porcentajes = new List<SaEvePorcentaje>();
            if (CodPorcentaje != 0)
            {
                porcentajes = contexto.SaEvePorcentajes.AsNoTracking().Where(a => a.CodPorcentaje == CodPorcentaje).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(DesPorcentaje))
                {
                    porcentajes = porcentajes.Where(a => a.DesPorcentaje.Contains(DesPorcentaje)).ToList();
                    if (porcentajes.Count > 1 && (porciento != 0))
                    {
                        porcentajes = porcentajes.Where(a => a.Porciento == porciento).ToList();
                        if (porcentajes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                        {
                            porcentajes = porcentajes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(DesPorcentaje))
            {
                porcentajes = contexto.SaEvePorcentajes.AsNoTracking().Where(a => a.DesPorcentaje.Contains(DesPorcentaje)).ToList();
                if (porcentajes.Count > 1 && (porciento != 0))
                {
                    porcentajes = porcentajes.Where(a => a.Porciento == porciento).ToList();
                    if (porcentajes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        porcentajes = porcentajes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                    }
                }
            }


            else if (porciento != 0)
            {
                porcentajes = contexto.SaEvePorcentajes.AsNoTracking().Where(a => a.Porciento == porciento).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    porcentajes = porcentajes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEvePorcentajes.AsNoTracking().ToList();
            }
            return porcentajes;
        }

        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEvePorcentajes.Where(a => a.CodPorcentaje == cod).FirstOrDefault().DesPorcentaje;
        }
        public InfoCompartidaCapas Crear(SaEvePorcentaje porcentaje)
        {
            try
            {
                contexto.SaEvePorcentajes.Add(porcentaje);
                return new InfoCompartidaCapas() { informacion = porcentaje };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {porcentaje.DesPorcentaje}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvePorcentaje> porcentaje)
        {
            try
            {
                foreach (var item in porcentaje)
                {
                    contexto.SaEvePorcentajes.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = porcentaje };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvePorcentaje porcentaje)
        {
            try
            {
                contexto.SaEvePorcentajes.Attach(porcentaje).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = porcentaje };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {porcentaje.DesPorcentaje}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvePorcentaje> porcentaje)
        {
            try
            {
                foreach (var item in porcentaje)
                {
                    contexto.SaEvePorcentajes.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = porcentaje };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvePorcentaje porcentaje)
        {
            try
            {
                contexto.SaEvePorcentajes.Remove(porcentaje);
                return new InfoCompartidaCapas() { informacion = porcentaje };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {porcentaje.DesPorcentaje}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
