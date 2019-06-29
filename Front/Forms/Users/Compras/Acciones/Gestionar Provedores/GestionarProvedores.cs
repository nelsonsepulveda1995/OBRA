using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class GestionarProvedores : Form
    {
        ComprasBLL compras = new ComprasBLL();
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
                int error=0;
                Eproveedor proveedor = new Eproveedor();
                proveedor.setcorreo(mlcorreo.Text);
                try
                {
                    proveedor.setcuit(Convert.ToInt32(mlcuit.Text)); //SI SE INGRESAN LETRAS ERROR PASA A SER 1
                }
                catch
                {
                    MessageBox.Show("Error al introducir el CUIT"); 
                    error = 1;
                }
                proveedor.setdireccion(mldireccion.Text);
                proveedor.setnombre(mlnombre.Text);
                proveedor.settelefono(Convert.ToInt32(mltelefono.Text)); //revisar si es string o int en la BD

                int respuesta;
                if (error == 0)
                {
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
        private void GestionarProvedores_Load(object sender, EventArgs e)
        {

        }
    }
}
