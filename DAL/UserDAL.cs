using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        Conexion nuevaC = new Conexion(); //llamar esta instancia para la conexion
        public bool Login(ref Eusuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[] {

                nuevaC.CrearParametro("@idUsuario", usuario.getidUsuario()),
                nuevaC.CrearParametro("@Contrasenia", usuario.getContraseña())
            };
            DataTable user = nuevaC.LeerPorStoreProcedure("spGetLoginUsuario", parametros);

            if (user.Rows.Count > 0)
            {
                usuario.setIdUsuario(user.Rows[0]["NOMBREUSUARIO"].ToString());
                usuario.setIdTipo(Convert.ToInt32(user.Rows[0]["ID"]));
                usuario.setNombre(user.Rows[0]["NOMBRE"].ToString());
                usuario.setApellido(user.Rows[0]["APELLIDO"].ToString());
                usuario.setTipoUsuario(this.GetCategoria(usuario.getIdTipo()));
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Logout(ref Eusuario eusuario)
        {
            return false;
        }

        private string GetCategoria(int Tipo)
        {
            Conexion Consulta = new Conexion();
            SqlParameter parametro = Consulta.CrearParametro("@idTipoUsuario", Tipo);
            return Consulta.LeerPorStoreProcedure("spGetTipoUsuario", parametro).Rows[0][0].ToString();
        }
    }
}