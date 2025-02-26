using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbActum
{
    public int IdActa { get; set; }

    public DateOnly? FechaSesion { get; set; }

    public string? NumeroActa { get; set; }

    public int? IdAsociado { get; set; }

    public int? IdConcepto { get; set; }

    public decimal? Monto { get; set; }

    public string? Observacion { get; set; }

    public int? IdAsociacion { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbAsociado? IdAsociadoNavigation { get; set; }

    public virtual ICollection<TbAcuerdo> TbAcuerdos { get; set; } = new List<TbAcuerdo>();

    public virtual ICollection<TbInformeEconomico> TbInformeEconomicos { get; set; } = new List<TbInformeEconomico>();

    public virtual ICollection<TbJuntaDirectiva> TbJuntaDirectivas { get; set; } = new List<TbJuntaDirectiva>();

    public virtual ICollection<TbMovimientoEgreso> TbMovimientoEgresos { get; set; } = new List<TbMovimientoEgreso>();

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
