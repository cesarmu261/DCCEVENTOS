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
    public class DMRol : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMRol(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<Rol> Obtener(int Cod = 0, string Des = "", string CodEstado = "") 
        {
            List<Rol> datos = new List<Rol>();
            if (Cod != 0)
            {
                datos = contexto.Rols.AsNoTracking().Where(a => a.IdRol == Cod).ToList();

                if (datos.Count > 1 && !String.IsNullOrEmpty(Des))
                {
                    datos = datos.Where(a => a.Nombre.Contains(Des)).ToList();
                }
            }
            else if (!String.IsNullOrEmpty(Des))
            {
                datos = contexto.Rols.AsNoTracking().Where(a => a.Nombre.Contains(Des)).ToList();
                if (datos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    datos = datos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.Rols.AsNoTracking().ToList();
            }
            return datos;
        }
        public int? ObtenerCodigo(string descripcion)
        {
            return contexto.Rols.Where(a => a.Nombre == descripcion).FirstOrDefault().IdRol;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.Rols.Where(a => a.IdRol == cod).FirstOrDefault().Nombre;
        }
        public InfoCompartidaCapas Crear(Rol datos)
        {
            try
            {
                contexto.Rols.Add(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {datos.Nombre}" };
            }
        }
        public InfoCompartidaCapas Crear(List<Rol> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Rols.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(Rol datos)
        {
            try
            {
                contexto.Rols.Attach(datos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {datos.Nombre}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<Rol> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Rols.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(Rol datos)
        {
            try
            {
                contexto.Rols.Remove(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {datos.Nombre}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
