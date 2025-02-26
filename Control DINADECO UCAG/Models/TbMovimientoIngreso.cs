using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbMovimientoIngreso
{
    public int IdMovimientoIngresos { get; set; }

    public int? IdTipoMovimientos { get; set; }

    public int? IdAsociacion { get; set; }

    public int? IdCuenta { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdCliente { get; set; }

    public int? IdDocumento { get; set; }

    public DateOnly? FechaComprobante { get; set; }

    public string? Detalle { get; set; }

    public decimal? Monto { get; set; }

    public int? IdActa { get; set; }

    public string? Estado { get; set; }

    public virtual TbActum? IdActaNavigation { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbCliente? IdClienteNavigation { get; set; }

    public virtual TbConcepto? IdConceptoNavigation { get; set; }

    public virtual TbCuentum? IdCuentaNavigation { get; set; }

    public virtual TbDocumento? IdDocumentoNavigation { get; set; }

    public virtual TbTipoMovimiento? IdTipoMovimientosNavigation { get; set; }

    public virtual ICollection<TbDetalleIngreso> TbDetalleIngresos { get; set; } = new List<TbDetalleIngreso>();
}
