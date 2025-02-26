using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbDetalleIngreso
{
    public int IdDetalleIngreso { get; set; }

    public int? IdMovimientoIngreso { get; set; }

    public decimal? Total { get; set; }

    public int? IdInformeEconomico { get; set; }

    public virtual TbInformeEconomico? IdInformeEconomicoNavigation { get; set; }

    public virtual TbMovimientoIngreso? IdMovimientoIngresoNavigation { get; set; }
}
