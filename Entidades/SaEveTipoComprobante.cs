using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEveTipoComprobante
{
    public int CodComprobante { get; set; }

    public string DesComprobante { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEvePago> SaEvePagos { get; set; } = new List<SaEvePago>();
}
