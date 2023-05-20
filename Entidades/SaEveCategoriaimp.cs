using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEveCategoriaimp
{
    public decimal CodCategoria { get; set; }

    public string DesCategoria { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public virtual SaCodEstado CodEstadoNavigation { get; set; } = null!;

    public virtual ICollection<SaEveConcepto> SaEveConceptos { get; set; } = new List<SaEveConcepto>();
}
