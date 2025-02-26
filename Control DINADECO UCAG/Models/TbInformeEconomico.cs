using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbInformeEconomico
{
    public int IdInformeEconomico { get; set; }

    public int? IdActa { get; set; }

    public int? IdAsociacion { get; set; }

    public decimal? TotalEgresos { get; set; }

    public decimal? TotalIngresos { get; set; }

    public DateOnly? FechaActualizacion { get; set; }

    public DateOnly? FechaInforme { get; set; }

    public string? Estado { get; set; }

    public virtual TbActum? IdActaNavigation { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbDetalleEgreso> TbDetalleEgresos { get; set; } = new List<TbDetalleEgreso>();

    public virtual ICollection<TbDetalleIngreso> TbDetalleIngresos { get; set; } = new List<TbDetalleIngreso>();
}
