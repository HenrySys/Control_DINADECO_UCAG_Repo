using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbCheque
{
    public int IdCheque { get; set; }

    public int NoCheque { get; set; }

    public decimal? Monto { get; set; }

    public int? IdCuenta { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? IdGirado { get; set; }

    public string? Estado { get; set; }

    public virtual TbCuentum? IdCuentaNavigation { get; set; }

    public virtual TbProveedor? IdGiradoNavigation { get; set; }

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();
}
