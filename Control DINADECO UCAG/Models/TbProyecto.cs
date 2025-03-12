using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models
{
    public class TbProyecto
    {
        public int IdProyecto { get; set; }

        public int? IdAsociacion { get; set; }

        public int? IdActa { get; set; }

        public int? IdAsociado { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public decimal? MontoTotalDestinado { get; set; }

        public virtual TbAsociacion? IdAsociacionNavigation { get; set; }

        public virtual TbActum? IdActaNavigation { get; set; }

        public virtual TbAsociado? IdAsociadoNavigation { get; set; }

        public virtual ICollection<TbMovimiento> TbMovimientos { get; set; } = new List<TbMovimiento>();
    }
}
