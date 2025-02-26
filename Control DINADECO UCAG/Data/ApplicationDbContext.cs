using System;
using System.Collections.Generic;
using Control_DINADECO_UCAG.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Control_DINADECO_UCAG.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbActum> TbActa { get; set; }

    public virtual DbSet<TbAcuerdo> TbAcuerdos { get; set; }

    public virtual DbSet<TbAsociacion> TbAsociacions { get; set; }

    public virtual DbSet<TbAsociacionWeb> TbAsociacionWebs { get; set; }

    public virtual DbSet<TbAsociado> TbAsociados { get; set; }

    public virtual DbSet<TbAtractivo> TbAtractivos { get; set; }

    public virtual DbSet<TbCheque> TbCheques { get; set; }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbConcepto> TbConceptos { get; set; }

    public virtual DbSet<TbCuentum> TbCuenta { get; set; }

    public virtual DbSet<TbDetalleEgreso> TbDetalleEgresos { get; set; }

    public virtual DbSet<TbDetalleFactura> TbDetalleFacturas { get; set; }

    public virtual DbSet<TbDetalleIngreso> TbDetalleIngresos { get; set; }

    public virtual DbSet<TbDocumento> TbDocumentos { get; set; }

    public virtual DbSet<TbFactura> TbFacturas { get; set; }

    public virtual DbSet<TbFoto> TbFotos { get; set; }

    public virtual DbSet<TbInformeEconomico> TbInformeEconomicos { get; set; }

    public virtual DbSet<TbJuntaDirectiva> TbJuntaDirectivas { get; set; }

    public virtual DbSet<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; }

    public virtual DbSet<TbMovimientoEgreso> TbMovimientoEgresos { get; set; }

    public virtual DbSet<TbMovimientoIngreso> TbMovimientoIngresos { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbPuesto> TbPuestos { get; set; }

    public virtual DbSet<TbTipoMovimiento> TbTipoMovimientos { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    public virtual DbSet<TbRol> TbRols { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=DefaultConnection", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<TbActum>(entity =>
        {
            entity.HasKey(e => e.IdActa).HasName("PRIMARY");

            entity.ToTable("tb_acta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdAsociado, "id_asociado");

            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.FechaSesion).HasColumnName("fecha_sesion");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.IdConcepto)
                .HasColumnType("int(11)")
                .HasColumnName("id_concepto");
            entity.Property(e => e.Monto)
                .HasPrecision(6, 2)
                .HasColumnName("monto");
            entity.Property(e => e.NumeroActa)
                .HasMaxLength(20)
                .HasColumnName("numero_acta");
            entity.Property(e => e.Observacion)
                .HasMaxLength(320)
                .HasColumnName("observacion");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbActa)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_acta_ibfk_2");

            entity.HasOne(d => d.IdAsociadoNavigation).WithMany(p => p.TbActa)
                .HasForeignKey(d => d.IdAsociado)
                .HasConstraintName("tb_acta_ibfk_1");
        });

        modelBuilder.Entity<TbAcuerdo>(entity =>
        {
            entity.HasKey(e => e.IdAcuerdo).HasName("PRIMARY");

            entity.ToTable("tb_acuerdo");

            entity.HasIndex(e => e.IdActa, "id_acta");

            entity.Property(e => e.IdAcuerdo)
                .HasColumnType("int(11)")
                .HasColumnName("id_acuerdo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroAcuerdo)
                .HasMaxLength(10)
                .HasColumnName("numero_acuerdo");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbAcuerdos)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("tb_acuerdo_ibfk_1");
        });

        modelBuilder.Entity<TbAsociacion>(entity =>
        {
            entity.HasKey(e => e.IdAsociacion).HasName("PRIMARY");

            entity.ToTable("tb_asociacion");

            entity.HasIndex(e => e.CedulaJuridica, "cedula_juridica").IsUnique();

            entity.HasIndex(e => e.CodigoRegistro, "codigo_registro").IsUnique();

            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.Canton)
                .HasMaxLength(50)
                .HasColumnName("canton");
            entity.Property(e => e.CedulaJuridica)
                .HasMaxLength(40)
                .HasColumnName("cedula_juridica");
            entity.Property(e => e.CodigoRegistro)
                .HasMaxLength(40)
                .HasColumnName("codigo_registro");
            entity.Property(e => e.Correo)
                .HasMaxLength(120)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Distrito)
                .HasMaxLength(50)
                .HasColumnName("distrito");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .HasColumnName("estado");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("fax");
            entity.Property(e => e.FechaConstitucion).HasColumnName("fecha_constitucion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .HasColumnName("nombre");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .HasColumnName("provincia");
            entity.Property(e => e.Pueblo)
                .HasMaxLength(50)
                .HasColumnName("pueblo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<TbAsociacionWeb>(entity =>
        {
            entity.HasKey(e => e.IdAsocWeb).HasName("PRIMARY");

            entity.ToTable("tb_asociacion_web");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdAsocWeb)
                .HasColumnType("int(11)")
                .HasColumnName("id_asoc_web");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.Latitud)
                .HasMaxLength(30)
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasMaxLength(30)
                .HasColumnName("longitud");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbAsociacionWebs)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_asociacion_web_ibfk_1");
        });

        modelBuilder.Entity<TbAsociado>(entity =>
        {
            entity.HasKey(e => e.IdAsociado).HasName("PRIMARY");

            entity.ToTable("tb_asociado");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .HasColumnName("apellido_1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .HasColumnName("apellido_2");
            entity.Property(e => e.Cedula)
                .HasMaxLength(12)
                .HasColumnName("cedula");
            entity.Property(e => e.Correo)
                .HasMaxLength(120)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(30)
                .HasColumnName("estado_civil");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(60)
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(15)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbAsociados)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_asociado_ibfk_1");
        });

        modelBuilder.Entity<TbAtractivo>(entity =>
        {
            entity.HasKey(e => e.IdAtractivos).HasName("PRIMARY");

            entity.ToTable("tb_atractivos");

            entity.HasIndex(e => e.IdAsocWeb, "id_asoc_web");

            entity.Property(e => e.IdAtractivos)
                .HasColumnType("int(11)")
                .HasColumnName("id_atractivos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.IdAsocWeb)
                .HasColumnType("int(11)")
                .HasColumnName("id_asoc_web");
            entity.Property(e => e.Latitud)
                .HasMaxLength(30)
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasMaxLength(30)
                .HasColumnName("longitud");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdAsocWebNavigation).WithMany(p => p.TbAtractivos)
                .HasForeignKey(d => d.IdAsocWeb)
                .HasConstraintName("tb_atractivos_ibfk_1");
        });

        modelBuilder.Entity<TbCheque>(entity =>
        {
            entity.HasKey(e => e.IdCheque).HasName("PRIMARY");

            entity.ToTable("tb_cheque");

            entity.HasIndex(e => e.IdCuenta, "id_cuenta");

            entity.HasIndex(e => e.IdGirado, "id_girado");

            entity.HasIndex(e => e.NoCheque, "no_cheque").IsUnique();

            entity.Property(e => e.IdCheque)
                .HasColumnType("int(11)")
                .HasColumnName("id_cheque");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("id_cuenta");
            entity.Property(e => e.IdGirado)
                .HasColumnType("int(11)")
                .HasColumnName("id_girado");
            entity.Property(e => e.Monto)
                .HasPrecision(9, 2)
                .HasColumnName("monto");
            entity.Property(e => e.NoCheque)
                .HasColumnType("int(11)")
                .HasColumnName("no_cheque");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbCheques)
                .HasForeignKey(d => d.IdCuenta)
                .HasConstraintName("tb_cheque_ibfk_1");

            entity.HasOne(d => d.IdGiradoNavigation).WithMany(p => p.TbCheques)
                .HasForeignKey(d => d.IdGirado)
                .HasConstraintName("tb_cheque_ibfk_2");
        });

        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PRIMARY");

            entity.ToTable("tb_cliente");

            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(50)
                .HasColumnName("apellido_1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(50)
                .HasColumnName("apellido_2");
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<TbConcepto>(entity =>
        {
            entity.HasKey(e => e.IdConcepto).HasName("PRIMARY");

            entity.ToTable("tb_concepto");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdConcepto)
                .HasColumnType("int(11)")
                .HasColumnName("id_concepto");
            entity.Property(e => e.Aplicacion2).HasColumnName("aplicacion_2");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbConceptos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_concepto_ibfk_1");
        });

        modelBuilder.Entity<TbCuentum>(entity =>
        {
            entity.HasKey(e => e.IdCuenta).HasName("PRIMARY");

            entity.ToTable("tb_cuenta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.NumeroCuenta, "numero_cuenta").IsUnique();

            entity.Property(e => e.IdCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("id_cuenta");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.NumeroCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.Saldo)
                .HasPrecision(12, 2)
                .HasColumnName("saldo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbCuenta)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_cuenta_ibfk_1");
        });

        modelBuilder.Entity<TbDetalleEgreso>(entity =>
        {
            entity.HasKey(e => e.IdDetalleEgreso).HasName("PRIMARY");

            entity.ToTable("tb_detalle_egreso");

            entity.HasIndex(e => e.IdInformeEconomico, "id_informe_economico");

            entity.HasIndex(e => e.IdMovimientoEgreso, "id_movimiento_egreso");

            entity.Property(e => e.IdDetalleEgreso)
                .HasColumnType("int(11)")
                .HasColumnName("id_detalle_egreso");
            entity.Property(e => e.IdInformeEconomico)
                .HasColumnType("int(11)")
                .HasColumnName("id_informe_economico");
            entity.Property(e => e.IdMovimientoEgreso)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimiento_egreso");
            entity.Property(e => e.Total)
                .HasPrecision(6, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdInformeEconomicoNavigation).WithMany(p => p.TbDetalleEgresos)
                .HasForeignKey(d => d.IdInformeEconomico)
                .HasConstraintName("tb_detalle_egreso_ibfk_2");

            entity.HasOne(d => d.IdMovimientoEgresoNavigation).WithMany(p => p.TbDetalleEgresos)
                .HasForeignKey(d => d.IdMovimientoEgreso)
                .HasConstraintName("tb_detalle_egreso_ibfk_1");
        });

        modelBuilder.Entity<TbDetalleFactura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tb_detalle_factura");

            entity.HasIndex(e => e.IdFactura, "id_factura");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasPrecision(6, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("id_factura");
            entity.Property(e => e.MontoTotal)
                .HasPrecision(6, 2)
                .HasColumnName("monto_total");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(6, 2)
                .HasColumnName("precio_unitario");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbDetalleFacturas)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("tb_detalle_factura_ibfk_1");
        });

        modelBuilder.Entity<TbDetalleIngreso>(entity =>
        {
            entity.HasKey(e => e.IdDetalleIngreso).HasName("PRIMARY");

            entity.ToTable("tb_detalle_ingreso");

            entity.HasIndex(e => e.IdInformeEconomico, "id_informe_economico");

            entity.HasIndex(e => e.IdMovimientoIngreso, "id_movimiento_ingreso");

            entity.Property(e => e.IdDetalleIngreso)
                .HasColumnType("int(11)")
                .HasColumnName("id_detalle_ingreso");
            entity.Property(e => e.IdInformeEconomico)
                .HasColumnType("int(11)")
                .HasColumnName("id_informe_economico");
            entity.Property(e => e.IdMovimientoIngreso)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimiento_ingreso");
            entity.Property(e => e.Total)
                .HasPrecision(8, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdInformeEconomicoNavigation).WithMany(p => p.TbDetalleIngresos)
                .HasForeignKey(d => d.IdInformeEconomico)
                .HasConstraintName("tb_detalle_ingreso_ibfk_2");

            entity.HasOne(d => d.IdMovimientoIngresoNavigation).WithMany(p => p.TbDetalleIngresos)
                .HasForeignKey(d => d.IdMovimientoIngreso)
                .HasConstraintName("tb_detalle_ingreso_ibfk_1");
        });

        modelBuilder.Entity<TbDocumento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("PRIMARY");

            entity.ToTable("tb_documento");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdFactura, "id_factura");

            entity.Property(e => e.IdDocumento)
                .HasColumnType("int(11)")
                .HasColumnName("id_documento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("id_factura");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(30)
                .HasColumnName("numero_documento");
            entity.Property(e => e.Total)
                .HasPrecision(9, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbDocumentos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_documento_ibfk_2");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbDocumentos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("tb_documento_ibfk_1");
        });

        modelBuilder.Entity<TbFactura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PRIMARY");

            entity.ToTable("tb_factura");

            entity.HasIndex(e => e.IdConcepto, "id_concepto");

            entity.HasIndex(e => e.IdProveedor, "id_proveedor");

            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("id_factura");
            entity.Property(e => e.Descuento)
                .HasPrecision(6, 2)
                .HasColumnName("descuento");
            entity.Property(e => e.Detalle)
                .HasMaxLength(60)
                .HasColumnName("detalle");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdConcepto)
                .HasColumnType("int(11)")
                .HasColumnName("id_concepto");
            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Impuestos)
                .HasPrecision(6, 2)
                .HasColumnName("impuestos");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(6, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(6, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.TbFacturas)
                .HasForeignKey(d => d.IdConcepto)
                .HasConstraintName("tb_factura_ibfk_2");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TbFacturas)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("tb_factura_ibfk_1");
        });

        modelBuilder.Entity<TbFoto>(entity =>
        {
            entity.HasKey(e => e.IdFotos).HasName("PRIMARY");

            entity.ToTable("tb_fotos");

            entity.HasIndex(e => e.IdAtractivos, "id_atractivos");

            entity.Property(e => e.IdFotos)
                .HasColumnType("int(11)")
                .HasColumnName("id_fotos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdAtractivos)
                .HasColumnType("int(11)")
                .HasColumnName("id_atractivos");
            entity.Property(e => e.RutaFoto)
                .HasMaxLength(60)
                .HasColumnName("ruta_foto");

            entity.HasOne(d => d.IdAtractivosNavigation).WithMany(p => p.TbFotos)
                .HasForeignKey(d => d.IdAtractivos)
                .HasConstraintName("tb_fotos_ibfk_1");
        });

        modelBuilder.Entity<TbInformeEconomico>(entity =>
        {
            entity.HasKey(e => e.IdInformeEconomico).HasName("PRIMARY");

            entity.ToTable("tb_informe_economico");

            entity.HasIndex(e => e.IdActa, "id_acta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdInformeEconomico)
                .HasColumnType("int(11)")
                .HasColumnName("id_informe_economico");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .HasColumnName("estado");
            entity.Property(e => e.FechaActualizacion).HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaInforme).HasColumnName("fecha_informe");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.TotalEgresos)
                .HasPrecision(9, 2)
                .HasColumnName("total_egresos");
            entity.Property(e => e.TotalIngresos)
                .HasPrecision(9, 2)
                .HasColumnName("total_ingresos");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbInformeEconomicos)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("tb_informe_economico_ibfk_1");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbInformeEconomicos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_informe_economico_ibfk_2");
        });

        modelBuilder.Entity<TbJuntaDirectiva>(entity =>
        {
            entity.HasKey(e => e.IdJuntaDirectiva).HasName("PRIMARY");

            entity.ToTable("tb_junta_directiva");

            entity.HasIndex(e => e.IdActa, "id_acta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion").IsUnique();

            entity.Property(e => e.IdJuntaDirectiva)
                .HasColumnType("int(11)")
                .HasColumnName("id_junta_directiva");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .HasColumnName("estado");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.PeriodoFin).HasColumnName("periodo_fin");
            entity.Property(e => e.PeriodoInicio).HasColumnName("periodo_inicio");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbJuntaDirectivas)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("tb_junta_directiva_ibfk_2");

            entity.HasOne(d => d.IdAsociacionNavigation).WithOne(p => p.TbJuntaDirectiva)
                .HasForeignKey<TbJuntaDirectiva>(d => d.IdAsociacion)
                .HasConstraintName("tb_junta_directiva_ibfk_1");
        });

        modelBuilder.Entity<TbMiembrosJuntaDirectiva>(entity =>
        {
            entity.HasKey(e => e.IdMiembrosJuntaDirectiva).HasName("PRIMARY");

            entity.ToTable("tb_miembros_junta_directiva");

            entity.HasIndex(e => e.IdAsociado, "id_asociado");

            entity.HasIndex(e => e.IdJuntaDirectiva, "id_junta_directiva");

            entity.HasIndex(e => e.IdPuesto, "id_puesto");

            entity.Property(e => e.IdMiembrosJuntaDirectiva)
                .HasColumnType("int(11)")
                .HasColumnName("id_miembros_junta_directiva");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.IdJuntaDirectiva)
                .HasColumnType("int(11)")
                .HasColumnName("id_junta_directiva");
            entity.Property(e => e.IdPuesto)
                .HasColumnType("int(11)")
                .HasColumnName("id_puesto");

            entity.HasOne(d => d.IdAsociadoNavigation).WithMany(p => p.TbMiembrosJuntaDirectivas)
                .HasForeignKey(d => d.IdAsociado)
                .HasConstraintName("tb_miembros_junta_directiva_ibfk_2");

            entity.HasOne(d => d.IdJuntaDirectivaNavigation).WithMany(p => p.TbMiembrosJuntaDirectivas)
                .HasForeignKey(d => d.IdJuntaDirectiva)
                .HasConstraintName("tb_miembros_junta_directiva_ibfk_1");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.TbMiembrosJuntaDirectivas)
                .HasForeignKey(d => d.IdPuesto)
                .HasConstraintName("tb_miembros_junta_directiva_ibfk_3");
        });

        modelBuilder.Entity<TbMovimientoEgreso>(entity =>
        {
            entity.HasKey(e => e.IdMovimientosEgresos).HasName("PRIMARY");

            entity.ToTable("tb_movimiento_egresos");

            entity.HasIndex(e => e.IdActa, "id_acta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdCheque, "id_cheque");

            entity.HasIndex(e => e.IdCuenta, "id_cuenta");

            entity.HasIndex(e => e.IdFactura, "id_factura");

            entity.HasIndex(e => e.IdTipoMovimiento, "id_tipo_movimiento");

            entity.Property(e => e.IdMovimientosEgresos)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimientos_egresos");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdCheque)
                .HasColumnType("int(11)")
                .HasColumnName("id_cheque");
            entity.Property(e => e.IdCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("id_cuenta");
            entity.Property(e => e.IdFactura)
                .HasColumnType("int(11)")
                .HasColumnName("id_factura");
            entity.Property(e => e.IdTipoMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_tipo_movimiento");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("tb_movimiento_egresos_ibfk_5");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_movimiento_egresos_ibfk_2");

            entity.HasOne(d => d.IdChequeNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdCheque)
                .HasConstraintName("tb_movimiento_egresos_ibfk_4");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdCuenta)
                .HasConstraintName("tb_movimiento_egresos_ibfk_3");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("tb_movimiento_egresos_ibfk_6");

            entity.HasOne(d => d.IdTipoMovimientoNavigation).WithMany(p => p.TbMovimientoEgresos)
                .HasForeignKey(d => d.IdTipoMovimiento)
                .HasConstraintName("tb_movimiento_egresos_ibfk_1");
        });

        modelBuilder.Entity<TbMovimientoIngreso>(entity =>
        {
            entity.HasKey(e => e.IdMovimientoIngresos).HasName("PRIMARY");

            entity.ToTable("tb_movimiento_ingresos");

            entity.HasIndex(e => e.IdActa, "id_acta");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdCliente, "id_cliente");

            entity.HasIndex(e => e.IdConcepto, "id_concepto");

            entity.HasIndex(e => e.IdCuenta, "id_cuenta");

            entity.HasIndex(e => e.IdDocumento, "id_documento");

            entity.HasIndex(e => e.IdTipoMovimientos, "id_tipo_movimientos");

            entity.Property(e => e.IdMovimientoIngresos)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimiento_ingresos");
            entity.Property(e => e.Detalle)
                .HasMaxLength(300)
                .HasColumnName("detalle");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");
            entity.Property(e => e.FechaComprobante).HasColumnName("fecha_comprobante");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdConcepto)
                .HasColumnType("int(11)")
                .HasColumnName("id_concepto");
            entity.Property(e => e.IdCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("id_cuenta");
            entity.Property(e => e.IdDocumento)
                .HasColumnType("int(11)")
                .HasColumnName("id_documento");
            entity.Property(e => e.IdTipoMovimientos)
                .HasColumnType("int(11)")
                .HasColumnName("id_tipo_movimientos");
            entity.Property(e => e.Monto)
                .HasPrecision(9, 2)
                .HasColumnName("monto");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_7");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_2");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_5");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdConcepto)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_4");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdCuenta)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_3");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_6");

            entity.HasOne(d => d.IdTipoMovimientosNavigation).WithMany(p => p.TbMovimientoIngresos)
                .HasForeignKey(d => d.IdTipoMovimientos)
                .HasConstraintName("tb_movimiento_ingresos_ibfk_1");
        });

        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PRIMARY");

            entity.ToTable("tb_proveedor");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Cedula)
                .HasMaxLength(30)
                .HasColumnName("cedula");
            entity.Property(e => e.Correo)
                .HasMaxLength(120)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(120)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .HasColumnName("estado");
            entity.Property(e => e.Fax)
                .HasMaxLength(60)
                .HasColumnName("fax");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbProveedors)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_proveedor_ibfk_1");
        });

        modelBuilder.Entity<TbPuesto>(entity =>
        {
            entity.HasKey(e => e.IdPuesto).HasName("PRIMARY");

            entity.ToTable("tb_puesto");

            entity.Property(e => e.IdPuesto)
                .HasColumnType("int(11)")
                .HasColumnName("id_puesto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbTipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoMovimiento).HasName("PRIMARY");

            entity.ToTable("tb_tipo_movimiento");

            entity.Property(e => e.IdTipoMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_tipo_movimiento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("tb_usuario");

            entity.HasIndex(e => e.IdRol, "id_rol");

            entity.Property(e => e.IdUser)
                .HasColumnType("int(11)")
                .HasColumnName("id_user");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(128)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .HasColumnName("correo");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .HasColumnName("estado");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.IdRol)
                .HasMaxLength(50)
                .HasColumnName("id_rol");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.TbUsuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("tb_usuario_tb_rol_ibfk_1");

        });

        modelBuilder.Entity<TbRol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PRIMARY");

            entity.ToTable("tb_rol");

            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
