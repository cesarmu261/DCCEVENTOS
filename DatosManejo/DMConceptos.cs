using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;

namespace DatosManejo
{
    public class DMConceptos:IDisposable
    {
        private EventosContext contexto { get; set; }
        public DMConceptos(EventosContext contexto)
        {
            this.contexto = contexto;
        }


        public List<SaEveConcepto> Obtener2(string DesConcepto = "", int CodConcepto = 0, decimal CostosCoceptos = 0, decimal CostoPrecio = 0, string CodEstado = "", int Codporcentaje = 0, decimal porciento = 0)
        {
            List<SaEveConcepto> conceptos = contexto.SaEveConceptos.AsTracking().ToList();
            if (conceptos.Count > 1 && !String.IsNullOrEmpty(DesConcepto))
            {
                conceptos = conceptos.Where(a => a.DesConceptos == DesConcepto || a.DesConceptos.Contains(DesConcepto)).ToList();
                if (conceptos.Count > 1 && ((CodConcepto) != 0))
                {
                    conceptos = conceptos.Where(a => a.CodConceptos == CodConcepto).ToList();
                    if (conceptos.Count > 1 && ((CostosCoceptos) != 0))
                    {
                        conceptos = conceptos.Where(a => a.CostosConceptos == CostosCoceptos).ToList();
                        if (conceptos.Count > 1 && ((CostoPrecio) != 0))
                        {
                            conceptos = conceptos.Where(a => a.Costoprecio == CostoPrecio).ToList();
                            if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                            {
                                conceptos = conceptos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                                if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                                {
                                    conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                                    if (conceptos.Count > 1 && (porciento != 0))
                                    {
                                        conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return contexto.SaEveConceptos.AsNoTracking().ToList();
            }

            return conceptos;
        }
        public List<SaEveConcepto> Obtener(int CodConcepto = 0, int CodCategoria = 0, string DesConcepto = "", int Cantidad = 0, decimal CostosCoceptos = 0, decimal CostoPrecio = 0, string CodEstado = "", int Codporcentaje = 0, decimal porciento = 0)
        {
            List<SaEveConcepto> conceptos = new List<SaEveConcepto>();
            if (CodConcepto != 0)
            {
                conceptos = contexto.SaEveConceptos.AsNoTracking().Where(a => a.CodConceptos == CodConcepto).ToList();
                if (conceptos.Count > 1 && ((CodCategoria) != 0))
                {
                    conceptos = conceptos.Where(a => a.CodCategoria == CodCategoria).ToList();
                    if (conceptos.Count > 1 && !String.IsNullOrEmpty(DesConcepto))
                    {
                        conceptos = conceptos.Where(a => a.DesConceptos.Contains(DesConcepto)).ToList();
                        if (conceptos.Count > 1 && ((Cantidad) != 0))
                        {
                            conceptos = conceptos.Where(a => a.Cantidad == Cantidad).ToList();
                            if (conceptos.Count > 1 && ((CostosCoceptos) != 0))
                            {
                                conceptos = conceptos.Where(a => a.CostosConceptos == CostosCoceptos).ToList();
                                if (conceptos.Count > 1 && ((CostoPrecio) != 0))
                                {
                                    conceptos = conceptos.Where(a => a.Costoprecio == CostoPrecio).ToList();
                                    if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                                    {
                                        conceptos = conceptos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                                        if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                                        {
                                            conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                                            if (conceptos.Count > 1 && (porciento != 0))
                                            {
                                                conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (conceptos.Count > 1 && ((CodCategoria) != 0))
            {
                conceptos = contexto.SaEveConceptos.AsTracking().Where(a => a.CodCategoria == CodCategoria).ToList();
                if (conceptos.Count > 1 && !String.IsNullOrEmpty(DesConcepto))
                {
                    conceptos = conceptos.Where(a => a.DesConceptos.Contains(DesConcepto)).ToList();
                    if (conceptos.Count > 1 && ((CostosCoceptos) != 0))
                    {
                        conceptos = conceptos.Where(a => a.CostosConceptos == CostosCoceptos).ToList();
                        if (conceptos.Count > 1 && ((CostoPrecio) != 0))
                        {
                            conceptos = conceptos.Where(a => a.Costoprecio == CostoPrecio).ToList();
                            if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                            {
                                conceptos = conceptos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                                if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                                {
                                    conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                                    if (conceptos.Count > 1 && (porciento != 0))
                                    {
                                        conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (conceptos.Count > 1 && !String.IsNullOrEmpty(DesConcepto))
            {
                conceptos = contexto.SaEveConceptos.AsTracking().Where(a => a.DesConceptos.Contains(DesConcepto)).ToList();
                if (conceptos.Count > 1 && ((CostosCoceptos) != 0))
                {
                    conceptos = conceptos.Where(a => a.CostosConceptos == CostosCoceptos).ToList();
                    if (conceptos.Count > 1 && ((CostoPrecio) != 0))
                    {
                        conceptos = conceptos.Where(a => a.Costoprecio == CostoPrecio).ToList();
                        if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                        {
                            conceptos = conceptos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                            if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                            {
                                conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                                if (conceptos.Count > 1 && (porciento != 0))
                                {
                                    conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                                }
                            }
                        }
                    }
                }
            }
            else if (conceptos.Count > 1 && ((CostoPrecio) != 0))
            {
                conceptos = contexto.SaEveConceptos.AsTracking().Where(a => a.Costoprecio == CostoPrecio).ToList();
                if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
                {
                    conceptos = conceptos.Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                    if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                    {
                        conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                        if (conceptos.Count > 1 && (porciento != 0))
                        {
                            conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                        }
                    }
                }
            }
            else if (conceptos.Count > 1 && !String.IsNullOrEmpty(CodEstado))
            {
                conceptos = contexto.SaEveConceptos.AsTracking().Where(a => a.CodEstado.Contains(CodEstado)).ToList();
                if (conceptos.Count > 1 && ((Codporcentaje) != 0))
                {
                    conceptos = conceptos.Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                    if (conceptos.Count > 1 && (porciento != 0))
                    {
                        conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                    }
                }
            }
            else if (conceptos.Count > 1 && ((Codporcentaje) != 0))
            {
                conceptos = contexto.SaEveConceptos.AsTracking().Where(a => a.CodPorcentaje == Codporcentaje).ToList();
                if (conceptos.Count > 1 && (porciento != 0))
                {
                    conceptos = conceptos.Where(a => a.Porciento == porciento).ToList();
                }
            }
            else
            {
                return contexto.SaEveConceptos.AsNoTracking().ToList();
            }
            return conceptos;
        }
        public InfoCompartidaCapas Crear(SaEveConcepto conceptos)
        {
            try
            {
                contexto.SaEveConceptos.Add(conceptos);
                return new InfoCompartidaCapas() { informacion = conceptos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {conceptos.DesConceptos}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEveConcepto> conceptos)
        {
            try
            {
                foreach (var item in conceptos)
                {
                    contexto.SaEveConceptos.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = conceptos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEveConcepto conceptos)
        {
            try
            {
                contexto.SaEveConceptos.Attach(conceptos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = conceptos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {conceptos.DesConceptos}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEveConcepto> conceptos)
        {
            try
            {
                foreach (var item in conceptos)
                {
                    contexto.SaEveConceptos.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = conceptos };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEveConcepto conceptos)
        {
            try
            {
                contexto.SaEveConceptos.Remove(conceptos);
                return new InfoCompartidaCapas() { informacion = conceptos };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {conceptos.DesConceptos}" };
            }
        }

        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
        public int? ObtenerCodigo(string descripcion)
        {
            return contexto.SaEveConceptos.Where(a => a.DesConceptos == descripcion).FirstOrDefault().CodConceptos;
        }
        public string? Obtenedescripcion(int? cod)
        {
            return contexto.SaEveConceptos.Where(a => a.CodConceptos == cod).FirstOrDefault().DesConceptos;
        }
        public int? ObteneCategoria(int? cod)
        {
            return contexto.SaEveConceptos.Where(a => a.CodConceptos == cod).FirstOrDefault().CodCategoria;
        }
        public decimal? ObteneCostosConceptos(int? cod)
        {
            return contexto.SaEveConceptos.Where(a => a.CodConceptos == cod).FirstOrDefault().CostosConceptos;
        }
    }
}

