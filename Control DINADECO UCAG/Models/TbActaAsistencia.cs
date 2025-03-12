using System;
using System.Collections.Generic;

namespace Control_DINADECO_UCAG.Models
{
    public class TbActaAsistencia
    {

        public int IdActaAsistencia { get; set; }

        public int? IdAsociado { get; set; }

        public virtual TbAsociado? IdAsociadoNavigation { get; set; }
    }
}
