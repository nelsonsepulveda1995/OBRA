using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class GestionarProvedores : Form
    {
        ComprasDominio compras = new ComprasDominio();
        public GestionarProvedores()
        {
            InitializeComponent();
        }

        private void BotonGestionarProvedores_Click(object sender, System.EventArgs e)
        {
            if (mlcorreo.Text == " " || mlcuit.Text == " " || mldireccion.Text == " " || mlnombre.Text == " " || mltelefono.Text == " ")
            {
                MessageBox.Show("Campos Incompletos");
            }

            else
            {
                Eproveedor proveedor = new Eproveedor();
                proveedor.setcorreo(mlcorreo.Text);
                proveedor.setcuit(Convert.ToInt32(mlcuit.Text));
                proveedor.setdireccion(mldireccion.Text);
                proveedor.setnombre(mlnombre.Text);
                proveedor.settelefono(Convert.ToInt32(mltelefono.Text)); //revisar si es string o int en la BD

                int respuesta;
                respuesta = compras.CrearProveedor(proveedor);
                if (respuesta > 0)
                {
                    mlrespuesta.Text = "Proveedor Creado Exitosamente";
                }
                else
                {
                    mlrespuesta.Text = "Error Intente crearlo nuevamente";
                }
            }
        }
    }
}
