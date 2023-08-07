using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMEvento : IDisposable
    {

        private EventosContext contexto { get; set; }
        public DMEvento(EventosContext contexto)
        {
            this.contexto = contexto;
        }

        public List<SaEvento> Obtener(int CodEvento = 0, int CodSalon=0, int Codcliente = 0, string descripcionEvento = ""
            , DateTime fecha = new DateTime(), string observaciones = "", string codestado = "")
        {
            List<SaEvento> clientes = new List<SaEvento>();
            if (CodEvento != 0)
            {
                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.CodEvento == (CodEvento)).ToList();
                if (CodSalon != 0)
                {
                    clientes = clientes.Where(a => a.CodSalon == (CodSalon)).ToList();
                    if (Codcliente != 0)
                    {
                        clientes = clientes.Where(a => a.CodCliente == (Codcliente)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(descripcionEvento))
                        {
                            clientes = clientes.Where(a => a.DesEvento.Contains(descripcionEvento)).ToList();
                            if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                            {
                                clientes = clientes.Where(a => a.Fecha == fecha).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(observaciones))
                                {
                                    clientes = clientes.Where(a => a.Observaciones.Contains(observaciones)).ToList();
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
            else if (CodSalon != 0)
            {
                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.CodSalon == (CodSalon)).ToList();
                if (Codcliente != 0)
                {
                    clientes = clientes.Where(a => a.CodCliente == (Codcliente)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(descripcionEvento))
                    {
                        clientes = clientes.Where(a => a.DesEvento.Contains(descripcionEvento)).ToList();
                        if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                        {
                            clientes = clientes.Where(a => a.Fecha == fecha).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(observaciones))
                            {
                                clientes = clientes.Where(a => a.Observaciones.Contains(observaciones)).ToList();
                                if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                                {
                                    clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                                }

                            }
                        }
                    }
                }
            }
            else if (Codcliente != 0)
            {
                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.CodCliente == (Codcliente)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(descripcionEvento))
                {
                    clientes = clientes.Where(a => a.DesEvento.Contains(descripcionEvento)).ToList();
                    if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                    {
                        clientes = clientes.Where(a => a.Fecha == fecha).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(observaciones))
                        {
                            clientes = clientes.Where(a => a.Observaciones.Contains(observaciones)).ToList();
                            if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            }

                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(descripcionEvento))
            {

                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.DesEvento.Contains(descripcionEvento)).ToList();
                if (clientes.Count > 1 && fecha > new DateTime(1900, 01, 01))
                {
                    clientes = clientes.Where(a => a.Fecha == fecha).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(observaciones))
                    {
                        clientes = clientes.Where(a => a.Observaciones.Contains(observaciones)).ToList();
                        if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(observaciones))
            {
                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.Observaciones.Contains(observaciones)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                }
            }
            else if (fecha > new DateTime(1900, 01, 01))
            {

                clientes = contexto.SaEventos.AsNoTracking().Where(a => a.Fecha>= fecha).ToList();

                if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                }
            }

            else
            {
                return contexto.SaEventos.AsNoTracking().ToList();
            }
            return clientes;


        }

        public InfoCompartidaCapas Crear(SaEvento evento)
        {
            try
            {
                contexto.SaEventos.Add(evento);
                return new InfoCompartidaCapas() { informacion = evento };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {evento.CodEvento}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvento> eventos)
        {
            try
            {
                foreach (var item in eventos)
                {
                    contexto.SaEventos.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = eventos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvento evento)
        {
            try
            {
                contexto.SaEventos.Attach(evento).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = evento };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {evento.CodEvento}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvento> eventos)
        {
            try
            {
                foreach (var item in eventos)
                {
                    contexto.SaEventos.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = eventos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvento evento)
        {
            try
            {
                contexto.SaEventos.Remove(evento);
                return new InfoCompartidaCapas() { informacion = evento };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {evento.CodEvento}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
    }
}

