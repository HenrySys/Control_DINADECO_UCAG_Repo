using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbUsuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Rol { get; set; } = "Admin";

    public string Correo { get; set; } = null!;

    public string Estado { get; set; } = "Activo";

    public virtual ICollection <TbAsociado> TbAsociados { get; set; } = new List<TbAsociado>();



}
