using System;
using System.Collections.Generic;
namespace Control_DINADECO_UCAG.Models
{
    public partial class TbRol
    {
        public int IdRol { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<TbUsuario> TbUsuarios { get; set; } = new List<TbUsuario>();
    }
}
