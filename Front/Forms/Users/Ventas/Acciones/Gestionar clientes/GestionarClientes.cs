using BLL;
using Entidad;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class GestionarClientes : Form
    {
        readonly VentasBLL venta = new VentasBLL();
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void RegistrarCliente_Click(object sender, System.EventArgs e)
        {
            if (NoHayDatosVacios())
            {
                NuevoCliente();
            }
        }

        private void NuevoCliente()
        {
            Ecliente cliente = new Ecliente();

            cliente.setidcliente(Convert.ToInt32(CajaTextoDNI.Text));
            cliente.setnombre(CajaTextoNombre.Text);
            cliente.setdireccion(CajaTextoDireccion.Text);
            cliente.setcp(CajaTextoCP.Text);
            cliente.settelefono(CajaTextoTelefono.Text);
            cliente.setcorreo(CajaTextoCorreo.Text);

            Warning.Text = venta.CrearCliente(cliente);
        }

        private bool NoHayDatosVacios(string value = "CajaTexto")
        {
            var CajasDeTexto = Controls.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>().
            Where(Box => Box.Name.StartsWith(value)).OrderBy(Box => TabIndex);

            foreach (var Caja in CajasDeTexto)
            {
                if (string.IsNullOrEmpty(Caja.Text))
                {
                    this.ControlDeError.SetError(Caja, "Error");
                    return false;
                }

                this.ControlDeError.SetError(Caja, null);
            }

            return true;
        }
    }
}
