using Datos;
using Entidades;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMPaquete
    {
        private EventosContext contexto { get; set; }
        public DMPaquete(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<SaEvePaquete> Obtener(int CodPaquete = 0, string DesPaquete = "", string CodEstado = "")
        {
            List<SaEvePaquete> categoria = new List<SaEvePaquete>();
            if (CodPaquete != 0)
            {
                categoria = contexto.SaEvePaquetes.AsNoTracking().Where(a => a.CodPaquete == CodPaquete).ToList();

                if (categoria.Count > 1 && !String.IsNullOrEmpty(DesPaquete))
                {
                    categoria = categoria.Where(a => a.DesPaquete.Contains(DesPaquete)).ToList();
                    if (categoria.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        categoria = categoria.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(DesPaquete))
            {
                categoria = categoria.Where(a => a.DesPaquete.Contains(DesPaquete)).ToList();
                if (categoria.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    categoria = categoria.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEvePaquetes.AsNoTracking().ToList();
            }
            return categoria;
        }
        public decimal? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEvePaquetes.Where(a => a.DesPaquete == descripcion).FirstOrDefault().CodPaquete;
        }
        public InfoCompartidaCapas Crear(SaEvePaquete paquetes)
        {
            try
            {
                contexto.SaEvePaquetes.Add(paquetes);
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {paquetes.DesPaquete}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvePaquete> paquetes)
        {
            try
            {
                foreach (var item in paquetes)
                {
                    contexto.SaEvePaquetes.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvePaquete paquetes)
        {
            try
            {
                contexto.SaEvePaquetes.Attach(paquetes).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {paquetes.DesPaquete}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvePaquete> paquetes)
        {
            try
            {
                foreach (var item in paquetes)
                {
                    contexto.SaEvePaquetes.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvePaquete paquetes)
        {
            try
            {
                contexto.SaEvePaquetes.Remove(paquetes);
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {paquetes.DesPaquete}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}

