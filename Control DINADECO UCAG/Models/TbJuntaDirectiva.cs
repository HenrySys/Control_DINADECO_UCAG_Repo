using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbJuntaDirectiva
{
    public int IdJuntaDirectiva { get; set; }

    public int? IdAsociacion { get; set; }

    public int? IdActa { get; set; }

    public DateOnly? PeriodoInicio { get; set; }

    public DateOnly? PeriodoFin { get; set; }

    public string? Nombre { get; set; } = null!;

    public string? Estado { get; set; } = "Activo";

    public virtual TbActum? IdActaNavigation { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; } = new List<TbMiembrosJuntaDirectiva>();
}
