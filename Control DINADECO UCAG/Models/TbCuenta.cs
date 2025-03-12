using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models;

public partial class TbCuenta
{
    public int IdCuenta { get; set; }
    public int? IdAsociacion { get; set; }

    public string TipoCuenta { get; set; } = "Ahorro";
    public string NumeroCuenta { get; set; }= string.Empty;

    public string TituloCuenta { get; set; } = string.Empty;

    public string Telefono { get; set; } = string.Empty;

    public string Estado { get; set; } = "Activo";

    public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

    public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();


}
