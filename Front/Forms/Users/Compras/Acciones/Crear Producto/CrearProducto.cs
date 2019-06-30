using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class CrearProducto : Form
    {
        ProductoBLL producto = new ProductoBLL();
        public CrearProducto()
        {
            InitializeComponent();
        }

        private void CrearProducto_Load(object sender, System.EventArgs e)
        {

        }

        private void BotonFacturasDeCompras_Click(object sender, System.EventArgs e)
        {
            Eproducto eproducto = new Eproducto();
            eproducto.SetDescripcion(sl_descripcion.Text);
            try
            {
                eproducto.SetPrecio(Convert.ToDecimal(tb_precio.Text));
            }
            catch
            {
                MessageBox.Show("Ingrese el precio nuevamente (utilize la ',' para separar decimales)");
            }
            eproducto.SetStock(Convert.ToInt32(nud_catidad.Value));

            if (sl_descripcion.Text == " " || tb_precio.Text == " ")
            {
                ML_RESPUESTA.Text = "Campos incompletos";
            }
            else
            {
                int respuesta = producto.CrearProductoBLL(eproducto);
                if (respuesta < 0) { ML_RESPUESTA.Text = "Producto creado correctamete"; }

                else { ML_RESPUESTA.Text = "Error al Crear el Producto"; }
            }
        }
    }
}
