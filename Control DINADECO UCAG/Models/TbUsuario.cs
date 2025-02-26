using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbUsuario
{
    public int IdUser { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Contraseña { get; set; }

    public int IdRol { get; set; }

    public string? Correo { get; set; }

    public string? Estado { get; set; }

    public virtual TbRol? IdRolNavigation { get; set; }
}
