using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAsociado
{
    public int IdAsociado { get; set; }

    public int? IdAsociacion { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Cedula { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbActum> TbActa { get; set; } = new List<TbActum>();

    public virtual ICollection<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; } = new List<TbMiembrosJuntaDirectiva>();
}
