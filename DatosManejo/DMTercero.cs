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
    public class DMTercero : IDisposable
    {

        private CuotasV100Context contexto { get; set; }
        public DMTercero(CuotasV100Context contexto)
        {
            this.contexto = contexto;
        }
        public List<SaTercero> Obtener(string codCliente = "", string nomcliente = "", string domicilio = ""
            , string poblacion = "", string cp = "", string telefono = "", string celular = "", string correo = ""
            , string razonsocial = "", string rfc = "", string domiciliofiscal = "", string poblacionfiscal = ""
            , string cpfiscal = "", DateTime fecha = new DateTime(), DateTime fecharegistro = new DateTime()
            , string codregimenfiscal = "", string codestado = "")
        {
            List<SaTercero> clientes = new List<SaTercero>();
            if (!String.IsNullOrEmpty(codCliente))
            {
                clientes = contexto.SaTerceros.AsNoTracking().Where(a => a.CodTercero == (codCliente)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(nomcliente))
                {
                    clientes = clientes.Where(a => a.NomTercero.Contains(nomcliente)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(domicilio))
                    {
                        clientes = clientes.Where(a => a.Domicilio.Contains(domicilio)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacion))
                        {
                            clientes = clientes.Where(a => a.Poblacion == (poblacion)).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(cp))
                            {
                                clientes = clientes.Where(a => a.Cp.Contains(cp)).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(telefono))
                                {
                                    clientes = clientes.Where(a => a.Telefono.Contains(telefono)).ToList();
                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(celular))
                                    {
                                        clientes = clientes.Where(a => a.Celular.Contains(celular)).ToList();
                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(correo))
                                        {
                                            clientes = clientes.Where(a => a.Correo.Contains(correo)).ToList();
                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(razonsocial))
                                            {
                                                clientes = clientes.Where(a => a.RazonSocial.Contains(razonsocial)).ToList();
                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(rfc))
                                                {
                                                    clientes = clientes.Where(a => a.Rfc.Contains(rfc)).ToList();
                                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(domiciliofiscal))
                                                    {
                                                        clientes = clientes.Where(a => a.DomicioFiscal.Contains(domiciliofiscal)).ToList();
                                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacionfiscal))
                                                        {
                                                            clientes = clientes.Where(a => a.PoblacionFiscal.Contains(poblacionfiscal)).ToList();
                                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(cpfiscal))
                                                            {
                                                                clientes = clientes.Where(a => a.CpFiscal.Contains(cpfiscal)).ToList();
                                                                if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                                                                {
                                                                    clientes = clientes.Where(a => a.FecNacimiento == fecha).ToList();
                                                                    if (clientes.Count > 1 && fecharegistro > new DateTime(1900, 01, 01))
                                                                    {
                                                                        clientes = clientes.Where(a => a.FecRegistro == fecharegistro).ToList();
                                                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(codregimenfiscal))
                                                                        {
                                                                            clientes = clientes.Where(a => a.Extra04.Contains(codregimenfiscal)).ToList();
                                                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                                                                            {
                                                                                clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
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
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(nomcliente))
            {
                clientes = contexto.SaTerceros.AsNoTracking().Where(a => a.NomTercero.Contains(nomcliente)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(domicilio))
                {
                    clientes = clientes.Where(a => a.Domicilio.Contains(domicilio)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacion))
                    {
                        clientes = clientes.Where(a => a.Poblacion == (poblacion)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(cp))
                        {
                            clientes = clientes.Where(a => a.Cp.Contains(cp)).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(telefono))
                            {
                                clientes = clientes.Where(a => a.Telefono.Contains(telefono)).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(celular))
                                {
                                    clientes = clientes.Where(a => a.Celular.Contains(celular)).ToList();
                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(correo))
                                    {
                                        clientes = clientes.Where(a => a.Correo.Contains(correo)).ToList();
                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(razonsocial))
                                        {
                                            clientes = clientes.Where(a => a.RazonSocial.Contains(razonsocial)).ToList();
                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(rfc))
                                            {
                                                clientes = clientes.Where(a => a.Rfc.Contains(rfc)).ToList();
                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(domiciliofiscal))
                                                {
                                                    clientes = clientes.Where(a => a.DomicioFiscal.Contains(domiciliofiscal)).ToList();
                                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacionfiscal))
                                                    {
                                                        clientes = clientes.Where(a => a.PoblacionFiscal.Contains(poblacionfiscal)).ToList();
                                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(cpfiscal))
                                                        {
                                                            clientes = clientes.Where(a => a.CpFiscal.Contains(cpfiscal)).ToList();
                                                            if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                                                            {
                                                                clientes = clientes.Where(a => a.FecNacimiento == fecha).ToList();
                                                                if (clientes.Count > 1 && fecharegistro > new DateTime(1900, 01, 01))
                                                                {
                                                                    clientes = clientes.Where(a => a.FecRegistro == fecharegistro).ToList();
                                                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(codregimenfiscal))
                                                                    {
                                                                        clientes = clientes.Where(a => a.Extra04.Contains(codregimenfiscal)).ToList();
                                                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                                                                        {
                                                                            clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
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
                    }
                }
            }
            else if (!String.IsNullOrEmpty(domicilio))
            {
                clientes = contexto.SaTerceros.AsNoTracking().Where(a => a.Domicilio.Contains(domicilio)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacion))
                {
                    clientes = clientes.Where(a => a.Poblacion == (poblacion)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(cp))
                    {
                        clientes = clientes.Where(a => a.Cp.Contains(cp)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(telefono))
                        {
                            clientes = clientes.Where(a => a.Telefono.Contains(telefono)).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(celular))
                            {
                                clientes = clientes.Where(a => a.Celular.Contains(celular)).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(correo))
                                {
                                    clientes = clientes.Where(a => a.Correo.Contains(correo)).ToList();
                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(razonsocial))
                                    {
                                        clientes = clientes.Where(a => a.RazonSocial.Contains(razonsocial)).ToList();
                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(rfc))
                                        {
                                            clientes = clientes.Where(a => a.Rfc.Contains(rfc)).ToList();
                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(domiciliofiscal))
                                            {
                                                clientes = clientes.Where(a => a.DomicioFiscal.Contains(domiciliofiscal)).ToList();
                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacionfiscal))
                                                {
                                                    clientes = clientes.Where(a => a.PoblacionFiscal.Contains(poblacionfiscal)).ToList();
                                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(cpfiscal))
                                                    {
                                                        clientes = clientes.Where(a => a.CpFiscal.Contains(cpfiscal)).ToList();
                                                        if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                                                        {
                                                            clientes = clientes.Where(a => a.FecNacimiento == fecha).ToList();
                                                            if (clientes.Count > 1 && fecharegistro > new DateTime(1900, 01, 01))
                                                            {
                                                                clientes = clientes.Where(a => a.FecRegistro == fecharegistro).ToList();
                                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(codregimenfiscal))
                                                                {
                                                                    clientes = clientes.Where(a => a.Extra04.Contains(codregimenfiscal)).ToList();
                                                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                                                                    {
                                                                        clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
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
                }
            }
            else if (!String.IsNullOrEmpty(poblacion))
            {

                clientes = contexto.SaTerceros.AsNoTracking().Where(a => a.Poblacion == (poblacion)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(cp))
                {
                    clientes = clientes.Where(a => a.Cp.Contains(cp)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(telefono))
                    {
                        clientes = clientes.Where(a => a.Telefono.Contains(telefono)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(celular))
                        {
                            clientes = clientes.Where(a => a.Celular.Contains(celular)).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(correo))
                            {
                                clientes = clientes.Where(a => a.Correo.Contains(correo)).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(razonsocial))
                                {
                                    clientes = clientes.Where(a => a.RazonSocial.Contains(razonsocial)).ToList();
                                    if (clientes.Count > 1 && !String.IsNullOrEmpty(rfc))
                                    {
                                        clientes = clientes.Where(a => a.Rfc.Contains(rfc)).ToList();
                                        if (clientes.Count > 1 && !String.IsNullOrEmpty(domiciliofiscal))
                                        {
                                            clientes = clientes.Where(a => a.DomicioFiscal.Contains(domiciliofiscal)).ToList();
                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(poblacionfiscal))
                                            {
                                                clientes = clientes.Where(a => a.PoblacionFiscal.Contains(poblacionfiscal)).ToList();
                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(cpfiscal))
                                                {
                                                    clientes = clientes.Where(a => a.CpFiscal.Contains(cpfiscal)).ToList();
                                                    if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                                                    {
                                                        clientes = clientes.Where(a => a.FecNacimiento == fecha).ToList();
                                                        if (clientes.Count > 1 && fecharegistro > new DateTime(1900, 01, 01))
                                                        {
                                                            clientes = clientes.Where(a => a.FecRegistro == fecharegistro).ToList();
                                                            if (clientes.Count > 1 && !String.IsNullOrEmpty(codregimenfiscal))
                                                            {
                                                                clientes = clientes.Where(a => a.Extra04.Contains(codregimenfiscal)).ToList();
                                                                if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                                                                {
                                                                    clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
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
            }


            else
            {
                return contexto.SaTerceros.AsNoTracking().ToList();
            }
            return clientes;
        }



        public InfoCompartidaCapas Crear(SaTercero cliente)
        {
            try
            {
                contexto.SaTerceros.Add(cliente);
                return new InfoCompartidaCapas() { informacion = cliente };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {cliente.CodCliente}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaTercero> cliente)
        {
            try
            {
                foreach (var item in cliente)
                {
                    contexto.SaTerceros.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = cliente };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaTercero cliente)
        {
            try
            {
                contexto.SaTerceros.Attach(cliente).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = cliente };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {cliente.CodCliente}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaTercero> clientes)
        {
            try
            {
                foreach (var item in clientes)
                {
                    contexto.SaTerceros.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = clientes };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaTercero cliente)
        {
            try
            {
                contexto.SaTerceros.Remove(cliente);
                return new InfoCompartidaCapas() { informacion = cliente };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {cliente.CodCliente}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}

