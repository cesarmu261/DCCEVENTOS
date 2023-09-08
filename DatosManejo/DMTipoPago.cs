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
    public class DMTipoPago :IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMTipoPago(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public List<SaEveTipoPago> Obtener(int Cod = 0, string Des = "", string CodEstado = "")
        {
            List<SaEveTipoPago> pago = new List<SaEveTipoPago>();
            if (Cod != 0)
            {
                pago = contexto.SaEveTipoPagos.AsNoTracking().Where(a => a.CodPago == Cod).ToList();

                if (pago.Count > 1 && !String.IsNullOrEmpty(Des))
                {
                    pago = pago.Where(a => a.DesPago.Contains(Des)).ToList();
                    if (pago.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                    {
                        pago = pago.Where(a => a.DesPago.Contains(CodEstado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Des))
            {
                pago = contexto.SaEveTipoPagos.AsNoTracking().Where(a => a.DesPago.Contains(Des)).ToList();
                if (pago.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    pago = pago.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                }
            }
            else
            {
                return contexto.SaEveTipoPagos.AsNoTracking().ToList();
            }
            return pago;
        }
        public int? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEveTipoPagos.Where(a => a.DesPago == descripcion).FirstOrDefault().CodPago;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEveTipoPagos.Where(a => a.CodPago == cod).FirstOrDefault().DesPago;
        }
        public InfoCompartidaCapas Crear(SaEveTipoPago pago)
        {
            try
            {
                contexto.SaEveTipoPagos.Add(pago);
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {pago.DesPago}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEveTipoPago> pago)
        {
            try
            {
                foreach (var item in pago)
                {
                    contexto.SaEveTipoPagos.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEveTipoPago pago)
        {
            try
            {
                contexto.SaEveTipoPagos.Attach(pago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {pago.DesPago}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEveTipoPago > pagos)
        {
            try
            {
                foreach (var item in pagos)
                {
                    contexto.SaEveTipoPagos.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = pagos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveTipoPago pago)
        {
            try
            {
                contexto.SaEveTipoPagos.Remove(pago);
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {pago.DesPago}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
