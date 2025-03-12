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

    public virtual DbSet<TbActaAsistencia> TbActaAsistencias { get; set; }

    public virtual DbSet<TbAcuerdo> TbAcuerdos { get; set; }

    public virtual DbSet<TbAsociacion> TbAsociacions { get; set; }

    public virtual DbSet<TbAsociado> TbAsociados { get; set; }

    public virtual DbSet<TbCategoriaMovimiento> TbCategoriaMovimientos { get; set; }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbCuenta> TbCuenta { get; set; }

    public virtual DbSet<TbJuntaDirectiva> TbJuntaDirectivas { get; set; }

    public virtual DbSet<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; }

    public virtual DbSet<TbMovimiento> TbMovimiento { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbProyecto> TbProyectos { get; set; }

    public virtual DbSet<TbPuesto> TbPuestos { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }


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
            entity.Property(e => e.MontoTotalAcordado)
                .HasPrecision(10, 2)
                .HasColumnName("monto_total_acordado");
            entity.Property(e => e.NumeroActa)
                .HasMaxLength(20)
                .HasColumnName("numero_acta");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(320)
                .HasColumnName("descripcion");

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
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroAcuerdo)
                .HasMaxLength(10)
                .HasColumnName("numero_acuerdo");
            entity.Property(e => e.MontoAcuerdo)
                .HasPrecision(10, 2)
                .HasColumnName("monto_acuerdo");


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
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
        });


        modelBuilder.Entity<TbAsociado>(entity =>
        {
            entity.HasKey(e => e.IdAsociado).HasName("PRIMARY");

            entity.ToTable("tb_asociado");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdUsuario, "id_usuario");

            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_usuario");
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
            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbAsociados)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_Usuario_Asociados");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbAsociados)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("tb_asociado_ibfk_1");
        });

        modelBuilder.Entity<TbCategoriaMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaMovimiento).HasName("PRIMARY");

            entity.ToTable("tb_categoria_movimiento");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.HasIndex(e => e.IdAsociado, "id_asociado");

            entity.Property(e => e.IdCategoriaMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_categoria_movimiento");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .HasColumnName("tipoMovimiento");
            entity.Property(e => e.TipoCategoria)
                .HasMaxLength(20)
                .HasColumnName("tipo_categoria");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(25)
                .HasColumnName("nombre_categoria");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(25)
                .HasColumnName("descripcion_categoria");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbCategoriaMovimientos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("fk_asociacion_categoria");

            entity.HasOne(d => d.IdAsociadoNavigation).WithMany(p => p.TbCategoriaMovimientos)
                .HasForeignKey(d => d.IdAsociado)
                .HasConstraintName("fk_asociado_categoria");


        }
        );


        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PRIMARY");

            entity.ToTable("tb_cliente");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");

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
            entity.Property(e => e.Cedula)
                .HasMaxLength(50)
                .HasColumnName("cedula");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");


            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbClientes)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("fk_tb_cliente_tb_asociacion");
        });


        modelBuilder.Entity<TbCuenta>(entity =>
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
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
            entity.Property(e => e.TituloCuenta)
                .HasMaxLength(30)
                .HasColumnName("titulo_cuenta");
            entity.Property(e => e.TipoCuenta)
                .HasMaxLength(30)
                .HasColumnName("tipo_cuenta");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbCuenta)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("fk_tb_cuenta_id_asociacion");
        });

        modelBuilder.Entity<TbDetalleMovimiento>(entity => 
        {
            entity.HasKey(e => e.IdDetalleMovimiento).HasName("PRIMARY");

            entity.ToTable("tb_detalle_movimiento");

            entity.HasIndex(e => e.IdMovimiento, "id_movimiento");

            entity.HasIndex(e => e.IdAcuerdo, "id_acuerdo");

            entity.Property(e => e.IdDetalleMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_detalle_movimiento");
            entity.Property(e => e.IdMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimiento");
            entity.Property(e => e.IdAcuerdo)
                .HasColumnType("int(11)")
                .HasColumnName("id_acuerdo");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .HasColumnName("tipo_movimiento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.Subtotal)
                .HasPrecision(10, 2)
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdMovimientoNavigation).WithMany(p => p.TbDetalleMovimientos)
                .HasForeignKey(d => d.IdMovimiento)
                .HasConstraintName("fk_tb_detalle_movimiento_tb_movimiento");

            entity.HasOne(d => d.IdAcuerdoNavigation).WithMany(p => p.TbDetalleMovimientos)
                .HasForeignKey(d => d.IdAcuerdo)
                .HasConstraintName("fk_tb_detalle_movimiento_tb_acuerdo");


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

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbJuntaDirectivas)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("fk_tb_junta_directiva_tb_acta");

            entity.HasOne(d => d.IdAsociacionNavigation).WithOne(p => p.TbJuntaDirectiva)
                .HasForeignKey<TbJuntaDirectiva>(d => d.IdAsociacion)
                .HasConstraintName("fk_tb_junta_directiva_tb_asociacion");
        });

        modelBuilder.Entity<TbMiembrosJuntaDirectiva>(entity =>
        {
            entity.HasKey(e => e.IdMiembrosJuntaDirectiva).HasName("PRIMARY");

            entity.ToTable("tb_miembro_junta_directiva");

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
                .HasConstraintName("fk_tb_miembros_junta_directiva_tb_asociado");

            entity.HasOne(d => d.IdJuntaDirectivaNavigation).WithMany(p => p.TbMiembrosJuntaDirectivas)
                .HasForeignKey(d => d.IdJuntaDirectiva)
                .HasConstraintName("fk_tb_miembro_junta_directiva_tb_junta_directiva");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.TbMiembrosJuntaDirectivas)
                .HasForeignKey(d => d.IdPuesto)
                .HasConstraintName("fk_tb_miembros_junta_directiva_tb_puesto");
        });



        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PRIMARY");

            entity.ToTable("tb_proveedor");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");

            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("id_proveedor");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.CedulaJudirica)
                .HasMaxLength(50)
                .HasColumnName("cedula_juridica");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(50)
                .HasColumnName("nombre_contacto");
            entity.Property(e => e.CedulaContacto)
                .HasMaxLength(50)
                .HasColumnName("cedula_contacto");
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
            entity.Property(e => e.Nombre_Empresa)
                .HasMaxLength(30)
                .HasColumnName("nombre_empresa");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbProveedors)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("fk_tb_proveedor_tb_asociacion");
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
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
        });



        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.ToTable("tb_usuario");


            entity.Property(e => e.IdUsuario)
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
            entity.Property(e => e.Rol)
                .HasMaxLength(30)
                .HasColumnName("rol");

        });

        modelBuilder.Entity<TbMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento);
            entity.ToTable("tb_movimiento");

            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");
            entity.HasIndex(e => e.IdAsociado, "id_asociado");
            entity.HasIndex(e => e.IdCategoriaMovimiento, "id_categoria_movimiento");
            entity.HasIndex(e => e.IdProyecto, "id_proyecto");
            entity.HasIndex(e => e.IdCuenta, "id_cuenta");
            entity.HasIndex(e => e.IdActa, "id_acta");
            entity.HasIndex(e => e.IdProveedor, "id_proveedor");
            entity.HasIndex(e => e.IdCliente, "id_cliente");

            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .HasColumnName("tipo_movimiento")
                .HasDefaultValue("Ingresos");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.FuenteFondo)
                .HasMaxLength(20)
                .HasColumnName("fuente_fondo")
                .HasDefaultValue("Fondos Propios");
            entity.Property(e => e.IdCategoriaMovimiento)
                .HasColumnType("int(11)")
                .HasColumnName("id_categoria_movimiento");
            entity.Property(e => e.IdProyecto)
                .HasColumnType("int(11)")
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdCuenta)
                .HasColumnType("int(11)")
                .HasColumnName("id_cuenta");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdProveedor)
                .HasColumnType("int(11)")
                .HasColumnName("id_proveedor");
            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(20)
                .HasColumnName("metodo_pago")
                .HasDefaultValue("Efectivo");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.SubtotalMovido)
                .HasPrecision(10, 2)
                .HasColumnName("subtotal_movido");
            entity.Property(e => e.MontoTotalMovido)
                .HasPrecision(10, 2)
                .HasColumnName("monto_total_movido");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");



            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdAsociacion)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdCuentaNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdActaNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdActa)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdProveedorNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdCategoriaMovimientoNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdCategoriaMovimiento)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdProyectoNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdProyecto)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.IdAsociadoNavigation)
                .WithMany(p => p.TbMovimientos)
                .HasForeignKey(d => d.IdAsociado)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<TbProyecto>(entity =>
        {
            entity.HasKey(e => e.IdProyecto).HasName("PRIMARY");
            entity.ToTable("tb_proyecto");
            entity.HasIndex(e => e.IdAsociacion, "id_asociacion");
            entity.HasIndex(e => e.IdActa, "id_acta");
            entity.HasIndex(e => e.IdAsociado, "id_asociado");

            entity.Property(e => e.IdProyecto)
                .HasColumnType("int(11)")
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdAsociacion)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociacion");
            entity.Property(e => e.IdActa)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.MontoTotalDestinado)
                .HasPrecision(10, 2)
                .HasColumnName("monto_total_destinado");

            entity.HasOne(d => d.IdAsociacionNavigation).WithMany(p => p.TbProyectos)
                .HasForeignKey(d => d.IdAsociacion)
                .HasConstraintName("fk_tb_proyecto_tb_asociacion");

            entity.HasOne(d => d.IdActaNavigation).WithMany(p => p.TbProyectos)
                .HasForeignKey(d => d.IdActa)
                .HasConstraintName("fk_tb_proyecto_tb_acta");

            entity.HasOne(d => d.IdAsociadoNavigation).WithMany(p => p.TbProyectos)
                .HasForeignKey(d => d.IdAsociado)
                .HasConstraintName("fk_tb_proyecto_tb_asociado");
        });

        modelBuilder.Entity<TbActaAsistencia>(entity =>
        {
            entity.HasKey(e => e.IdActaAsistencia).HasName("PRIMARY");

            entity.ToTable("tb_acta_asistencia");

            entity.HasIndex(e => e.IdAsociado, "id_asociado");

            entity.Property(e => e.IdActaAsistencia)
                .HasColumnType("int(11)")
                .HasColumnName("id_acta_asistencia");
            entity.Property(e => e.IdAsociado)
                .HasColumnType("int(11)")
                .HasColumnName("id_asociado");

            entity.HasOne(d => d.IdAsociadoNavigation).WithMany(p => p.TbActaAsistencias)
                .HasForeignKey(d => d.IdAsociado)
                .HasConstraintName("fk_tb_acta_asistencia_tb_asociado");

        });




        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
