using System;
using System.Collections.Generic;
using Coneccion;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Entidades;

namespace Datos;

public partial class EventosContext : DbContext
{
    private DbConnection coneccion;
    public EventosContext()
    {
        Conecciones conecciones = new Conecciones();
        coneccion = new SqlConnection(conecciones.ObtenerConeccion("EventosContext"));
    }
    public void TransaccionBR(DbConnection coneccion, DbTransaction transaction)
    {
        this.coneccion = coneccion;
        Database.UseTransaction(transaction);
    }
    public EventosContext(DbContextOptions<EventosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SaCodEstado> SaCodEstados { get; set; }

    public virtual DbSet<SaCodReg> SaCodRegs { get; set; }

    public virtual DbSet<SaEvTipoTransaccion> SaEvTipoTransaccions { get; set; }

    public virtual DbSet<SaEveCancelacione> SaEveCancelaciones { get; set; }

    public virtual DbSet<SaEveCategoriaimp> SaEveCategoriaimps { get; set; }

    public virtual DbSet<SaEveCliente> SaEveClientes { get; set; }

    public virtual DbSet<SaEveConcepto> SaEveConceptos { get; set; }

    public virtual DbSet<SaEvePago> SaEvePagos { get; set; }

    public virtual DbSet<SaEvePaquete> SaEvePaquetes { get; set; }

    public virtual DbSet<SaEvePaqueteDetalle> SaEvePaqueteDetalles { get; set; }

    public virtual DbSet<SaEvePorcentaje> SaEvePorcentajes { get; set; }

    public virtual DbSet<SaEveTipoComprobante> SaEveTipoComprobantes { get; set; }

    public virtual DbSet<SaEveTipoPago> SaEveTipoPagos { get; set; }

    public virtual DbSet<SaEvento> SaEventos { get; set; }

    public virtual DbSet<SaEventoDetalle> SaEventoDetalles { get; set; }

    public virtual DbSet<SaEventoSalone> SaEventoSalones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(coneccion);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaCodEstado>(entity =>
        {
            entity.HasKey(e => e.CodEstado).HasName("PK_SA_COD_ESTUSU");

            entity.ToTable("SA_COD_ESTADO");

            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesEstado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DES_ESTADO");
        });

        modelBuilder.Entity<SaCodReg>(entity =>
        {
            entity.HasKey(e => e.CodReg);

            entity.ToTable("SA_COD_REG");

            entity.Property(e => e.CodReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_REG");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.DesReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_REG");
        });

        modelBuilder.Entity<SaEvTipoTransaccion>(entity =>
        {
            entity.HasKey(e => e.CodTipoTransaccion).HasName("PK_SA_COD_TIPO_TRANSACCION");

            entity.ToTable("SA_EV_TIPO_TRANSACCION");

            entity.Property(e => e.CodTipoTransaccion).HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.DesTipoTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_TRANSACCION");
        });

        modelBuilder.Entity<SaEveCancelacione>(entity =>
        {
            entity.HasKey(e => e.CodCancelacion);

            entity.ToTable("SA_EVE_CANCELACIONES");

            entity.Property(e => e.CodCancelacion).HasColumnName("COD_CANCELACION");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesCancelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_CANCELACION");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveCancelaciones)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_CANCELACIONES_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEveCategoriaimp>(entity =>
        {
            entity.HasKey(e => e.CodCategoria);

            entity.ToTable("SA_EVE_CATEGORIAIMP");

            entity.Property(e => e.CodCategoria).HasColumnName("COD_CATEGORIA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesCategoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_CATEGORIA");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveCategoriaimps)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_CATEGORIAIMP_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEveCliente>(entity =>
        {
            entity.HasKey(e => e.CodCliente);

            entity.ToTable("SA_EVE_CLIENTES");

            entity.Property(e => e.CodCliente).HasColumnName("COD_CLIENTE");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodRegimenfiscal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_REGIMENFISCAL");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Cp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP");
            entity.Property(e => e.CpFiscal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP_FISCAL");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.DomicioFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICIO_FISCAL");
            entity.Property(e => e.FecNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_NACIMIENTO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.NomCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_CLIENTE");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION");
            entity.Property(e => e.PoblacionFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION_FISCAL");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RAZON_SOCIAL");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveClientes)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_CLIENTES_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEveConcepto>(entity =>
        {
            entity.HasKey(e => e.CodConceptos);

            entity.ToTable("SA_EVE_CONCEPTOS");

            entity.Property(e => e.CodConceptos).HasColumnName("COD_CONCEPTOS");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.CodCategoria).HasColumnName("COD_CATEGORIA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodPorcentaje).HasColumnName("COD_PORCENTAJE");
            entity.Property(e => e.Costoprecio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTOPRECIO");
            entity.Property(e => e.CostosConceptos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTOS_CONCEPTOS");
            entity.Property(e => e.DesConceptos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_CONCEPTOS");
            entity.Property(e => e.Porciento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PORCIENTO");

            entity.HasOne(d => d.CodCategoriaNavigation).WithMany(p => p.SaEveConceptos)
                .HasForeignKey(d => d.CodCategoria)
                .HasConstraintName("FK_SA_EVE_CONCEPTOS_SA_EVE_CATEGORIAIMP");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveConceptos)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_CONCEPTOS_SA_COD_ESTADO");

            entity.HasOne(d => d.CodPorcentajeNavigation).WithMany(p => p.SaEveConceptos)
                .HasForeignKey(d => d.CodPorcentaje)
                .HasConstraintName("FK_SA_EVE_CONCEPTOS_SA_EVE_PORCENTAJE");
        });

        modelBuilder.Entity<SaEvePago>(entity =>
        {
            entity.HasKey(e => e.CodPagos).HasName("SA_EVE_PAGO");

            entity.ToTable("SA_EVE_PAGOS");

            entity.Property(e => e.CodPagos).HasColumnName("COD_PAGOS");
            entity.Property(e => e.CodComprobante).HasColumnName("COD_COMPROBANTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodEvento).HasColumnName("COD_EVENTO");
            entity.Property(e => e.CodPago).HasColumnName("COD_PAGO");
            entity.Property(e => e.CodTipoTransaccion).HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.FechaDeCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CANCELACION");
            entity.Property(e => e.FechaDeFactura)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_FACTURA");
            entity.Property(e => e.FechaDePago)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_PAGO");
            entity.Property(e => e.Ivaevento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("IVAEVENTO");
            entity.Property(e => e.Montoacobrar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MONTOACOBRAR");
            entity.Property(e => e.Montoapagar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MONTOAPAGAR");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.Observacionpago)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONPAGO");
            entity.Property(e => e.Recibo).HasColumnName("RECIBO");
            entity.Property(e => e.Referencia)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SUBTOTAL");

            entity.HasOne(d => d.CodComprobanteNavigation).WithMany(p => p.SaEvePagos)
                .HasForeignKey(d => d.CodComprobante)
                .HasConstraintName("FK_SA_EVE_PAGOS_SA_EVE_TIPO_COMPROBANTE");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEvePagos)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_PAGOS_SA_COD_ESTADO");

            entity.HasOne(d => d.CodEventoNavigation).WithMany(p => p.SaEvePagos)
                .HasForeignKey(d => d.CodEvento)
                .HasConstraintName("FK_SA_EVE_PAGOS_SA_EVENTOS");

            entity.HasOne(d => d.CodPagoNavigation).WithMany(p => p.SaEvePagos)
                .HasForeignKey(d => d.CodPago)
                .HasConstraintName("FK_SA_EVE_PAGOS_SA_EVE_TIPO_PAGO");

            entity.HasOne(d => d.CodTipoTransaccionNavigation).WithMany(p => p.SaEvePagos)
                .HasForeignKey(d => d.CodTipoTransaccion)
                .HasConstraintName("FK_SA_EVE_PAGOS_SA_EV_TIPO_TRANSACCION");
        });

        modelBuilder.Entity<SaEvePaquete>(entity =>
        {
            entity.HasKey(e => e.CodPaquete);

            entity.ToTable("SA_EVE_PAQUETE");

            entity.Property(e => e.CodPaquete).HasColumnName("COD_PAQUETE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesPaquete)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_PAQUETE");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEvePaquetes)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_PAQUETE_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEvePaqueteDetalle>(entity =>
        {
            entity.HasKey(e => e.CodDetallepaq);

            entity.ToTable("SA_EVE_PAQUETE_DETALLE");

            entity.Property(e => e.CodDetallepaq).HasColumnName("COD_DETALLEPAQ");
            entity.Property(e => e.CodConceptos).HasColumnName("COD_CONCEPTOS");
            entity.Property(e => e.CodDp).HasColumnName("COD_DP");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodPaquete).HasColumnName("COD_PAQUETE");

            entity.HasOne(d => d.CodConceptosNavigation).WithMany(p => p.SaEvePaqueteDetalles)
                .HasForeignKey(d => d.CodConceptos)
                .HasConstraintName("FK_SA_EVE_PAQUETE_DETALLE_SA_EVE_CONCEPTOS");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEvePaqueteDetalles)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_PAQUETE_DETALLE_SA_COD_ESTADO");

            entity.HasOne(d => d.CodPaqueteNavigation).WithMany(p => p.SaEvePaqueteDetalles)
                .HasForeignKey(d => d.CodPaquete)
                .HasConstraintName("FK_SA_EVE_PAQUETE_DETALLE_SA_EVE_PAQUETE");
        });

        modelBuilder.Entity<SaEvePorcentaje>(entity =>
        {
            entity.HasKey(e => e.CodPorcentaje);

            entity.ToTable("SA_EVE_PORCENTAJE");

            entity.Property(e => e.CodPorcentaje).HasColumnName("COD_PORCENTAJE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesPorcentaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PORCENTAJE");
            entity.Property(e => e.Porciento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PORCIENTO");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEvePorcentajes)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_PORCENTAJE_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEveTipoComprobante>(entity =>
        {
            entity.HasKey(e => e.CodComprobante);

            entity.ToTable("SA_EVE_TIPO_COMPROBANTE");

            entity.Property(e => e.CodComprobante).HasColumnName("COD_COMPROBANTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesComprobante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_COMPROBANTE");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveTipoComprobantes)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_TIPO_COMPROBANTE_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEveTipoPago>(entity =>
        {
            entity.HasKey(e => e.CodPago);

            entity.ToTable("SA_EVE_TIPO_PAGO");

            entity.Property(e => e.CodPago).HasColumnName("COD_PAGO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PAGO");
            entity.Property(e => e.Valor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("VALOR");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEveTipoPagos)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVE_TIPO_PAGO_SA_COD_ESTADO");
        });

        modelBuilder.Entity<SaEvento>(entity =>
        {
            entity.HasKey(e => e.CodEvento);

            entity.ToTable("SA_EVENTOS");

            entity.Property(e => e.CodEvento).HasColumnName("COD_EVENTO");
            entity.Property(e => e.CodCliente).HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodSalon).HasColumnName("COD_SALON");
            entity.Property(e => e.DesEvento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_EVENTO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");

            entity.HasOne(d => d.CodClienteNavigation).WithMany(p => p.SaEventos)
                .HasForeignKey(d => d.CodCliente)
                .HasConstraintName("FK_SA_EVENTOS_SA_EVE_CLIENTES");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEventos)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVENTOS_SA_COD_ESTADO");

            entity.HasOne(d => d.CodSalonNavigation).WithMany(p => p.SaEventos)
                .HasForeignKey(d => d.CodSalon)
                .HasConstraintName("FK_SA_EVENTOS_SA_EVENTO_SALONES");
        });

        modelBuilder.Entity<SaEventoDetalle>(entity =>
        {
            entity.HasKey(e => e.CodDetalles);

            entity.ToTable("SA_EVENTO_DETALLE");

            entity.Property(e => e.CodDetalles).HasColumnName("COD_DETALLES");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodCategoria).HasColumnName("COD_CATEGORIA");
            entity.Property(e => e.CodConceptos).HasColumnName("COD_CONCEPTOS");
            entity.Property(e => e.CodDetallepaq).HasColumnName("COD_DETALLEPAQ");
            entity.Property(e => e.CodEvento).HasColumnName("COD_EVENTO");
            entity.Property(e => e.CostoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costoprecio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTOPRECIO");
            entity.Property(e => e.CostosConcepto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTOS_CONCEPTO");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("DESCUENTO");

            entity.HasOne(d => d.CodEventoNavigation).WithMany(p => p.SaEventoDetalles)
                .HasForeignKey(d => d.CodEvento)
                .HasConstraintName("FK_SA_EVENTO_DETALLE_SA_EVENTOS");
        });

        modelBuilder.Entity<SaEventoSalone>(entity =>
        {
            entity.HasKey(e => e.CodSalon);

            entity.ToTable("SA_EVENTO_SALONES");

            entity.Property(e => e.CodSalon).HasColumnName("COD_SALON");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesSalon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_SALON");
            entity.Property(e => e.DeslarSalon)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESLAR_SALON");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.SaEventoSalones)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("FK_SA_EVENTO_SALONES_SA_COD_ESTADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
