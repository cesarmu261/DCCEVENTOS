using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEvePaqueteDetalle
{
    public int CodDetallepaq { get; set; }

    public int? CodDp { get; set; }

    public int? CodPaquete { get; set; }

    public int? CodConceptos { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaEveConcepto? CodConceptosNavigation { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual SaEvePaquete? CodPaqueteNavigation { get; set; }
}
