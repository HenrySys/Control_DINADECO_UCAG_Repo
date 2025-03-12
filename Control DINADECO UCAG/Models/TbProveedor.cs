using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbProveedor
{
    public int IdProveedor { get; set; }

    public int? IdAsociacion { get; set; }

    public string TipoProveedor { get; set; } = "Juridico";

    public string Nombre_Empresa { get; set; } = null!;

    public string CedulaJudirica { get; set; } = null!;

    public string NombreContacto { get; set; } = null!;

    public string CedulaContacto { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Correo { get; set; }

    public string Estado { get; set; } = "Activo";

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();
}
