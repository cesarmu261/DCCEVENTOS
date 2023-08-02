using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaTercero
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public string NomTercero { get; set; } = null!;

    public string CodTipoMembresia { get; set; } = null!;

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

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public string Extra03 { get; set; } = null!;

    public string Extra04 { get; set; } = null!;

    public DateTime FecNacimiento { get; set; }

    public DateTime FecRegistro { get; set; }

    public string CodCredencial { get; set; } = null!;

    public string CodTipoMantenimiento { get; set; } = null!;

    public string CodTipoCompra { get; set; } = null!;

    public decimal TotalMembresia { get; set; }

    public decimal AnticipoMembresia { get; set; }

    public decimal OtrosAbonosMembresia { get; set; }

    public decimal NumeroMenMembresia { get; set; }

    public decimal NumeroAnuMembresia { get; set; }

    public decimal MontoMenMembresia { get; set; }

    public decimal MontoAnuMembresia { get; set; }

    public decimal TotalMenMembresia { get; set; }

    public decimal TotalAnuMembresia { get; set; }

    public DateTime InicioMenMembresia { get; set; }

    public DateTime FinMenMembresia { get; set; }

    public DateTime InicioAnuMembresia { get; set; }

    public DateTime FinAnuMembresia { get; set; }

    public string CodEstado { get; set; } = null!;

    public string? ObservacionModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? CodUsuario { get; set; }

    public decimal? MontoFavor { get; set; }

    public decimal? SaldoMembresia { get; set; }

    public decimal? CodMenMembresia { get; set; }

    public decimal? CodAnuMembresia { get; set; }

    public string? Observaciones { get; set; }

    public decimal? LimiteCredito { get; set; }

    public decimal? SaldoCredito { get; set; }

    public string? CodEstadoCertificado { get; set; }

    public decimal? MenAdeudoPermitido { get; set; }

    public string? ConsumoConAduedo { get; set; }

    public string? MesImporteAnual { get; set; }
}
