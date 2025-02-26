using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAtractivo
{
    public int IdAtractivos { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public string? Descripcion { get; set; }

    public int? IdAsocWeb { get; set; }

    public string? Tipo { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacionWeb? IdAsocWebNavigation { get; set; }

    public virtual ICollection<TbFoto> TbFotos { get; set; } = new List<TbFoto>();
}
