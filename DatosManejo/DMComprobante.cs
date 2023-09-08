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
    public class DMComprobante:IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMComprobante(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<SaEveTipoComprobante> Obtener(int Cod = 0, string Des= "", string CodEstado = "")
        {
            List<SaEveTipoComprobante> comprobantes = new List<SaEveTipoComprobante>();
            if (Cod != 0)
            {
                comprobantes = contexto.SaEveTipoComprobantes.AsNoTracking().Where(a => a.CodComprobante == Cod).ToList();

                if (comprobantes.Count > 1 && !String.IsNullOrEmpty(Des))
                {
                    comprobantes = comprobantes.Where(a => a.DesComprobante.Contains(Des)).ToList();
                    if (comprobantes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        comprobantes = comprobantes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Des))
            {
                comprobantes = contexto.SaEveTipoComprobantes.AsNoTracking().Where(a => a.DesComprobante.Contains(Des)).ToList();
                if (comprobantes.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    comprobantes = comprobantes.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEveTipoComprobantes.AsNoTracking().ToList();
            }
            return comprobantes;
        }
        public int ObtenerCodigo(string descripcion)
        {
            return contexto.SaEveTipoComprobantes.Where(a => a.DesComprobante == descripcion).FirstOrDefault().CodComprobante;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEveTipoComprobantes.Where(a => a.CodComprobante == cod).FirstOrDefault().DesComprobante;
        }
        public InfoCompartidaCapas Crear(SaEveTipoComprobante comp)
        {
            try
            {
                contexto.SaEveTipoComprobantes.Add(comp);
                return new InfoCompartidaCapas() { informacion = comp };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {comp.DesComprobante}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEveTipoComprobante> comp)
        {
            try
            {
                foreach (var item in comp)
                {
                    contexto.SaEveTipoComprobantes.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = comp };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEveTipoComprobante comp)
        {
            try
            {
                contexto.SaEveTipoComprobantes.Attach(comp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = comp };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {comp.DesComprobante}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEveTipoComprobante> comp)
        {
            try
            {
                foreach (var item in comp)
                {
                    contexto.SaEveTipoComprobantes.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = comp };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveTipoComprobante comp)
        {
            try
            {
                contexto.SaEveTipoComprobantes.Remove(comp);
                return new InfoCompartidaCapas() { informacion = comp };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {comp.DesComprobante}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
