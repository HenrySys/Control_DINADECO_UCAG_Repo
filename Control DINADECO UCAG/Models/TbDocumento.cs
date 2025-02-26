using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbDocumento
{
    public int IdDocumento { get; set; }

    public int? IdFactura { get; set; }

    public string? NumeroDocumento { get; set; }

    public DateOnly? FechaPago { get; set; }

    public int? IdAsociacion { get; set; }

    public decimal? Total { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbFactura? IdFacturaNavigation { get; set; }

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
