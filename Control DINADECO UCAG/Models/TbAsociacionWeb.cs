using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAsociacionWeb
{
    public int IdAsocWeb { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public int? IdAsociacion { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbAtractivo> TbAtractivos { get; set; } = new List<TbAtractivo>();
}
