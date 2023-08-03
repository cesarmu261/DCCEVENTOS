using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEventoDetalle
{
    public int CodDetalles { get; set; }

    public int? CodEvento { get; set; }

    public int? CodDetallepaq { get; set; }

    public int? CodConceptos { get; set; }

    public decimal? CostosConcepto { get; set; }

    public decimal? Costoprecio { get; set; }

    public decimal? Cantidad { get; set; }

    public int? CodCategoria { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? CostoTotal { get; set; }

    public virtual SaEvento? CodEventoNavigation { get; set; }
}
