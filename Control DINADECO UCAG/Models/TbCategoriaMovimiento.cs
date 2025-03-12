using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models
{
    public class TbCategoriaMovimiento
    {
        public int IdCategoriaMovimiento { get; set; }

        public int? IdAsociacion { get; set; }

        public int? IdAsociado { get; set; }

        public string TipoMovimiento { get; set; } = "Ingreso"; // Debe ser 'Ingreso' o 'Egreso'

        public string TipoCategoria { get; set; } = "Donacion"; // Debe ser 'Donacion', 'Compra' o 'Venta'

        public string NombreCategoria { get; set; } = string.Empty;

        public string DescripcionCategoria { get; set; } = string.Empty;

        public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

        public virtual TbAsociado? IdAsociadoNavigation { get; set; }

        public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();

        
    }
}
