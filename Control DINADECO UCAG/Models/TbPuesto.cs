using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbPuesto
{
    public int IdPuesto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; } = new List<TbMiembrosJuntaDirectiva>();
}
