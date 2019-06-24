using System;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAL
{
    public class AdministracionDAL
    {
        readonly Conexion nuevaC = new Conexion();   //llamar esta instancia para la coneccion

        //buscador de usuario (solo debuelve el nombre mas adelante se puede usar para buscar todos sus datos)
        public DataTable BuscarUsuario(Eusuario usuario)
        {
            String consulta = $"select NOMBREUSUARIO FROM USUARIO WHERE NOMBREUSUARIO='{usuario.getidUsuario()}'";
            return nuevaC.LeerPorComando(consulta);
        }
        public int CrearUsuario(Eusuario usuario) //crea un nuevo usuario
        {
            String consulta = $"insert into USUARIO(NOMBREUSUARIO,ID,CUIT_EMP,NOMBRE,APELLIDO,DNI,CONTRASENIA,ESTADO)VALUES('{usuario.getidUsuario()}','{usuario.getIdTipo()}', '{usuario.getPuntoDeVenta()}', '{usuario.getNombre()}', '{usuario.getApellido()}', '{usuario.getDNI()}','{usuario.getContraseña()}',1)";  
            int respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public DataTable ListarTipoUsuario() => nuevaC.LeerPorStoreProcedure("spListarTipoUsuarios");
        
        public DataTable ListarPuntosDeVenta()
        {
            DataTable retListaPV = new DataTable();
            retListaPV = nuevaC.LeerPorStoreProcedure("spListarPuntoDeVenta");
            return retListaPV;
        }

        public int ModificarUsuario(Eusuario user)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                nuevaC.CrearParametro("@Uid", user.getidUsuario()),
                nuevaC.CrearParametro("@Unombre", user.getNombre()),
                nuevaC.CrearParametro("@Uapellido", user.getApellido()),
                nuevaC.CrearParametro("@UidTipo", user.getIdTipo()),
                nuevaC.CrearParametro("@UpuntoVenta", user.getPuntoDeVenta())
            };
            
            return nuevaC.EscribirPorStoreProcedure("spModificarUsuario", parametros);
        }


        public DataTable DeshabilitarUsuario(string _idUsuario)
        {            
            DataTable respuesta = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = nuevaC.CrearParametro("@Usuario", _idUsuario);
            respuesta = nuevaC.LeerPorStoreProcedure("spDeshabilitarUsuario", parameters);
            return respuesta;
        }

        public DataTable MostrarUsuarioHabilitados() => nuevaC.LeerPorStoreProcedure("spMostrarUsuarioHabilitados");
    }
}