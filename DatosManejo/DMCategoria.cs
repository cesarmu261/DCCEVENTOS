using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMCategoria
    {
        private EventosContext contexto { get; set; }
        public DMCategoria(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<SaEveCategoriaimp> Obtener(int CodCategoria = 0, string DesCategoria = "", string CodEstado = "")
        {
            List<SaEveCategoriaimp> categoria = new List<SaEveCategoriaimp>();
            if (CodCategoria != 0)
            {
                categoria = contexto.SaEveCategoriaimps.AsNoTracking().Where(a => a.CodCategoria == CodCategoria).ToList();

                if (categoria.Count > 1 && !String.IsNullOrEmpty(DesCategoria))
                {
                    categoria = categoria.Where(a => a.DesCategoria.Contains(DesCategoria)).ToList();
                    if (categoria.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        categoria = categoria.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(DesCategoria))
            {
                categoria = categoria.Where(a => a.DesCategoria.Contains(DesCategoria)).ToList();
                if (categoria.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    categoria = categoria.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEveCategoriaimps.AsNoTracking().ToList();
            }
            return categoria;
        }
        public decimal? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEveCategoriaimps.Where(a => a.DesCategoria == descripcion).FirstOrDefault().CodCategoria;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEveCategoriaimps.Where(a => a.CodCategoria == cod).FirstOrDefault().DesCategoria;
        }
        public InfoCompartidaCapas Crear(SaEveCategoriaimp categoria)
        {
            try
            {
                contexto.SaEveCategoriaimps.Add(categoria);
                return new InfoCompartidaCapas() { informacion = categoria };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {categoria.DesCategoria}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEveCategoriaimp> categoria)
        {
            try
            {
                foreach (var item in categoria)
                {
                    contexto.SaEveCategoriaimps.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = categoria };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEveCategoriaimp categoria)
        {
            try
            {
                contexto.SaEveCategoriaimps.Attach(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = categoria };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {categoria.DesCategoria}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEveCategoriaimp> categoria)
        {
            try
            {
                foreach (var item in categoria)
                {
                    contexto.SaEveCategoriaimps.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = categoria };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveCategoriaimp categoria)
        {
            try
            {
                contexto.SaEveCategoriaimps.Remove(categoria);
                return new InfoCompartidaCapas() { informacion = categoria };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {categoria.DesCategoria}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
