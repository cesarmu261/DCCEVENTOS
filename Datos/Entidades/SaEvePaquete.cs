using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class SaEvePaquete
{
    public int CodPaquete { get; set; }

    public string DesPaquete { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEvePaqueteDetalle> SaEvePaqueteDetalles { get; set; } = new List<SaEvePaqueteDetalle>();
}
