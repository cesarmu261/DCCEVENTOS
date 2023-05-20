using System;
using System.Collections.Generic;

namespace Entidades;
public partial class SaEvePaqueteDetalle
{
    public int CodDetallepaq { get; set; }

    public int? CodPaquete { get; set; }

    public int? CodConceptos { get; set; }

    public string CodEstado { get; set; } = null!;

    public virtual SaEveConcepto? CodConceptosNavigation { get; set; }

    public virtual SaCodEstado CodEstadoNavigation { get; set; } = null!;

    public virtual SaEvePaquete? CodPaqueteNavigation { get; set; }

    public virtual ICollection<SaEventoDetalle> SaEventoDetalles { get; set; } = new List<SaEventoDetalle>();
}
