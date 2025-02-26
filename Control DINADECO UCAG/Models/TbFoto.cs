using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbFoto
{
    public int IdFotos { get; set; }

    public string? Descripcion { get; set; }

    public string? RutaFoto { get; set; }

    public int? IdAtractivos { get; set; }

    public virtual TbAtractivo? IdAtractivosNavigation { get; set; }
}
