using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbConcepto
{
    public int IdConcepto { get; set; }

    public int? IdAsociacion { get; set; }

    public string? Descripcion { get; set; }

    public bool? Aplicacion2 { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbFactura> TbFacturas { get; set; } = new List<TbFactura>();

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
