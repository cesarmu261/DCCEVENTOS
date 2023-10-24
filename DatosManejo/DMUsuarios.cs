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
    public class DMUsuarios
    {
        private EventosContext contexto { get; set; }
        public DMUsuarios(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<Usuario> Obtener(int Cod = 0, string Nombre = "", string Apell = "", string Usuarios = "",
            string Clave="", int rol = 0, string Estado ="")
        {
            List<Usuario> datos = new List<Usuario>();
            if (Cod != 0)
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.IdUsuario == Cod).ToList();
                if (datos.Count > 1 && !String.IsNullOrEmpty(Nombre))
                {
                    datos = datos.Where(a => a.Nombres.Contains(Nombre)).ToList();
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Apell))
                    {
                        datos = datos.Where(a => a.Apellidos.Contains(Apell)).ToList();
                        if (datos.Count > 1 && !String.IsNullOrEmpty(Usuarios))
                        {
                            datos = datos.Where(a => a.Usuario1.Contains(Usuarios)).ToList();
                            if (datos.Count > 1 && !String.IsNullOrEmpty(Clave))
                            {
                                datos = datos.Where(a => a.Clave.Contains(Clave)).ToList();
                                if (rol != 0)
                                {
                                    datos = datos.Where(a => a.IdRol == rol).ToList();
                                    if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                                    {
                                        datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Nombre))
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.Nombres.Contains(Nombre)).ToList();

                if (datos.Count > 1 && !String.IsNullOrEmpty(Apell))
                {
                    datos = datos.Where(a => a.Apellidos.Contains(Apell)).ToList();
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Usuarios))
                    {
                        datos = datos.Where(a => a.Usuario1.Contains(Usuarios)).ToList();
                        if (datos.Count > 1 && !String.IsNullOrEmpty(Clave))
                        {
                            datos = datos.Where(a => a.Clave.Contains(Clave)).ToList();
                            if (rol != 0)
                            {
                                datos = datos.Where(a => a.IdRol == rol).ToList();
                                if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                                {
                                    datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                                }
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Apell))
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.Apellidos.Contains(Apell)).ToList();
                if (datos.Count > 1 && !String.IsNullOrEmpty(Usuarios))
                {
                    datos = datos.Where(a => a.Usuario1.Contains(Usuarios)).ToList();
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Clave))
                    {
                        datos = datos.Where(a => a.Clave.Contains(Clave)).ToList();
                        if (rol != 0)
                        {
                            datos = datos.Where(a => a.IdRol == rol).ToList();
                            if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                            {
                                datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Usuarios))
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.Usuario1.Contains(Usuarios)).ToList();
                
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Clave))
                    {
                        datos = datos.Where(a => a.Clave.Contains(Clave)).ToList();
                    if (rol != 0)
                    {
                        datos = datos.Where(a => a.IdRol == rol).ToList();
                        if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                        {
                            datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Clave))
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.Clave.Contains(Clave)).ToList();

                if (rol != 0)
                {
                    datos = datos.Where(a => a.IdRol == rol).ToList();
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                    {
                        datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                    }
                }
            }
            else if (rol != 0)
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.IdRol==(rol)).ToList();
                    if (datos.Count > 1 && !String.IsNullOrEmpty(Estado))
                    {
                        datos = datos.Where(a => a.CodEstado.Contains(Estado)).ToList();
                    }
            }
            else if (!String.IsNullOrEmpty(Estado))
            {
                datos = contexto.Usuarios.AsNoTracking().Where(a => a.CodEstado.Contains(Estado)).ToList();
            }
            else
            {
                return contexto.Usuarios.AsNoTracking().ToList();
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
        public InfoCompartidaCapas Crear(Usuario datos)
        {
            try
            {
                contexto.Usuarios.Add(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {datos.Usuario1}" };
            }
        }
        public InfoCompartidaCapas Crear(List<Usuario> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Usuarios.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(Usuario datos)
        {
            try
            {
                contexto.Usuarios.Attach(datos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {datos.Usuario1}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<Usuario> datos)
        {
            try
            {
                foreach (var item in datos)
                {
                    contexto.Usuarios.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(Usuario datos)
        {
            try
            {
                contexto.Usuarios.Remove(datos);
                return new InfoCompartidaCapas() { informacion = datos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {datos.Usuario1}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}

