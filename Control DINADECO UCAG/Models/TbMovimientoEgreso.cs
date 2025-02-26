using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbMovimientoEgreso
{
    public int IdMovimientosEgresos { get; set; }

    public int? IdTipoMovimiento { get; set; }

    public int? IdAsociacion { get; set; }

    public int? IdCuenta { get; set; }

    public int? IdCheque { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? IdActa { get; set; }

    public int? IdFactura { get; set; }

    public string? Estado { get; set; }

    public virtual TbActum? IdActaNavigation { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbCheque? IdChequeNavigation { get; set; }

    public virtual TbCuentum? IdCuentaNavigation { get; set; }

    public virtual TbFactura? IdFacturaNavigation { get; set; }

    public virtual TbTipoMovimiento? IdTipoMovimientoNavigation { get; set; }

    public virtual ICollection<TbDetalleEgreso> TbDetalleEgresos { get; set; } = new List<TbDetalleEgreso>();
}
