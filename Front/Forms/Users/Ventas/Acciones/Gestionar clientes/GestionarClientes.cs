using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class GestionarClientes : Form
    {
        VentasBLL venta = new VentasBLL();
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void BotonGestionarClientes_Click(object sender, System.EventArgs e)
        {
            Ecliente cliente = new Ecliente();
            if (mldni.Text == " "|| mlcp.Text==""|| mldireccion.Text==" "|| mlnombre.Text == " " || mltelefono.Text == " " ||mlcorreo.Text == " " )
            {
                MessageBox.Show("Campos incompletos");
            }
            else
            {
                cliente.setidcliente(Convert.ToInt32(mldni.Text));
                cliente.setnombre(mlnombre.Text);
                cliente.setdireccion(mldireccion.Text);
                cliente.setcp(mlcp.Text);
                cliente.settelefono(mltelefono.Text);
                cliente.setcorreo(mlcorreo.Text);

                int respuesta;
                respuesta= venta.CrearCliente(cliente);
                if (respuesta > 0)
                {
                    mlrespuesta.Text = "Cliente creado correctamente";
                }
                else
                {
                    if (respuesta == 0)
                    {
                        mlrespuesta.Text = "Error Intente Nuevamente";
                    }
                    if (respuesta == -1)
                    {
                        mlrespuesta.Text = "El cliente que intenta crear ya existe";
                    }
                }
            }
        }
    }
}
