using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMEventoDetalle
    {
        private EventosContext contexto { get; set; }
        public DMEventoDetalle(EventosContext contexto)
        {
            this.contexto = contexto;
        }
        public int? ObtenerUltimoCodigoEvento()
        {
            int? ultimoCodigoEvento = contexto.SaEventos.Max(a => a.CodEvento);
            return ultimoCodigoEvento;
        }
        public List<SaEventoDetalle> Obtener(int coddetalles = 0, int codevento = 0, int coddetallep = 0, int codconceptos = 0
            , decimal costosconceptos = 0, decimal costosprecios = 0, decimal cantidad = 0, int codporcentaje = 0, decimal descuento = 0, decimal costototal = 0)
        {
            List<SaEventoDetalle> ev = new List<SaEventoDetalle>();
            if (coddetalles != 0)
            {
                ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodDetalles == (coddetalles)).ToList();
                if (ev.Count > 1 && (codevento != 0))
                {
                    ev = ev.Where(a => a.CodEvento == (codevento)).ToList();
                    if (ev.Count > 1 && (coddetallep != 0))
                    {
                        ev = ev.Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                        if (ev.Count > 1 && (codconceptos != 0))
                        {
                            ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (ev.Count > 1 && (costosconceptos != 0))
                            {
                                ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                                if (ev.Count > 1 && (costosprecios != 0))
                                {
                                    ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                    if (ev.Count > 1 && (cantidad != 0))
                                    {
                                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                        if (ev.Count > 1 && (codporcentaje != 0))
                                        {
                                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                            if (ev.Count > 1 && (descuento != 0))
                                            {
                                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                                if (ev.Count > 1 && (costototal != 0))
                                                {
                                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

                else if (codevento != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodEvento == (codevento)).ToList();

                    if (ev.Count > 1 && (coddetallep != 0))
                    {
                        ev = ev.Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                        if (ev.Count > 1 && (codconceptos != 0))
                        {
                            ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (ev.Count > 1 && (costosconceptos != 0))
                            {
                                ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                                if (ev.Count > 1 && (costosprecios != 0))
                                {
                                    ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                    if (ev.Count > 1 && (cantidad != 0))
                                    {
                                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                        if (ev.Count > 1 && (codporcentaje != 0))
                                        {
                                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                            if (ev.Count > 1 && (descuento != 0))
                                            {
                                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                                if (ev.Count > 1 && (costototal != 0))
                                                {
                                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }

                }
                else if (coddetallep != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                    if (ev.Count > 1 && (codconceptos != 0))
                    {
                        ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                        if (ev.Count > 1 && (costosconceptos != 0))
                        {
                            ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                            if (ev.Count > 1 && (costosprecios != 0))
                            {
                                ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                if (ev.Count > 1 && (cantidad != 0))
                                {
                                    ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                    if (ev.Count > 1 && (codporcentaje != 0))
                                    {
                                        ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                        if (ev.Count > 1 && (descuento != 0))
                                        {
                                            ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                            if (ev.Count > 1 && (costototal != 0))
                                            {
                                                ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (codconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodConceptos == (codconceptos)).ToList();
                    if (ev.Count > 1 && (costosconceptos != 0))
                    {
                        ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                        if (ev.Count > 1 && (costosprecios != 0))
                        {
                            ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                            if (ev.Count > 1 && (cantidad != 0))
                            {
                                ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                if (ev.Count > 1 && (codporcentaje != 0))
                                {
                                    ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                    if (ev.Count > 1 && (descuento != 0))
                                    {
                                        ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                        if (ev.Count > 1 && (costototal != 0))
                                        {
                                            ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CostosConcepto == (costosconceptos)).ToList();

                    if (ev.Count > 1 && (costosprecios != 0))
                    {
                        ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                        if (ev.Count > 1 && (cantidad != 0))
                        {
                            ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                            if (ev.Count > 1 && (codporcentaje != 0))
                            {
                                ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                if (ev.Count > 1 && (descuento != 0))
                                {
                                    ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                    if (ev.Count > 1 && (costototal != 0))
                                    {
                                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CostosConcepto == (costosconceptos)).ToList();

                    if (ev.Count > 1 && (costosprecios != 0))
                    {
                        ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                        if (ev.Count > 1 && (cantidad != 0))
                        {
                            ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                            if (ev.Count > 1 && (codporcentaje != 0))
                            {
                                ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                if (ev.Count > 1 && (descuento != 0))
                                {
                                    ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                    if (ev.Count > 1 && (costototal != 0))
                                    {
                                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosprecios != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Costoprecio == (costosprecios)).ToList();

                    if (ev.Count > 1 && (cantidad != 0))
                    {
                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                        if (ev.Count > 1 && (codporcentaje != 0))
                        {
                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                            if (ev.Count > 1 && (descuento != 0))
                            {
                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                if (ev.Count > 1 && (costototal != 0))
                                {
                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                }
                            }
                        }
                    }
                }
                else if (cantidad != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Cantidad == (cantidad)).ToList();
                    if (ev.Count > 1 && (codporcentaje != 0))
                    {
                        ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                        if (ev.Count > 1 && (descuento != 0))
                        {
                            ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                            if (ev.Count > 1 && (costototal != 0))
                            {
                                ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                            }
                        }
                    }
                }
                else if (codporcentaje != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                    if (ev.Count > 1 && (descuento != 0))
                    {
                        ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                        if (ev.Count > 1 && (costototal != 0))
                        {
                            ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                        }
                    }
                }
                else if (descuento != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Descuento == (descuento)).ToList();

                    if (ev.Count > 1 && (costototal != 0))
                    {
                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                    }
                }
            }
            else
            {
                return contexto.SaEventoDetalles.AsNoTracking().ToList();
            }
            return ev;
        }
        public List<SaEventoDetalle> Obtener2(int codevento = 0 ,int coddetalles = 0, int coddetallep = 0, int codconceptos = 0
            , decimal costosconceptos = 0, decimal costosprecios = 0, decimal cantidad = 0, int codporcentaje = 0, decimal descuento = 0, decimal costototal = 0)
        {
            List<SaEventoDetalle> ev = new List<SaEventoDetalle>();
            if (codevento != 0)
            {
                ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodEvento == (codevento)).ToList();
                if (ev.Count > 1 && (coddetalles != 0))
                {
                    ev = ev.Where(a => a.CodDetalles == (coddetalles)).ToList();
                    if (ev.Count > 1 && (coddetallep != 0))
                    {
                        ev = ev.Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                        if (ev.Count > 1 && (codconceptos != 0))
                        {
                            ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (ev.Count > 1 && (costosconceptos != 0))
                            {
                                ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                                if (ev.Count > 1 && (costosprecios != 0))
                                {
                                    ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                    if (ev.Count > 1 && (cantidad != 0))
                                    {
                                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                        if (ev.Count > 1 && (codporcentaje != 0))
                                        {
                                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                            if (ev.Count > 1 && (descuento != 0))
                                            {
                                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                                if (ev.Count > 1 && (costototal != 0))
                                                {
                                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

                else if (coddetalles != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodDetalles == (coddetalles)).ToList();

                    if (ev.Count > 1 && (coddetallep != 0))
                    {
                        ev = ev.Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                        if (ev.Count > 1 && (codconceptos != 0))
                        {
                            ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                            if (ev.Count > 1 && (costosconceptos != 0))
                            {
                                ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                                if (ev.Count > 1 && (costosprecios != 0))
                                {
                                    ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                    if (ev.Count > 1 && (cantidad != 0))
                                    {
                                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                        if (ev.Count > 1 && (codporcentaje != 0))
                                        {
                                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                            if (ev.Count > 1 && (descuento != 0))
                                            {
                                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                                if (ev.Count > 1 && (costototal != 0))
                                                {
                                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }

                }
                else if (coddetallep != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodDetallepaq == (coddetallep)).ToList();
                    if (ev.Count > 1 && (codconceptos != 0))
                    {
                        ev = ev.Where(a => a.CodConceptos == (codconceptos)).ToList();
                        if (ev.Count > 1 && (costosconceptos != 0))
                        {
                            ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                            if (ev.Count > 1 && (costosprecios != 0))
                            {
                                ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                                if (ev.Count > 1 && (cantidad != 0))
                                {
                                    ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                    if (ev.Count > 1 && (codporcentaje != 0))
                                    {
                                        ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                        if (ev.Count > 1 && (descuento != 0))
                                        {
                                            ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                            if (ev.Count > 1 && (costototal != 0))
                                            {
                                                ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (codconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodConceptos == (codconceptos)).ToList();
                    if (ev.Count > 1 && (costosconceptos != 0))
                    {
                        ev = ev.Where(a => a.CostosConcepto == (costosconceptos)).ToList();
                        if (ev.Count > 1 && (costosprecios != 0))
                        {
                            ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                            if (ev.Count > 1 && (cantidad != 0))
                            {
                                ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                                if (ev.Count > 1 && (codporcentaje != 0))
                                {
                                    ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                    if (ev.Count > 1 && (descuento != 0))
                                    {
                                        ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                        if (ev.Count > 1 && (costototal != 0))
                                        {
                                            ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CostosConcepto == (costosconceptos)).ToList();

                    if (ev.Count > 1 && (costosprecios != 0))
                    {
                        ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                        if (ev.Count > 1 && (cantidad != 0))
                        {
                            ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                            if (ev.Count > 1 && (codporcentaje != 0))
                            {
                                ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                if (ev.Count > 1 && (descuento != 0))
                                {
                                    ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                    if (ev.Count > 1 && (costototal != 0))
                                    {
                                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosconceptos != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CostosConcepto == (costosconceptos)).ToList();

                    if (ev.Count > 1 && (costosprecios != 0))
                    {
                        ev = ev.Where(a => a.Costoprecio == (costosprecios)).ToList();
                        if (ev.Count > 1 && (cantidad != 0))
                        {
                            ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                            if (ev.Count > 1 && (codporcentaje != 0))
                            {
                                ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                                if (ev.Count > 1 && (descuento != 0))
                                {
                                    ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                    if (ev.Count > 1 && (costototal != 0))
                                    {
                                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
                else if (costosprecios != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Costoprecio == (costosprecios)).ToList();

                    if (ev.Count > 1 && (cantidad != 0))
                    {
                        ev = ev.Where(a => a.Cantidad == (cantidad)).ToList();
                        if (ev.Count > 1 && (codporcentaje != 0))
                        {
                            ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                            if (ev.Count > 1 && (descuento != 0))
                            {
                                ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                                if (ev.Count > 1 && (costototal != 0))
                                {
                                    ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                                }
                            }
                        }
                    }
                }
                else if (cantidad != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Cantidad == (cantidad)).ToList();
                    if (ev.Count > 1 && (codporcentaje != 0))
                    {
                        ev = ev.Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                        if (ev.Count > 1 && (descuento != 0))
                        {
                            ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                            if (ev.Count > 1 && (costototal != 0))
                            {
                                ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                            }
                        }
                    }
                }
                else if (codporcentaje != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.CodPorcentaje == (codporcentaje)).ToList();
                    if (ev.Count > 1 && (descuento != 0))
                    {
                        ev = ev.Where(a => a.Descuento == (descuento)).ToList();
                        if (ev.Count > 1 && (costototal != 0))
                        {
                            ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                        }
                    }
                }
                else if (descuento != 0)
                {
                    ev = contexto.SaEventoDetalles.AsNoTracking().Where(a => a.Descuento == (descuento)).ToList();

                    if (ev.Count > 1 && (costototal != 0))
                    {
                        ev = ev.Where(a => a.CostoTotal == (cantidad)).ToList();
                    }
                }
            }
            else
            {
                return contexto.SaEventoDetalles.AsNoTracking().ToList();
            }
            return ev;
        }

        public InfoCompartidaCapas Crear(SaEventoDetalle evento)
        {
            try
            {
                contexto.SaEventoDetalles.Add(evento);
                return new InfoCompartidaCapas() { informacion = evento };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {evento.CodEvento}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEventoDetalle> eventos)
        {
            try
            {
                foreach (var item in eventos)
                {
                    contexto.SaEventoDetalles.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = eventos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEventoDetalle evento)
        {
            try
            {
                contexto.SaEventoDetalles.Attach(evento).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = evento };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {evento.CodEvento}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEventoDetalle> eventos)
        {
            try
            {
                foreach (var item in eventos)
                {
                    contexto.SaEventoDetalles.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = eventos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEventoDetalle evento)
        {
            try
            {
                contexto.SaEventoDetalles.Remove(evento);
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

