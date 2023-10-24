using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class SaEventoSalone
{
    public int CodSalon { get; set; }

    public string? DesSalon { get; set; }

    public string? DeslarSalon { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEvento> SaEventos { get; set; } = new List<SaEvento>();
}
