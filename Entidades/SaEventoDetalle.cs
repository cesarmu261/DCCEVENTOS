using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEventoDetalle
{
    public int CodDetalles { get; set; }

    public int? CodEvento { get; set; }

    public int? CodDp { get; set; }

    public int? CodConceptos { get; set; }

    public decimal? CostosConcepto { get; set; }

    public decimal? Cantidad { get; set; }

    public int? CodPorcentaje { get; set; }

    public decimal? Porciento { get; set; }

    public decimal? Costoprecio { get; set; }

    public virtual SaEvePaqueteDetalle? CodDpNavigation { get; set; }

    public virtual SaEvento? CodEventoNavigation { get; set; }
}
