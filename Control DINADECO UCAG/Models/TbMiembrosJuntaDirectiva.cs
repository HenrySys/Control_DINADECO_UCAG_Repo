using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbMiembrosJuntaDirectiva
{
    public int IdMiembrosJuntaDirectiva { get; set; }

    public int? IdJuntaDirectiva { get; set; }

    public int? IdAsociado { get; set; }

    public int? IdPuesto { get; set; }

    public string? Estado { get; set; } = "Activo";

    public virtual TbAsociado? IdAsociadoNavigation { get; set; }

    public virtual TbJuntaDirectiva? IdJuntaDirectivaNavigation { get; set; }

    public virtual TbPuesto? IdPuestoNavigation { get; set; }
}
