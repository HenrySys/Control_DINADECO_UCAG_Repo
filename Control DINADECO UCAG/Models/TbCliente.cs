using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbCliente
{
    public int IdCliente { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<TbMovimientoIngreso> TbMovimientoIngresos { get; set; } = new List<TbMovimientoIngreso>();
}
