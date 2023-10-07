using System;
using System.Collections.Generic;

namespace Entidades;

public partial class SaEvePago
{
    public int CodPagos { get; set; }

    public int? CodEvento { get; set; }

    public int? CodTipoTransaccion { get; set; }

    public DateTime FechaDePago { get; set; }

    public DateTime FechaDeFactura { get; set; }

    public string? CodEstado { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaDeCancelacion { get; set; }

    public int? CodComprobante { get; set; }

    public int? CodPago { get; set; }

    public string? Referencia { get; set; }

    public int? Recibo { get; set; }

    public string? Observacionpago { get; set; }

    public decimal? Montoacobrar { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Ivaevento { get; set; }

    public decimal? Montoapagar { get; set; }

    public virtual SaEveTipoComprobante? CodComprobanteNavigation { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual SaEvento? CodEventoNavigation { get; set; }

    public virtual SaEveTipoPago? CodPagoNavigation { get; set; }

    public virtual SaEvTipoTransaccion? CodTipoTransaccionNavigation { get; set; }
}
