using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control_DINADECO_UCAG.Migrations
{
    /// <inheritdoc />
    public partial class Seguimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_general_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_asociacion",
                columns: table => new
                {
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cedula_juridica = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_registro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha_constitucion = table.Column<DateOnly>(type: "date", nullable: true),
                    telefono = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fax = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    provincia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    canton = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    distrito = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pueblo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_asociacion);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    apellido_1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido_2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_puesto",
                columns: table => new
                {
                    id_puesto = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_puesto);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_tipo_movimiento",
                columns: table => new
                {
                    id_tipo_movimiento = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_tipo_movimiento);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_usuario",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre_usuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contraseña = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo_usuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_user);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_asociacion_web",
                columns: table => new
                {
                    id_asoc_web = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    latitud = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    longitud = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_asoc_web);
                    table.ForeignKey(
                        name: "tb_asociacion_web_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_asociado",
                columns: table => new
                {
                    id_asociado = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    nacionalidad = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cedula = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido_1 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apellido_2 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha_nacimiento = table.Column<DateOnly>(type: "date", nullable: true),
                    sexo = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado_civil = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    direccion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_asociado);
                    table.ForeignKey(
                        name: "tb_asociado_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_concepto",
                columns: table => new
                {
                    id_concepto = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    descripcion = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    aplicacion_2 = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_concepto);
                    table.ForeignKey(
                        name: "tb_concepto_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_cuenta",
                columns: table => new
                {
                    id_cuenta = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numero_cuenta = table.Column<int>(type: "int(11)", nullable: false),
                    saldo = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    tipo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_cuenta);
                    table.ForeignKey(
                        name: "tb_cuenta_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_proveedor",
                columns: table => new
                {
                    id_proveedor = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cedula = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    direccion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fax = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_proveedor);
                    table.ForeignKey(
                        name: "tb_proveedor_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_atractivos",
                columns: table => new
                {
                    id_atractivos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    latitud = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    longitud = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descripcion = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_asoc_web = table.Column<int>(type: "int(11)", nullable: true),
                    tipo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_atractivos);
                    table.ForeignKey(
                        name: "tb_atractivos_ibfk_1",
                        column: x => x.id_asoc_web,
                        principalTable: "tb_asociacion_web",
                        principalColumn: "id_asoc_web");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_acta",
                columns: table => new
                {
                    id_acta = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha_sesion = table.Column<DateOnly>(type: "date", nullable: true),
                    numero_acta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_asociado = table.Column<int>(type: "int(11)", nullable: true),
                    id_concepto = table.Column<int>(type: "int(11)", nullable: true),
                    monto = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    observacion = table.Column<string>(type: "varchar(320)", maxLength: 320, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_acta);
                    table.ForeignKey(
                        name: "tb_acta_ibfk_1",
                        column: x => x.id_asociado,
                        principalTable: "tb_asociado",
                        principalColumn: "id_asociado");
                    table.ForeignKey(
                        name: "tb_acta_ibfk_2",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_cheque",
                columns: table => new
                {
                    id_cheque = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    no_cheque = table.Column<int>(type: "int(11)", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    id_cuenta = table.Column<int>(type: "int(11)", nullable: true),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    id_girado = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_cheque);
                    table.ForeignKey(
                        name: "tb_cheque_ibfk_1",
                        column: x => x.id_cuenta,
                        principalTable: "tb_cuenta",
                        principalColumn: "id_cuenta");
                    table.ForeignKey(
                        name: "tb_cheque_ibfk_2",
                        column: x => x.id_girado,
                        principalTable: "tb_proveedor",
                        principalColumn: "id_proveedor");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_factura",
                columns: table => new
                {
                    id_factura = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numero_factura = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    total = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    id_proveedor = table.Column<int>(type: "int(11)", nullable: true),
                    detalle = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_concepto = table.Column<int>(type: "int(11)", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    impuestos = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    descuento = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_factura);
                    table.ForeignKey(
                        name: "tb_factura_ibfk_1",
                        column: x => x.id_proveedor,
                        principalTable: "tb_proveedor",
                        principalColumn: "id_proveedor");
                    table.ForeignKey(
                        name: "tb_factura_ibfk_2",
                        column: x => x.id_concepto,
                        principalTable: "tb_concepto",
                        principalColumn: "id_concepto");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_fotos",
                columns: table => new
                {
                    id_fotos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ruta_foto = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_atractivos = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_fotos);
                    table.ForeignKey(
                        name: "tb_fotos_ibfk_1",
                        column: x => x.id_atractivos,
                        principalTable: "tb_atractivos",
                        principalColumn: "id_atractivos");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_acuerdo",
                columns: table => new
                {
                    id_acuerdo = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numero_acuerdo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descripcion = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_acta = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_acuerdo);
                    table.ForeignKey(
                        name: "tb_acuerdo_ibfk_1",
                        column: x => x.id_acta,
                        principalTable: "tb_acta",
                        principalColumn: "id_acta");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_informe_economico",
                columns: table => new
                {
                    id_informe_economico = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_acta = table.Column<int>(type: "int(11)", nullable: true),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    total_egresos = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    total_ingresos = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    fecha_actualizacion = table.Column<DateOnly>(type: "date", nullable: true),
                    fecha_informe = table.Column<DateOnly>(type: "date", nullable: true),
                    estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_informe_economico);
                    table.ForeignKey(
                        name: "tb_informe_economico_ibfk_1",
                        column: x => x.id_acta,
                        principalTable: "tb_acta",
                        principalColumn: "id_acta");
                    table.ForeignKey(
                        name: "tb_informe_economico_ibfk_2",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_junta_directiva",
                columns: table => new
                {
                    id_junta_directiva = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    id_acta = table.Column<int>(type: "int(11)", nullable: true),
                    periodo_inicio = table.Column<DateOnly>(type: "date", nullable: true),
                    periodo_fin = table.Column<DateOnly>(type: "date", nullable: true),
                    estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_junta_directiva);
                    table.ForeignKey(
                        name: "tb_junta_directiva_ibfk_1",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                    table.ForeignKey(
                        name: "tb_junta_directiva_ibfk_2",
                        column: x => x.id_acta,
                        principalTable: "tb_acta",
                        principalColumn: "id_acta");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_detalle_factura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cantidad = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    precio_unitario = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    monto_total = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    id_factura = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "tb_detalle_factura_ibfk_1",
                        column: x => x.id_factura,
                        principalTable: "tb_factura",
                        principalColumn: "id_factura");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_documento",
                columns: table => new
                {
                    id_documento = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_factura = table.Column<int>(type: "int(11)", nullable: true),
                    numero_documento = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecha_pago = table.Column<DateOnly>(type: "date", nullable: true),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    descripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_documento);
                    table.ForeignKey(
                        name: "tb_documento_ibfk_1",
                        column: x => x.id_factura,
                        principalTable: "tb_factura",
                        principalColumn: "id_factura");
                    table.ForeignKey(
                        name: "tb_documento_ibfk_2",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_movimiento_egresos",
                columns: table => new
                {
                    id_movimientos_egresos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_tipo_movimiento = table.Column<int>(type: "int(11)", nullable: true),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    id_cuenta = table.Column<int>(type: "int(11)", nullable: true),
                    id_cheque = table.Column<int>(type: "int(11)", nullable: true),
                    fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    id_acta = table.Column<int>(type: "int(11)", nullable: true),
                    id_factura = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_movimientos_egresos);
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_1",
                        column: x => x.id_tipo_movimiento,
                        principalTable: "tb_tipo_movimiento",
                        principalColumn: "id_tipo_movimiento");
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_2",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_3",
                        column: x => x.id_cuenta,
                        principalTable: "tb_cuenta",
                        principalColumn: "id_cuenta");
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_4",
                        column: x => x.id_cheque,
                        principalTable: "tb_cheque",
                        principalColumn: "id_cheque");
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_5",
                        column: x => x.id_acta,
                        principalTable: "tb_acta",
                        principalColumn: "id_acta");
                    table.ForeignKey(
                        name: "tb_movimiento_egresos_ibfk_6",
                        column: x => x.id_factura,
                        principalTable: "tb_factura",
                        principalColumn: "id_factura");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_miembros_junta_directiva",
                columns: table => new
                {
                    id_miembros_junta_directiva = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_junta_directiva = table.Column<int>(type: "int(11)", nullable: true),
                    id_asociado = table.Column<int>(type: "int(11)", nullable: true),
                    id_puesto = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_miembros_junta_directiva);
                    table.ForeignKey(
                        name: "tb_miembros_junta_directiva_ibfk_1",
                        column: x => x.id_junta_directiva,
                        principalTable: "tb_junta_directiva",
                        principalColumn: "id_junta_directiva");
                    table.ForeignKey(
                        name: "tb_miembros_junta_directiva_ibfk_2",
                        column: x => x.id_asociado,
                        principalTable: "tb_asociado",
                        principalColumn: "id_asociado");
                    table.ForeignKey(
                        name: "tb_miembros_junta_directiva_ibfk_3",
                        column: x => x.id_puesto,
                        principalTable: "tb_puesto",
                        principalColumn: "id_puesto");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_movimiento_ingresos",
                columns: table => new
                {
                    id_movimiento_ingresos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_tipo_movimientos = table.Column<int>(type: "int(11)", nullable: true),
                    id_asociacion = table.Column<int>(type: "int(11)", nullable: true),
                    id_cuenta = table.Column<int>(type: "int(11)", nullable: true),
                    id_concepto = table.Column<int>(type: "int(11)", nullable: true),
                    id_cliente = table.Column<int>(type: "int(11)", nullable: true),
                    id_documento = table.Column<int>(type: "int(11)", nullable: true),
                    fecha_comprobante = table.Column<DateOnly>(type: "date", nullable: true),
                    detalle = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    monto = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    id_acta = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_movimiento_ingresos);
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_1",
                        column: x => x.id_tipo_movimientos,
                        principalTable: "tb_tipo_movimiento",
                        principalColumn: "id_tipo_movimiento");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_2",
                        column: x => x.id_asociacion,
                        principalTable: "tb_asociacion",
                        principalColumn: "id_asociacion");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_3",
                        column: x => x.id_cuenta,
                        principalTable: "tb_cuenta",
                        principalColumn: "id_cuenta");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_4",
                        column: x => x.id_concepto,
                        principalTable: "tb_concepto",
                        principalColumn: "id_concepto");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_5",
                        column: x => x.id_cliente,
                        principalTable: "tb_cliente",
                        principalColumn: "id_cliente");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_6",
                        column: x => x.id_documento,
                        principalTable: "tb_documento",
                        principalColumn: "id_documento");
                    table.ForeignKey(
                        name: "tb_movimiento_ingresos_ibfk_7",
                        column: x => x.id_acta,
                        principalTable: "tb_acta",
                        principalColumn: "id_acta");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_detalle_egreso",
                columns: table => new
                {
                    id_detalle_egreso = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_movimiento_egreso = table.Column<int>(type: "int(11)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    id_informe_economico = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_detalle_egreso);
                    table.ForeignKey(
                        name: "tb_detalle_egreso_ibfk_1",
                        column: x => x.id_movimiento_egreso,
                        principalTable: "tb_movimiento_egresos",
                        principalColumn: "id_movimientos_egresos");
                    table.ForeignKey(
                        name: "tb_detalle_egreso_ibfk_2",
                        column: x => x.id_informe_economico,
                        principalTable: "tb_informe_economico",
                        principalColumn: "id_informe_economico");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tb_detalle_ingreso",
                columns: table => new
                {
                    id_detalle_ingreso = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_movimiento_ingreso = table.Column<int>(type: "int(11)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: true),
                    id_informe_economico = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_detalle_ingreso);
                    table.ForeignKey(
                        name: "tb_detalle_ingreso_ibfk_1",
                        column: x => x.id_movimiento_ingreso,
                        principalTable: "tb_movimiento_ingresos",
                        principalColumn: "id_movimiento_ingresos");
                    table.ForeignKey(
                        name: "tb_detalle_ingreso_ibfk_2",
                        column: x => x.id_informe_economico,
                        principalTable: "tb_informe_economico",
                        principalColumn: "id_informe_economico");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "id_asociacion",
                table: "tb_acta",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_asociado",
                table: "tb_acta",
                column: "id_asociado");

            migrationBuilder.CreateIndex(
                name: "id_acta",
                table: "tb_acuerdo",
                column: "id_acta");

            migrationBuilder.CreateIndex(
                name: "cedula_juridica",
                table: "tb_asociacion",
                column: "cedula_juridica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "codigo_registro",
                table: "tb_asociacion",
                column: "codigo_registro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_asociacion1",
                table: "tb_asociacion_web",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_asociacion2",
                table: "tb_asociado",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_asoc_web",
                table: "tb_atractivos",
                column: "id_asoc_web");

            migrationBuilder.CreateIndex(
                name: "id_cuenta",
                table: "tb_cheque",
                column: "id_cuenta");

            migrationBuilder.CreateIndex(
                name: "id_girado",
                table: "tb_cheque",
                column: "id_girado");

            migrationBuilder.CreateIndex(
                name: "no_cheque",
                table: "tb_cheque",
                column: "no_cheque",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_asociacion3",
                table: "tb_concepto",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_asociacion4",
                table: "tb_cuenta",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "numero_cuenta",
                table: "tb_cuenta",
                column: "numero_cuenta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_informe_economico",
                table: "tb_detalle_egreso",
                column: "id_informe_economico");

            migrationBuilder.CreateIndex(
                name: "id_movimiento_egreso",
                table: "tb_detalle_egreso",
                column: "id_movimiento_egreso");

            migrationBuilder.CreateIndex(
                name: "id_factura",
                table: "tb_detalle_factura",
                column: "id_factura");

            migrationBuilder.CreateIndex(
                name: "id_informe_economico1",
                table: "tb_detalle_ingreso",
                column: "id_informe_economico");

            migrationBuilder.CreateIndex(
                name: "id_movimiento_ingreso",
                table: "tb_detalle_ingreso",
                column: "id_movimiento_ingreso");

            migrationBuilder.CreateIndex(
                name: "id_asociacion5",
                table: "tb_documento",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_factura1",
                table: "tb_documento",
                column: "id_factura");

            migrationBuilder.CreateIndex(
                name: "id_concepto",
                table: "tb_factura",
                column: "id_concepto");

            migrationBuilder.CreateIndex(
                name: "id_proveedor",
                table: "tb_factura",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "id_atractivos",
                table: "tb_fotos",
                column: "id_atractivos");

            migrationBuilder.CreateIndex(
                name: "id_acta1",
                table: "tb_informe_economico",
                column: "id_acta");

            migrationBuilder.CreateIndex(
                name: "id_asociacion6",
                table: "tb_informe_economico",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_acta2",
                table: "tb_junta_directiva",
                column: "id_acta");

            migrationBuilder.CreateIndex(
                name: "id_asociacion7",
                table: "tb_junta_directiva",
                column: "id_asociacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_asociado1",
                table: "tb_miembros_junta_directiva",
                column: "id_asociado");

            migrationBuilder.CreateIndex(
                name: "id_junta_directiva",
                table: "tb_miembros_junta_directiva",
                column: "id_junta_directiva");

            migrationBuilder.CreateIndex(
                name: "id_puesto",
                table: "tb_miembros_junta_directiva",
                column: "id_puesto");

            migrationBuilder.CreateIndex(
                name: "id_acta3",
                table: "tb_movimiento_egresos",
                column: "id_acta");

            migrationBuilder.CreateIndex(
                name: "id_asociacion8",
                table: "tb_movimiento_egresos",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_cheque",
                table: "tb_movimiento_egresos",
                column: "id_cheque");

            migrationBuilder.CreateIndex(
                name: "id_cuenta1",
                table: "tb_movimiento_egresos",
                column: "id_cuenta");

            migrationBuilder.CreateIndex(
                name: "id_factura2",
                table: "tb_movimiento_egresos",
                column: "id_factura");

            migrationBuilder.CreateIndex(
                name: "id_tipo_movimiento",
                table: "tb_movimiento_egresos",
                column: "id_tipo_movimiento");

            migrationBuilder.CreateIndex(
                name: "id_acta4",
                table: "tb_movimiento_ingresos",
                column: "id_acta");

            migrationBuilder.CreateIndex(
                name: "id_asociacion9",
                table: "tb_movimiento_ingresos",
                column: "id_asociacion");

            migrationBuilder.CreateIndex(
                name: "id_cliente",
                table: "tb_movimiento_ingresos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "id_concepto1",
                table: "tb_movimiento_ingresos",
                column: "id_concepto");

            migrationBuilder.CreateIndex(
                name: "id_cuenta2",
                table: "tb_movimiento_ingresos",
                column: "id_cuenta");

            migrationBuilder.CreateIndex(
                name: "id_documento",
                table: "tb_movimiento_ingresos",
                column: "id_documento");

            migrationBuilder.CreateIndex(
                name: "id_tipo_movimientos",
                table: "tb_movimiento_ingresos",
                column: "id_tipo_movimientos");

            migrationBuilder.CreateIndex(
                name: "id_asociacion10",
                table: "tb_proveedor",
                column: "id_asociacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_acuerdo");

            migrationBuilder.DropTable(
                name: "tb_detalle_egreso");

            migrationBuilder.DropTable(
                name: "tb_detalle_factura");

            migrationBuilder.DropTable(
                name: "tb_detalle_ingreso");

            migrationBuilder.DropTable(
                name: "tb_fotos");

            migrationBuilder.DropTable(
                name: "tb_miembros_junta_directiva");

            migrationBuilder.DropTable(
                name: "tb_usuario");

            migrationBuilder.DropTable(
                name: "tb_movimiento_egresos");

            migrationBuilder.DropTable(
                name: "tb_movimiento_ingresos");

            migrationBuilder.DropTable(
                name: "tb_informe_economico");

            migrationBuilder.DropTable(
                name: "tb_atractivos");

            migrationBuilder.DropTable(
                name: "tb_junta_directiva");

            migrationBuilder.DropTable(
                name: "tb_puesto");

            migrationBuilder.DropTable(
                name: "tb_cheque");

            migrationBuilder.DropTable(
                name: "tb_tipo_movimiento");

            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_documento");

            migrationBuilder.DropTable(
                name: "tb_asociacion_web");

            migrationBuilder.DropTable(
                name: "tb_acta");

            migrationBuilder.DropTable(
                name: "tb_cuenta");

            migrationBuilder.DropTable(
                name: "tb_factura");

            migrationBuilder.DropTable(
                name: "tb_asociado");

            migrationBuilder.DropTable(
                name: "tb_proveedor");

            migrationBuilder.DropTable(
                name: "tb_concepto");

            migrationBuilder.DropTable(
                name: "tb_asociacion");

            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_general_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
