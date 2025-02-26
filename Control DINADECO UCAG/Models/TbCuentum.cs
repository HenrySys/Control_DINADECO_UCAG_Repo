using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbCuentum
{
    public int IdCuenta { get; set; }

    public int NumeroCuenta { get; set; }

    public decimal? Saldo { get; set; }

    public int? IdAsociacion { get; set; }

    public string? Tipo { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbCheque> TbCheques { get; set; } = new List<TbCheque>();

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
