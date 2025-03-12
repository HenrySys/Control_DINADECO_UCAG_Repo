using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAsociacion
{
    public int IdAsociacion { get; set; }

    public string CedulaJuridica { get; set; } = null!;

    public string CodigoRegistro { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly FechaConstitucion { get; set; }

    public string Telefono { get; set; } = null!;

    public string Fax { get; set; }

    public string Correo { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public string Canton { get; set; } = null!;

    public string Distrito { get; set; } = null!;

    public string Pueblo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estado { get; set; } = "Activo";

    public virtual ICollection<TbActum> TbActa { get; set; } = new List<TbActum>();


    public virtual ICollection<TbAsociado> TbAsociados { get; set; } = new List<TbAsociado>();


    public virtual ICollection<TbCuenta> TbCuenta { get; set; } = new List<TbCuenta>();

    public virtual ICollection<TbCategoriaMovimiento> TbCategoriaMovimientos { get; set; } =  new List <TbCategoriaMovimiento>();

    public virtual ICollection<TbCliente> TbClientes { get; set; } = new List<TbCliente>();

    public virtual TbJuntaDirectiva? TbJuntaDirectiva { get; set; }


    public virtual ICollection<TbProveedor> TbProveedors { get; set; } = new List<TbProveedor>();

    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();

    public virtual ICollection<TbProyecto> TbProyectos { get; set; } = new List<TbProyecto>();
}
