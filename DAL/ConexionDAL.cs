using System.Data.SqlClient;
using System.Configuration;
using System;

namespace DAL
{
    public class ConexionDAL
    {
        readonly SqlConnection Conexion;
        readonly Configuration Configuracion;

        public ConexionDAL(string conecctionString)
        {
            Conexion = new SqlConnection(conecctionString);
            Configuracion = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public bool IntentarConectar()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                try {
                    Conexion.Open();
                }
                catch (Exception ex)
                when (ex is SqlException || ex is ConfigurationErrorsException || ex is InvalidOperationException)
                {
                    return false;
                }
            }
            return true;
        }

        public void ActualizarAppConfig()
        {
            Configuracion.ConnectionStrings.ConnectionStrings["Front.Properties.Settings.ObraDB"].ConnectionString = Conexion.ConnectionString;
            Configuracion.ConnectionStrings.ConnectionStrings["Front.Properties.Settings.ObraDB"].ProviderName = "System.Data.SqlClient";
            Configuracion.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}