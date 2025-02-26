using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAsociacion
{
    public int IdAsociacion { get; set; }

    public string CedulaJuridica { get; set; } = null!;

    public string CodigoRegistro { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateOnly? FechaConstitucion { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Correo { get; set; }

    public string? Provincia { get; set; }

    public string? Canton { get; set; }

    public string? Distrito { get; set; }

    public string? Pueblo { get; set; }

    public string? Direccion { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<TbActum> TbActa { get; set; } = new List<TbActum>();

    public virtual ICollection<TbAsociacionWeb> TbAsociacionWebs { get; set; } = new List<TbAsociacionWeb>();

    public virtual ICollection<TbAsociado> TbAsociados { get; set; } = new List<TbAsociado>();

    public virtual ICollection<TbConcepto> TbConceptos { get; set; } = new List<TbConcepto>();

    public virtual ICollection<TbCuentum> TbCuenta { get; set; } = new List<TbCuentum>();

    public virtual ICollection<TbDocumento> TbDocumentos { get; set; } = new List<TbDocumento>();

    public virtual ICollection<TbInformeEconomico> TbInformeEconomicos { get; set; } = new List<TbInformeEconomico>();

    public virtual TbJuntaDirectiva? TbJuntaDirectiva { get; set; }

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();

    public virtual ICollection<TbProveedor> TbProveedors { get; set; } = new List<TbProveedor>();
}
