using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class SaEveCancelacione
{
    public int CodCancelacion { get; set; }

    public string DesCancelacion { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }
}
