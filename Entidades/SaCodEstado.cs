using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaCodEstado
{
    public string CodEstado { get; set; } = null!;

    public string DesEstado { get; set; } = null!;

    public virtual ICollection<SaEveCategoriaimp> SaEveCategoriaimps { get; set; } = new List<SaEveCategoriaimp>();

    public virtual ICollection<SaEveCliente> SaEveClientes { get; set; } = new List<SaEveCliente>();

    public virtual ICollection<SaEveConcepto> SaEveConceptos { get; set; } = new List<SaEveConcepto>();

    public virtual ICollection<SaEvePaqueteDetalle> SaEvePaqueteDetalles { get; set; } = new List<SaEvePaqueteDetalle>();

    public virtual ICollection<SaEvePaquete> SaEvePaquetes { get; set; } = new List<SaEvePaquete>();

    public virtual ICollection<SaEvePorcentaje> SaEvePorcentajes { get; set; } = new List<SaEvePorcentaje>();

    public virtual ICollection<SaEvento> SaEventos { get; set; } = new List<SaEvento>();
}
