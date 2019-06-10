using Entidad;
namespace BLL.Cache
{
    internal class UserCache
    {
        private Eusuario UsuarioLogueado;
        private static UserCache Sesion;
        private UserCache()
        {

        }

        public static void SetCacheSesion(Eusuario usuario)
        {
            if (Sesion == null)
            {
                Sesion = new UserCache
                {
                    UsuarioLogueado = usuario
                };
            }
        }

        public static Eusuario CacheUser => Sesion.UsuarioLogueado;

        public static void DropCacheSesion()
        {
            Sesion.UsuarioLogueado = null;
            Sesion = null;
        }
    }
}
