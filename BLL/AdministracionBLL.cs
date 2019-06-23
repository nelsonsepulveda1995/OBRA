using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class AdministracionBLL
    {
        readonly AdministracionDAL Admin = new AdministracionDAL();
        public int CrearUsuario(Eusuario usuario)  //los medodos de escritura retornan un int
        {   
            //si el Id_Usuario existe devuelve un cero
            if (BuscarUsuario(usuario).Rows.Count > 0) return 0;
            else return Admin.CrearUsuario(usuario);
        }

        public DataTable DesabilitarUsuario(string _IdUsuario)
        {
            return Admin.DeshabilitarUsuario(_IdUsuario);
        }
        public DataTable BuscarUsuario(Eusuario usuario) => Admin.BuscarUsuario(usuario);

        public DataTable ListasTipoUsuario() =>  Admin.ListarTipoUsuario();

        public DataTable ListarUsuariosHabilitados() => Admin.MostrarUsuarioHabilitados();
    }
}
