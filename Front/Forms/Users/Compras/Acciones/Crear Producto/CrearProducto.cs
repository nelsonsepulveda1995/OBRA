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
            eproducto.SetPrecio(Convert.ToDecimal(tb_precio.Text));
            eproducto.SetStock(Convert.ToInt32(nud_catidad.Value));

            if (sl_descripcion.Text == " " || tb_precio.Text == " ")
            {
                ML_RESPUESTA.Text = "Campos imcompletos";
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
