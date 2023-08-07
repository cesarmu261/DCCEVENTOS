using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMPaDetalle : IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMPaDetalle(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public int? ObtenerUltimoCodigo()
        {
            int? ultimoCodigoEvento = contexto.SaEvePaqueteDetalles.Max(a => a.CodDp);
            return ultimoCodigoEvento + 1;
        }
        public List<SaEvePaqueteDetalle> Obtener(int coddetallepaq = 0, int coddp = 0, int codpaquete = 0, int codconceptos = 0, string codestado = "")
        {
            List<SaEvePaqueteDetalle> porcentajes = new List<SaEvePaqueteDetalle>();
            if (coddetallepaq != 0)
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodDetallepaq == coddetallepaq).ToList();
                if (porcentajes.Count > 1 && (coddp != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodDp == (coddp)).ToList();
                    if (porcentajes.Count > 1 && (codpaquete != 0))
                    {
                        porcentajes = porcentajes.Where(a => a.CodPaquete == (codpaquete)).ToList();
                        if (porcentajes.Count > 1 && (codconceptos != 0))
                        {
                            porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            }
                        }
                    }
                }
            }
            else if ((coddp != 0))
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodDp == (coddp)).ToList();
                if (porcentajes.Count > 1 && (codpaquete != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodPaquete == (codpaquete)).ToList();
                    if (porcentajes.Count > 1 && (codconceptos != 0))
                    {
                        porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                        if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        }
                    }
                }
            }


            else if (codpaquete != 0)
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodPaquete == (codpaquete)).ToList();
                if (porcentajes.Count > 1 && (codconceptos != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                    if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                    }
                }
            }

            else if (codconceptos != 0)
            {

                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodConceptos == (codconceptos)).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                }

            }
            else
            {
                return contexto.SaEvePaqueteDetalles.AsNoTracking().ToList();
            }
            return porcentajes;
        }
        public List<SaEvePaqueteDetalle> Obtener2(int codpaquete = 0, int coddetallepaq = 0, int coddp = 0, int codconceptos = 0, string codestado = "")
        {
            List<SaEvePaqueteDetalle> porcentajes = new List<SaEvePaqueteDetalle>();
            if (coddetallepaq != 0)
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodDetallepaq == coddetallepaq).ToList();
                if (porcentajes.Count > 1 && (coddp != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodDp == (coddp)).ToList();
                    if (porcentajes.Count > 1 && (codpaquete != 0))
                    {
                        porcentajes = porcentajes.Where(a => a.CodPaquete == (codpaquete)).ToList();
                        if (porcentajes.Count > 1 && (codconceptos != 0))
                        {
                            porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                            {
                                porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                            }
                        }
                    }
                }
            }
            else if ((coddp != 0))
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodDp == (coddp)).ToList();
                if (porcentajes.Count > 1 && (codpaquete != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodPaquete == (codpaquete)).ToList();
                    if (porcentajes.Count > 1 && (codconceptos != 0))
                    {
                        porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                        if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        }
                    }
                }
            }


            else if (codpaquete != 0)
            {
                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodPaquete == (codpaquete)).ToList();
                if (porcentajes.Count > 1 && (codconceptos != 0))
                {
                    porcentajes = porcentajes.Where(a => a.CodConceptos == (codconceptos)).ToList();
                    if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                    }
                }
            }

            else if (codconceptos != 0)
            {

                porcentajes = contexto.SaEvePaqueteDetalles.AsNoTracking().Where(a => a.CodConceptos == (codconceptos)).ToList();
                if (porcentajes.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    porcentajes = porcentajes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                }

            }
            else
            {
                return contexto.SaEvePaqueteDetalles.AsNoTracking().ToList();
            }
            return porcentajes;
        }


        public InfoCompartidaCapas Crear(SaEvePaqueteDetalle paquetes)
        {
            try
            {
                contexto.SaEvePaqueteDetalles.Add(paquetes);
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {paquetes.CodDp}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvePaqueteDetalle> paquetes)
        {
            try
            {
                foreach (var item in paquetes)
                {
                    contexto.SaEvePaqueteDetalles.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvePaqueteDetalle paquetes)
        {
            try
            {
                contexto.SaEvePaqueteDetalles.Attach(paquetes).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {paquetes.CodDp}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvePaqueteDetalle> paquetes)
        {
            try
            {
                foreach (var item in paquetes)
                {
                    contexto.SaEvePaqueteDetalles.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvePaqueteDetalle paquetes)
        {
            try
            {
                contexto.SaEvePaqueteDetalles.Remove(paquetes);
                return new InfoCompartidaCapas() { informacion = paquetes };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {paquetes.CodDp}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }

    }
}
