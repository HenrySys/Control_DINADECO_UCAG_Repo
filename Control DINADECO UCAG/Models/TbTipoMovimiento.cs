using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbTipoMovimiento
{
    public int IdTipoMovimiento { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
