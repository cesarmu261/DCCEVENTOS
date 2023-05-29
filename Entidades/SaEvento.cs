using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEvento
{
    public int CodEvento { get; set; }

    public string? CodCliente { get; set; }

    public string? DesEvento { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaEveCliente? CodClienteNavigation { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEventoDetalle> SaEventoDetalles { get; set; } = new List<SaEventoDetalle>();
}
