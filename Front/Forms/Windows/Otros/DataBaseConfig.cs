using MaterialSkin;
using System;
using BLL;
using System.Windows.Forms;

namespace Front.Forms.Windows.Otros
{
    public partial class DataBaseConfig : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager Diseño;
        public DataBaseConfig()
        {
            InitializeComponent();
            Diseño = MaterialSkinManager.Instance;
            Diseño.AddFormToManage(this);
            Diseño.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void DataBaseConfig_Load(object sender, EventArgs e)
        {
            SelectorInstancia.Items.Add(".");
            SelectorInstancia.Items.Add("(local)");
            SelectorInstancia.Items.Add(@".\SQLEXPRESS");
            SelectorInstancia.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            SelectorInstancia.SelectedIndex = 3;
            OpcionUsaCredenciales.Enabled = true;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            string Cadena = CargarCadenaDeConeccion();
            ConexionBLL coneccion = new ConexionBLL(Cadena);
            if (coneccion.EsConectable())
            {
                coneccion.GuardarConfiguracion();
            }
            else
            {
                MessageBox.Show("No se puede establecer la coneccion, Si los datos son correctos\n " +
                                "asegurese de que el servidor este en funcionamiento o corregir los datos",
                                "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string CargarCadenaDeConeccion()
        {
            string StringConection =
            $"Server={SelectorInstancia.SelectedItem.ToString()};" +
            $"DataBase={CajaTextoDatabase.Text}; ";
            if (OpcionUsaCredenciales.Enabled)
            {
                return StringConection + 
                "integrated security=true";
            }
            else
            {
                return StringConection +
                "integrated security=false" +
                $"User ID={CajaTextoUserName.Text}; " +
                $"password={CajaTextoPassword.Text};";
            }
        }

        private void OpcionUsaCredenciales_CheckedChanged(object sender, EventArgs e)
        {
            LabelUserName.Enabled = OpcionUsaCredenciales.Enabled;
            LabelPassword.Enabled = OpcionUsaCredenciales.Enabled;
            CajaTextoUserName.Enabled = OpcionUsaCredenciales.Enabled;
            CajaTextoPassword.Enabled = OpcionUsaCredenciales.Enabled;
        }
    }
}