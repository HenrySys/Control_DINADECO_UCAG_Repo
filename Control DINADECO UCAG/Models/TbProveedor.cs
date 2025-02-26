using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbProveedor
{
    public int IdProveedor { get; set; }

    public int? IdAsociacion { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Correo { get; set; }

    public string? Estado { get; set; }

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbCheque> TbCheques { get; set; } = new List<TbCheque>();

    public virtual ICollection<TbFactura> TbFacturas { get; set; } = new List<TbFactura>();
}
