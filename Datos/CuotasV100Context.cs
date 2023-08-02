using System.Data.Common;
using Coneccion;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Datos;

public partial class CuotasV100Context : DbContext
{
    private DbConnection coneccion;
    public CuotasV100Context()
    {
        Conecciones conecciones = new Conecciones();
        coneccion = new SqlConnection(conecciones.ObtenerConeccion2("CuotasV100Context"));
    }
    public void TransaccionBR(DbConnection coneccion, DbTransaction transaction)
    {
        this.coneccion = coneccion;
        this.Database.UseTransaction(transaction);
    }
    public CuotasV100Context(DbContextOptions<CuotasV100Context> options)
        : base(options)
    {
    }
    public virtual DbSet<SaTercero> SaTerceros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(coneccion);

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaTercero>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero });

            entity.ToTable("SA_TERCERO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.AnticipoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ANTICIPO_MEMBRESIA");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.CodAnuMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_ANU_MEMBRESIA");
            entity.Property(e => e.CodCredencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_CREDENCIAL");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodEstadoCertificado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO_CERTIFICADO");
            entity.Property(e => e.CodMenMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_MEN_MEMBRESIA");
            entity.Property(e => e.CodTipoCompra)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_COMPRA");
            entity.Property(e => e.CodTipoMantenimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MANTENIMIENTO");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ConsumoConAduedo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONSUMO_CON_ADUEDO");
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
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.Extra03)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA03");
            entity.Property(e => e.Extra04)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA04");
            entity.Property(e => e.FecNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_NACIMIENTO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.FinAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_ANU_MEMBRESIA");
            entity.Property(e => e.FinMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_MEN_MEMBRESIA");
            entity.Property(e => e.InicioAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_ANU_MEMBRESIA");
            entity.Property(e => e.InicioMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_MEN_MEMBRESIA");
            entity.Property(e => e.LimiteCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMITE_CREDITO");
            entity.Property(e => e.MenAdeudoPermitido)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("MEN_ADEUDO_PERMITIDO");
            entity.Property(e => e.MesImporteAnual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MES_IMPORTE_ANUAL");
            entity.Property(e => e.MontoAnuMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ANU_MEMBRESIA");
            entity.Property(e => e.MontoFavor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO_FAVOR");
            entity.Property(e => e.MontoMenMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_MEN_MEMBRESIA");
            entity.Property(e => e.NomTercero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_TERCERO");
            entity.Property(e => e.NumeroAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_ANU_MEMBRESIA");
            entity.Property(e => e.NumeroMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_MEN_MEMBRESIA");
            entity.Property(e => e.ObservacionModificacion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_MODIFICACION");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.OtrosAbonosMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTROS_ABONOS_MEMBRESIA");
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
            entity.Property(e => e.SaldoCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_CREDITO");
            entity.Property(e => e.SaldoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_MEMBRESIA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TotalAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_ANU_MEMBRESIA");
            entity.Property(e => e.TotalMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEMBRESIA");
            entity.Property(e => e.TotalMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEN_MEMBRESIA");

        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
