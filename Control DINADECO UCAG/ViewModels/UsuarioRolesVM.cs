using Control_DINADECO_UCAG.Models;

namespace Control_DINADECO_UCAG.ViewModels
{
    public class UsuarioRolesVM
    {
        public TbUsuario Usuario { get; set; } = new TbUsuario();
        public List<TbRol> Roles { get; set; } = new List<TbRol>();
    }
}
