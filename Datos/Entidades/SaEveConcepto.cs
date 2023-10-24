using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class SaEveConcepto
{
    public int CodConceptos { get; set; }

    public int? CodCategoria { get; set; }

    public string DesConceptos { get; set; } = null!;

    public int? Cantidad { get; set; }

    public decimal? CostosConceptos { get; set; }

    public decimal? Costoprecio { get; set; }

    public string? CodEstado { get; set; }

    public int? CodPorcentaje { get; set; }

    public decimal? Porciento { get; set; }

    public virtual SaEveCategoriaimp? CodCategoriaNavigation { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual SaEvePorcentaje? CodPorcentajeNavigation { get; set; }

    public virtual ICollection<SaEvePaqueteDetalle> SaEvePaqueteDetalles { get; set; } = new List<SaEvePaqueteDetalle>();
}
