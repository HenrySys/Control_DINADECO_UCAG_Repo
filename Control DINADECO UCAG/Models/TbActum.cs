using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbActum
{
    public int IdActa { get; set; }
    public int? IdAsociacion { get; set; }
    public int? IdAsociado { get; set; }
    public DateOnly? FechaSesion { get; set; }


    public string? NumeroActa { get; set; }
    public string? Descripcion { get; set; }
    public string? Estado { get; set; } = "En Proceso";
    public decimal? MontoTotalAcordado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbAsociado? IdAsociadoNavigation { get; set; }

    public virtual ICollection<TbAcuerdo> TbAcuerdos { get; set; } = new List<TbAcuerdo>();


    public virtual ICollection<TbJuntaDirectiva> TbJuntaDirectivas { get; set; } = new List<TbJuntaDirectiva>();

    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();

    public virtual ICollection<TbProyecto> TbProyectos { get; set; } = new List<TbProyecto>();
}
