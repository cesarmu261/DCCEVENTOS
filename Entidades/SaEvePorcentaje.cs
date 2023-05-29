using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEvePorcentaje
{
    public int CodPorcentaje { get; set; }

    public string DesPorcentaje { get; set; } = null!;

    public decimal? Porciento { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEveConcepto> SaEveConceptos { get; set; } = new List<SaEveConcepto>();
}
