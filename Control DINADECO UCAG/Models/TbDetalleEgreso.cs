using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbDetalleEgreso
{
    public int IdDetalleEgreso { get; set; }

    public int? IdMovimientoEgreso { get; set; }

    public decimal? Total { get; set; }

    public int? IdInformeEconomico { get; set; }

    public virtual TbInformeEconomico? IdInformeEconomicoNavigation { get; set; }

    public virtual TbMovimientoEgreso? IdMovimientoEgresoNavigation { get; set; }
}
