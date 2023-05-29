using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEveCliente
{
    public string CodCliente { get; set; } = null!;

    public string NomCliente { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string? Poblacion { get; set; }

    public string? Cp { get; set; }

    public string Telefono { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string DomicioFiscal { get; set; } = null!;

    public string? PoblacionFiscal { get; set; }

    public string? CpFiscal { get; set; }

    public DateTime FecNacimiento { get; set; }

    public DateTime FecRegistro { get; set; }

    public string CodRegimenfiscal { get; set; } = null!;

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<SaEvento> SaEventos { get; set; } = new List<SaEvento>();
}
