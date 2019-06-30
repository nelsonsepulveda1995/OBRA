using DAL;

namespace BLL
{
    public class ConexionBLL
    {
        readonly ConexionDAL conexion;

        public ConexionBLL(string StringConection) => conexion = new ConexionDAL(StringConection);

        public bool EsConectable() => conexion.IntentarConectar();

        public void GuardarConfiguracion() => conexion.ActualizarAppConfig();
    }
}