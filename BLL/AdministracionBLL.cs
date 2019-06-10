using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class AdministracionBLL
    {
        AdministracionDal Admin = new AdministracionDal();
        public int CrearUsuario(Eusuario usuario)  //los medodos de escritura retornan un int
        {
            int res = 0;
            DataTable temporal = new DataTable();
            temporal = BuscarUsuario(usuario);
            if (temporal.Rows.Count > 0) //si el Id_Usuario existe devuelve un cero
            { 
                return res;
            }
            else
            {
                res = Admin.CrearUsuario(usuario);
                return res;
            }

        }

        public int DesabilitarUsuario(Eusuario usuario)
        {

            return 1;

        }
        public DataTable BuscarUsuario(Eusuario usuario)
        {
            DataTable respuesta = new DataTable();
            respuesta = Admin.BuscarUsuario(usuario);
            return respuesta;
        }

        public DataTable ListasTipoUsuarioBll()
        {
            DataTable temporal = new DataTable();
            temporal = Admin.ListarTipoUsuario();
            return temporal;
        }
    }
}
