using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEveTipoPago
{
    public int CodPago { get; set; }

    public string DesPago { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEvePago> SaEvePagos { get; set; } = new List<SaEvePago>();
}
