using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models
{
    public class TbDetalleMovimiento
    {
        public int IdDetalleMovimiento { get; set; }

        public int IdMovimiento { get; set; }

        public int? IdAcuerdo { get; set; }

        public string TipoMovimiento { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal? Subtotal { get; set; }

       // public int? IdInformeEconomico { get; set; }

        public virtual TbMovimiento IdMovimientoNavigation { get; set; } = null!;

        public virtual TbAcuerdo? IdAcuerdoNavigation { get; set; }
    }
}
