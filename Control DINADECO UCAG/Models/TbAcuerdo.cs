﻿using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAcuerdo
{
    public int IdAcuerdo { get; set; }
    public int? IdActa { get; set; }

    public string? NumeroAcuerdo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? MontoAcuerdo { get; set; }

    public virtual TbActum? IdActaNavigation { get; set; }

    public virtual ICollection<TbDetalleMovimiento> TbDetalleMovimientos { get; set; } = new List<TbDetalleMovimiento>();
}
