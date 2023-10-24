using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class SaEveCategoriaimp
{
    public int CodCategoria { get; set; }

    public string DesCategoria { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEveConcepto> SaEveConceptos { get; set; } = new List<SaEveConcepto>();
}
