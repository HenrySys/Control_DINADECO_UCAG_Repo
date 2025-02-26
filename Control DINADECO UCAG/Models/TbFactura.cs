using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbFactura
{
    public int IdFactura { get; set; }

    public string? NumeroFactura { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Total { get; set; }

    public int? IdProveedor { get; set; }

    public string? Detalle { get; set; }

    public int? IdConcepto { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Impuestos { get; set; }

    public decimal? Descuento { get; set; }

    public string? Estado { get; set; }

    public virtual TbConcepto? IdConceptoNavigation { get; set; }

    public virtual TbProveedor? IdProveedorNavigation { get; set; }

    public virtual ICollection<TbDetalleFactura> TbDetalleFacturas { get; set; } = new List<TbDetalleFactura>();

    public virtual ICollection<TbDocumento> TbDocumentos { get; set; } = new List<TbDocumento>();

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();
}
