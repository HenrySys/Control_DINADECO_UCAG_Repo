using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbCliente
{
    public int IdCliente { get; set; }

    public int IdAsociacion { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Estado { get; set; } = "Activo";

    public virtual TbAsociacion IdAsociacionNavigation { get; set; } = null!;


    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();
}
