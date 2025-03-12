using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models
{
    public class TbMovimiento
    {
        public int IdMovimiento { get; set; }

        public int IdAsociacion { get; set; }

        public int? IdAsociado { get; set; }

        public string TipoMovimiento { get; set; } = "Ingresos"; // 'Ingresos' o 'Egresos'

        public string FuenteFondo { get; set; } = "Fondos Propios"; // 'Fondos Propios' o 'Aporte 2% Dinadeco'

        public int? IdCategoriaMovimiento { get; set; }

        public int? IdProyecto { get; set; }

        public int? IdCuenta { get; set; }

        public int? IdActa { get; set; }

        public int? IdProveedor { get; set; }

        public int? IdCliente { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public string MetodoPago { get; set; } = "Efectivo"; // 'Transferencia', 'SinpeMovil', 'Cheque', 'Efectivo'

        public DateTime FechaMovimiento { get; set; }

        public decimal? SubtotalMovido { get; set; }

        public decimal? MontoTotalMovido { get; set; }

        public string Estado { get; set; } = "Inactivo"; // 'Procesado', 'Inactivo', 'En Proceso'

        public virtual TbAsociacion IdAsociacionNavigation { get; set; } = null!;

        public virtual TbAsociado? IdAsociadoNavigation { get; set; }

        public virtual TbCategoriaMovimiento? IdCategoriaMovimientoNavigation { get; set; }

        public virtual TbProyecto? IdProyectoNavigation { get; set; }

        public virtual TbCuenta? IdCuentaNavigation { get; set; }

        public virtual TbActum? IdActaNavigation { get; set; }

        public virtual TbProveedor? IdProveedorNavigation { get; set; }

        public virtual TbCliente? IdClienteNavigation { get; set; }

        public virtual ICollection<TbDetalleMovimiento> TbDetalleMovimientos { get; set; } = new List<TbDetalleMovimiento>();

        // public virtual TbCliente? IdClienteNavigation { get; set; }
    }
}
