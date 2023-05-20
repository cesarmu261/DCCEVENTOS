using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEveConcepto
{
    public int CodConceptos { get; set; }

    public decimal? CodCategoria { get; set; }

    public string DesConceptos { get; set; } = null!;

    public decimal? CostosConceptos { get; set; }

    public decimal? Costoprecio { get; set; }

    public string CodEstado { get; set; } = null!;

    public decimal? CodPorcentaje { get; set; }

    public decimal? Porciento { get; set; }

    public virtual SaEveCategoriaimp? CodCategoriaNavigation { get; set; }

    public virtual SaCodEstado CodEstadoNavigation { get; set; } = null!;

    public virtual SaEvePorcentaje? CodPorcentajeNavigation { get; set; }

    public virtual ICollection<SaEvePaqueteDetalle> SaEvePaqueteDetalles { get; set; } = new List<SaEvePaqueteDetalle>();
}
