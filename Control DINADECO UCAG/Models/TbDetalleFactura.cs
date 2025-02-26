using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbDetalleFactura
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? MontoTotal { get; set; }

    public int? IdFactura { get; set; }

    public virtual TbFactura? IdFacturaNavigation { get; set; }
}
