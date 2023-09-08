using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEvTipoTransaccion
{
    public int CodTipoTransaccion { get; set; }

    public string DesTipoTransaccion { get; set; } = null!;

    public virtual ICollection<SaEvePago> SaEvePagos { get; set; } = new List<SaEvePago>();
}
