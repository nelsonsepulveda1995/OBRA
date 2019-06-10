using BLL.Cache;
using DAL;
using Entidad;

namespace BLL
{
    public class UsuarioBLL
    {
        private readonly UserDAL usuarioDAL = new UserDAL();
        public bool LoginUser(string idUsuario, string contraseña)//proceso de logearse
        {
            Eusuario usuario = new Eusuario();
            usuario.setContraseña(contraseña);
            usuario.setIdUsuario(idUsuario);
            if (usuarioDAL.Login(ref usuario))
            {
                UserCache.SetCacheSesion(usuario);
                return true;
            }
            else
            usuario.setContraseña("");
            usuario.setIdUsuario("");
            return false;
        }

        public string GetUsuarioName()
        {
            return $"@{UserCache.CacheUser.getidUsuario()}";
        }
        public Eusuario GetUserCache()
        {
            return UserCache.CacheUser;
        }
        public string GetCargo()
        {
            return $"CARGO {UserCache.CacheUser.getTipoUsuario().ToUpper()}";
        }
        public string GetNombreCompleto()
        {
            return (UserCache.CacheUser.getNombre()
                + " " + UserCache.CacheUser.getApellido());
        }

        public bool CambiarContraseña(string nueva, string actual)
        {
            if (actual.Equals(UserCache.CacheUser.getContraseña()))
            {
                UserCache.CacheUser.setContraseña(nueva);
                return true;
            }
            else return false;
        }

        public void LogoutUser()
        {
            UserCache.DropCacheSesion();
        }
    }
}
