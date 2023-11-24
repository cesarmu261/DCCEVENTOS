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
    public class DMMenu : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMMenu(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<Menu> Obtener(int Codmenu = 0, string Des = "", string Formalurio ="")
        {
            List<Menu> datos = new List<Menu>();
            if (Codmenu != 0)
            {
                datos = contexto.Menus.AsNoTracking().Where(a => a.IdMenu == Codmenu).ToList();

                if (datos.Count > 1 && !String.IsNullOrEmpty(Des))
                {
                    datos = datos.Where(a => a.Nombre.Contains(Des)).ToList();
                }
            }
            else if (!String.IsNullOrEmpty(Des))
            {
                datos = contexto.Menus.AsNoTracking().Where(a => a.Nombre.Contains(Des)).ToList();
                if (datos.Count > 1 && !String.IsNullOrEmpty(Formalurio))
                {
                    datos = datos.Where(a => a.Nombre.Contains(Des)).ToList();
                }
            }
            else if (!String.IsNullOrEmpty(Formalurio))
            {
                datos = contexto.Menus.AsNoTracking().Where(a => a.NombreFormulario.Contains(Formalurio)).ToList();
            }
            else
            {
                return contexto.Menus.AsNoTracking().ToList();
            }
            return datos;
        }
        //public int? ObtenerCodigo(string descripcion)
        //{
        //    return contexto.Menus.Where(a => a.Nombre == descripcion).FirstOrDefault().IdMenu;
        //}
        public int? ObtenerCodigo(string descripcion)
        {
            var menu = contexto.Menus.FirstOrDefault(a => a.Nombre == descripcion);

            // Verificar si el menú existe
            if (menu != null)
            {
                return menu.IdMenu;
            }
            else
            {
                // El menú no existe, puedes devolver null o algún otro valor predeterminado
                return null;
            }
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.Menus.Where(a => a.IdMenu == cod).FirstOrDefault().Nombre;
        }
        public InfoCompartidaCapas Crear(Menu datos)
        {
            try
            {
                contexto.Menus.Add(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {datos.Nombre}" };
            }
        }
        public InfoCompartidaCapas Crear(List<Menu> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Menus.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(Menu datos)
        {
            try
            {
                contexto.Menus.Attach(datos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {datos.Nombre}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<Menu> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Menus.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(Menu datos)
        {
            try
            {
                contexto.Menus.Remove(datos);
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
