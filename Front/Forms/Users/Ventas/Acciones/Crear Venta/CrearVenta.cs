using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class CrearVenta : Form
    {
        VentasBLL ventas = new VentasBLL();
        ProductoBLL producto = new ProductoBLL();
        List<EDetalleFacturaVenta> listadetalle = new List<EDetalleFacturaVenta>();
        UsuarioBLL usuario = new UsuarioBLL();

        public CrearVenta()
        {
            InitializeComponent();
        }

        private void CrearVenta_Load(object sender, System.EventArgs e)
        {
            cbclientes.DataSource = ventas.BuscarClienteBLL();
            cbclientes.ValueMember = "DNI";
            cbclientes.DisplayMember = "DNI";

            cbproducto.DataSource = producto.ListarProductos();
            cbproducto.ValueMember = "ID_PROD";
            cbproducto.DisplayMember = "DESCRIPCION";

            cbmediodepago.DataSource = producto.ListarMediodePagoBLL();
            cbmediodepago.ValueMember = "ID_MEDIOP";
            cbmediodepago.DisplayMember = "DESCRIPCION";
        }

        private void BotonConfirmar_Click(object sender, System.EventArgs e)
        {
            EFacturaVenta factura = new EFacturaVenta();
            EDetalleFacturaVenta detalle = new EDetalleFacturaVenta();//falta cargar datos al detalle

            factura.Setdni(Convert.ToInt32(cbclientes.SelectedValue));
            factura.Setnombreusuario(usuario.GetUsuarioName().Trim('@'));
            int dia, mes, año;
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;
            año = DateTime.Today.Year;
            string fecha = $"{dia}-{mes}-{año}";
            factura.SetFecha(fecha);
            factura.Setmodiop(Convert.ToInt32(cbmediodepago.SelectedValue));

            //CARGAR DETALLE !!!!

            int respuesta = ventas.CrearVentaBLL(factura, listadetalle);

            if (respuesta > 0) {
                MessageBox.Show("Factura creada exitosamente");
            }
            else
            {
                MessageBox.Show("Error al crear la factura");
            }

        }
    }
}
