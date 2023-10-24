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
    public class DMPermisos
    {
        private EventosContext contexto { get; set; }
        public DMPermisos(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<Permiso> Obtener(int Cod = 0, int rol = 0, int menu = 0, bool activo = default )
        {
            List<Permiso> datos = new List<Permiso>();
            if (Cod != 0)
            {
                datos = contexto.Permisos.AsNoTracking().Where(a => a.IdPermiso == Cod).ToList();
                if (rol != 0)
                {
                    datos = datos.Where(a => a.IdRol == rol).ToList();
                    if (menu != 0)
                    {
                        datos = datos.Where(a => a.IdMenu == menu).ToList();
                        if (activo != default)
                        {
                            datos = datos.Where(a => a.Activo == activo).ToList();
                        }
                    }
                }
            }
            else if (rol != 0)
            {
                datos = contexto.Permisos.AsNoTracking().Where(a => a.IdRol == rol).ToList();

                if (menu != 0)
                {
                    datos = datos.Where(a => a.IdMenu == menu).ToList();
                    if (activo != default)
                    {
                        datos = datos.Where(a => a.Activo == activo).ToList();
                    }
                }
            }
            else if (menu != 0)
            {
                datos = contexto.Permisos.AsNoTracking().Where(a => a.IdMenu == menu).ToList();
                if (activo != default)
                {
                    datos = datos.Where(a => a.Activo == activo).ToList();
                }
            }
            else if (activo != default)
            { 
                datos = contexto.Permisos.AsNoTracking().Where(a => a.Activo == activo).ToList();
            }
            else
            {
                return contexto.Permisos.AsNoTracking().ToList();
            }
            return datos;
        }
        public int ObtenerCodigo(int rol)
        {
            return contexto.Permisos.Where(a => a.IdRol == rol).FirstOrDefault().IdPermiso;
        }
        //public string? Obtenedescripcion(int? cod)
        //{
        //    return contexto.Rols.Where(a => a.IdRol == cod).FirstOrDefault().Nombre;
        //}
        public InfoCompartidaCapas Crear(Permiso datos)
        {
            try
            {
                contexto.Permisos.Add(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {datos.IdPermiso}" };
            }
        }
        public InfoCompartidaCapas Crear(List<Permiso> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Permisos.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(Permiso datos)
        {
            try
            {
                contexto.Permisos.Attach(datos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {datos.IdPermiso}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<Permiso> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Permisos.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(Permiso datos)
        {
            try
            {
                contexto.Permisos.Remove(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {datos.IdPermiso}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
