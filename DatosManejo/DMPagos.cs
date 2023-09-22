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
    public class DMPagos : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMPagos(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public int? ObtenerUltimoCodigo()
        {
            int? ultimoCodigoEvento = contexto.SaEvePagos.Max(a => a.CodPagos);
            return ultimoCodigoEvento;
        }
        public List<SaEvePago> Obtener(int Codpagos = 0, int CodEvento = 0, int codtransa = 0
            , DateTime fechadepago = new DateTime(), DateTime fechadefact = new DateTime(), string codestado = ""
            , string obseve = "", int codcomprobante = 0, int codpago = 0, string referencia = ""
            , int recibo = 0, string obspago = "", decimal montosapagar = 0)
        {
            List<SaEvePago> pago = new List<SaEvePago>();
            if (Codpagos != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodPagos == Codpagos).ToList();

                    if (CodEvento != 0)
                    {
                        pago = pago.Where(a => a.CodEvento == (CodEvento)).ToList();
                        if (codtransa != 0)
                        {
                            pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                            if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                            {
                                pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();
                                if (pago.Count > 1 && fechadefact > new DateTime(1900, 01, 01))
                                {
                                    pago = pago.Where(a => a.FechaDeFactura == fechadefact).ToList();
                                    if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                                    {
                                        pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                                        if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                                        {
                                            pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                            if (codcomprobante != 0)
                                            {
                                                pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                                if (codpago != 0)
                                                {
                                                    pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                                    if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                                    {
                                                        pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                                        if (recibo != 0)
                                                        {
                                                            pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                            if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                            {
                                                                pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                                if (montosapagar != 0)
                                                                {
                                                                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                }
            }
            else if (CodEvento != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodEvento == CodEvento).ToList();
                if (codtransa != 0)
                {
                    pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                    if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                    {
                        pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();
                        if (pago.Count > 1 && fechadefact > new DateTime(1900, 01, 01))
                        {
                            pago = pago.Where(a => a.FechaDeFactura == fechadefact).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                                if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                                {
                                    pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                    if (codcomprobante != 0)
                                    {
                                        pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                        if (codpago != 0)
                                        {
                                            pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                            {
                                                pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                                if (recibo != 0)
                                                {
                                                    pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                    if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                    {
                                                        pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                        if (montosapagar != 0)
                                                        {
                                                            pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else if (codtransa != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodTipoTransaccion == (codtransa)).ToList();

                if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                {
                    pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();
                    if (pago.Count > 1 && fechadefact > new DateTime(1900, 01, 01))
                    {
                        pago = pago.Where(a => a.FechaDeFactura == fechadefact).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                            {
                                pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                if (codcomprobante != 0)
                                {
                                    pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                    if (codpago != 0)
                                    {
                                        pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                        if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                        {
                                            pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                            if (recibo != 0)
                                            {
                                                pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                {
                                                    pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                    if (montosapagar != 0)
                                                    {
                                                        pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (fechadepago! > new DateTime(1900, 01, 01))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.FechaDePago >= fechadepago).ToList();
                if (pago.Count > 1 && fechadefact > new DateTime(1900, 01, 01))
                {
                    pago = pago.Where(a => a.FechaDeFactura == fechadefact).ToList();
                    if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                        {
                            pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                            if (codcomprobante != 0)
                            {
                                pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                if (codpago != 0)
                                {
                                    pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                    if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                    {
                                        pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                        if (recibo != 0)
                                        {
                                            pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                            {
                                                pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                if (montosapagar != 0)
                                                {
                                                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (fechadefact! > new DateTime(1900, 01, 01))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.FechaDeFactura >= fechadefact).ToList();

                if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                    if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                    {
                        pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                        if (codcomprobante != 0)
                        {
                            pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                            if (codpago != 0)
                            {
                                pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                {
                                    pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                    if (recibo != 0)
                                    {
                                        pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                        if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                        {
                                            pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                            if (montosapagar != 0)
                                            {
                                                pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(codestado))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodEstado.Contains(codestado)).ToList();
                if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                {
                    pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                    if (codcomprobante != 0)
                    {
                        pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                        if (codpago != 0)
                        {
                            pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                            {
                                pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                if (recibo != 0)
                                {
                                    pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                    if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                    {
                                        pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                        if (montosapagar != 0)
                                        {
                                            pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(obseve))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.Observacion.Contains(obseve)).ToList();
                if (codcomprobante != 0)
                {
                    pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                    if (codpago != 0)
                    {
                        pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                        {
                            pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                            if (recibo != 0)
                            {
                                pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                {
                                    pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                    if (montosapagar != 0)
                                    {
                                        pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (codcomprobante != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodComprobante == (codcomprobante)).ToList();
                if (codpago != 0)
                {
                    pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                    if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                    {
                        pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                        if (recibo != 0)
                        {
                            pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                            {
                                pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                if (montosapagar != 0)
                                {
                                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                }
                            }
                        }
                    }
                }
            }
            else if (codpago != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodPago == (codpago)).ToList();

                if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                {
                    pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                    if (recibo != 0)
                    {
                        pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                        {
                            pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                            if (montosapagar != 0)
                            {
                                pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                            }
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(referencia))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.Referencia.Contains(referencia)).ToList();

                if (recibo != 0)
                {
                    pago = pago.Where(a => a.CodPago == (recibo)).ToList();
                    if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                    {
                        pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                        if (montosapagar != 0)
                        {
                            pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                        }
                    }
                }
            }
            else if ((recibo != 0))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.Recibo == (recibo)).ToList();
                if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                {
                    pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                    if (montosapagar != 0)
                    {
                        pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(obspago))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.Referencia.Contains(obspago)).ToList();

                if (montosapagar != 0)
                {
                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                }

            }
            else
            {
                return contexto.SaEvePagos.AsNoTracking().ToList();
            }
            return pago;
        }
        public List<SaEvePago> Obtener2(int Codpagos = 0, int CodEvento = 0, int codtransa = 0
            , DateTime fechadepago = new DateTime(), string codestado = ""
            , string obseve = "", int codcomprobante = 0, int codpago = 0, string referencia = ""
            , int recibo = 0, string obspago = "", decimal montosapagar = 0)
        {
            List<SaEvePago> pago = new List<SaEvePago>();
            if (Codpagos != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodPagos == Codpagos).ToList();

                if (CodEvento != 0)
                {
                    pago = pago.Where(a => a.CodEvento == (CodEvento)).ToList();
                    if (codtransa != 0)
                    {
                        pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                        if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                        {
                            pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();

                            if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                                if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                                {
                                    pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                    if (codcomprobante != 0)
                                    {
                                        pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                        if (codpago != 0)
                                        {
                                            pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                            {
                                                pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                                if (recibo != 0)
                                                {
                                                    pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                    if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                    {
                                                        pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                        if (montosapagar != 0)
                                                        {
                                                            pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (CodEvento != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodEvento == CodEvento).ToList();
                if (codtransa != 0)
                {
                    pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                    if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                    {
                        pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                            {
                                pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                if (codcomprobante != 0)
                                {
                                    pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                    if (codpago != 0)
                                    {
                                        pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                        if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                        {
                                            pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                            if (recibo != 0)
                                            {
                                                pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                {
                                                    pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                    if (montosapagar != 0)
                                                    {
                                                        pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (codtransa != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodTipoTransaccion == (codtransa)).ToList();

                if (pago.Count > 1 && fechadepago > new DateTime(1900, 01, 01))
                {
                    pago = pago.Where(a => a.FechaDePago == fechadepago).ToList();

                    if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                        {
                            pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                            if (codcomprobante != 0)
                            {
                                pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                if (codpago != 0)
                                {
                                    pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                    if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                    {
                                        pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                        if (recibo != 0)
                                        {
                                            pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                            {
                                                pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                if (montosapagar != 0)
                                                {
                                                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (fechadepago! == new DateTime(1900, 01, 01))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.FechaDePago >= fechadepago).ToList();
                
            }
            else
            {
                return contexto.SaEvePagos.AsNoTracking().ToList();
            }
            return pago;
        }
        public List<SaEvePago> Obtener3(int Codpagos = 0, int CodEvento = 0, int codtransa = 0
            , DateTime fechacancelacion = new DateTime(), string codestado = ""
            , string obseve = "", int codcomprobante = 0, int codpago = 0, string referencia = ""
            , int recibo = 0, string obspago = "", decimal montosapagar = 0)
        {
            List<SaEvePago> pago = new List<SaEvePago>();
            if (Codpagos != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodPagos == Codpagos).ToList();

                if (CodEvento != 0)
                {
                    pago = pago.Where(a => a.CodEvento == (CodEvento)).ToList();
                    if (codtransa != 0)
                    {
                        pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                        if (pago.Count > 1 && fechacancelacion > new DateTime(1900, 01, 01))
                        {
                            pago = pago.Where(a => a.FechaDePago == fechacancelacion).ToList();

                            if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                                if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                                {
                                    pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                    if (codcomprobante != 0)
                                    {
                                        pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                        if (codpago != 0)
                                        {
                                            pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                            {
                                                pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                                if (recibo != 0)
                                                {
                                                    pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                    if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                    {
                                                        pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                        if (montosapagar != 0)
                                                        {
                                                            pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (CodEvento != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodEvento == CodEvento).ToList();
                if (codtransa != 0)
                {
                    pago = pago.Where(a => a.CodTipoTransaccion == (codtransa)).ToList();
                    if (pago.Count > 1 && fechacancelacion > new DateTime(1900, 01, 01))
                    {
                        pago = pago.Where(a => a.FechaDePago == fechacancelacion).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                            {
                                pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                                if (codcomprobante != 0)
                                {
                                    pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                    if (codpago != 0)
                                    {
                                        pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                        if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                        {
                                            pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                            if (recibo != 0)
                                            {
                                                pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                                if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                                {
                                                    pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                    if (montosapagar != 0)
                                                    {
                                                        pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (codtransa != 0)
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.CodTipoTransaccion == (codtransa)).ToList();

                if (pago.Count > 1 && fechacancelacion > new DateTime(1900, 01, 01))
                {
                    pago = pago.Where(a => a.FechaDePago == fechacancelacion).ToList();

                    if (pago.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        pago = pago.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        if (pago.Count > 1 && !String.IsNullOrEmpty(obseve))
                        {
                            pago = pago.Where(a => a.Observacion.Contains(obseve)).ToList();
                            if (codcomprobante != 0)
                            {
                                pago = pago.Where(a => a.CodComprobante == (codcomprobante)).ToList();
                                if (codpago != 0)
                                {
                                    pago = pago.Where(a => a.CodPago == (codpago)).ToList();
                                    if (pago.Count > 1 && !String.IsNullOrEmpty(referencia))
                                    {
                                        pago = pago.Where(a => a.Referencia.Contains(referencia)).ToList();
                                        if (recibo != 0)
                                        {
                                            pago = pago.Where(a => a.Recibo == (recibo)).ToList();
                                            if (pago.Count > 1 && !String.IsNullOrEmpty(obspago))
                                            {
                                                pago = pago.Where(a => a.Observacionpago.Contains(obspago)).ToList();
                                                if (montosapagar != 0)
                                                {
                                                    pago = pago.Where(a => a.Montoapagar == (montosapagar)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (fechacancelacion! == new DateTime(1900, 01, 01))
            {
                pago = contexto.SaEvePagos.AsNoTracking().Where(a => a.FechaDeCancelacion >= fechacancelacion).ToList();

            }
            else
            {
                return contexto.SaEvePagos.AsNoTracking().ToList();
            }
            return pago;
        }

        public InfoCompartidaCapas Crear(SaEvePago pago)
        {
            try
            {
                contexto.SaEvePagos.Add(pago);
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {pago.CodPagos}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvePago> pago)
        {
            try
            {
                foreach (var item in pago)
                {
                    contexto.SaEvePagos.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvePago pago)
        {
            try
            {
                contexto.SaEvePagos.Attach(pago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {pago.CodPagos}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvePago> pagos)
        {
            try
            {
                foreach (var item in pagos)
                {
                    contexto.SaEvePagos.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = pagos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvePago pago)
        {
            try
            {
                contexto.SaEvePagos.Remove(pago);
                return new InfoCompartidaCapas() { informacion = pago };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {pago.CodPagos}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}
    
