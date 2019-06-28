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
            int res = 0;
            if (BuscarUsuario(usuario).Rows.Count > 0) //si el Id_Usuario existe devuelve un cero
            { 
                return res;
            }
            else
            {
                res = Admin.CrearUsuario(usuario);
                return res;
            }
        }
        // ED -  2019 06 22
        public DataTable MostrarUsuarioHabilitados() => Admin.MostrarUsuarioHabilitados();
        // ED -  2019 06 22 END

        public DataTable DesabilitarUsuario(string _idUsuario)
        {
            return Admin.DeshabilitarUsuario(_idUsuario);
        }
        public DataTable BuscarUsuario(Eusuario usuario) => Admin.BuscarUsuario(usuario);

        public DataTable ListasTipoUsuario() => Admin.ListarTipoUsuario();

        //  ED -  2019 06 22
        public DataTable ListarPuntosDeVenta() => Admin.ListarPuntosDeVenta();

        public int ModificarUsuario(Eusuario user) => Admin.ModificarUsuario(user);
        //  ED -  2019 06 22 END
    }
}
