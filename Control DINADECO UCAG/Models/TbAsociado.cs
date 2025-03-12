using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbAsociado
{
    public int IdAsociado { get; set; }

    public int IdAsociacion { get; set; }

    public int IdUsuario { get; set; }

    public string Nacionalidad { get; set; } = null!;
     
    public string Cedula { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;          

    public string Nombre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public string EstadoCivil { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Estado { get; set; } = "Activo";

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual TbUsuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<TbCategoriaMovimiento> TbCategoriaMovimientos { get; set; } = new List<TbCategoriaMovimiento>();

    public virtual ICollection<TbActum> TbActa { get; set; } = new List<TbActum>();

    public virtual ICollection<TbMiembrosJuntaDirectiva> TbMiembrosJuntaDirectivas { get; set; } = new List<TbMiembrosJuntaDirectiva>();

    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();

    public virtual ICollection<TbProyecto> TbProyectos { get; set; } = new List<TbProyecto>();

    public virtual ICollection<TbActaAsistencia> TbActaAsistencias { get; set; } = new List<TbActaAsistencia>();
}
