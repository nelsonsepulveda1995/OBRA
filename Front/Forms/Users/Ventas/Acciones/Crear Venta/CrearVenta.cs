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
        EFacturaVenta facturaV = new EFacturaVenta();

        public CrearVenta()
        {
            InitializeComponent();
        }

        private void CrearVenta_Load(object sender, System.EventArgs e)
        {
            cbclientes.DataSource = ventas.BuscarCliente();
            cbclientes.ValueMember = "DNI";
            cbclientes.DisplayMember = "DNI";

            cbproducto.DataSource = producto.ListarProductos();
            cbproducto.ValueMember = "ID_PROD";
            cbproducto.DisplayMember = "DESCRIPCION";

            cbmediodepago.DataSource = producto.ListarMediodePago();
            cbmediodepago.ValueMember = "ID_MEDIOP";
            cbmediodepago.DisplayMember = "DESCRIPCION";
        }

        private void BotonConfirmar_Click(object sender, System.EventArgs e)
        {            

            facturaV.Setdni(Convert.ToInt32(cbclientes.SelectedValue));
            facturaV.Setnombreusuario(usuario.GetUsuarioName().Trim('@'));
            int dia, mes, año;
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;
            año = DateTime.Today.Year;
            string fecha = $"{año}-{mes}-{dia}";
            facturaV.SetFecha(fecha);
            facturaV.Setmodiop(Convert.ToInt32(cbmediodepago.SelectedValue));

            if (listadetalle.Count == 0) //revisa si la lista tiene objetos
            {
                MessageBox.Show("Carrito vacio !!!");
            }
            else
            {
                if (ventas.CrearVenta(facturaV, listadetalle) == 0)
                {

                    MessageBox.Show("Error al crear la factura");

                }
                else
                {
                    MessageBox.Show("Factura creada exitosamente");
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            EDetalleFacturaVenta eDetalleFacturaVenta = new EDetalleFacturaVenta();// instancia de entidad producto

            eDetalleFacturaVenta.SetIdProd(Convert.ToInt16(cbproducto.SelectedValue)); //guarda el producto que agrego al carrito
            eDetalleFacturaVenta.SetCant(Convert.ToInt16(numupdow_cantidad.Value));
            eDetalleFacturaVenta.SetPrecio(Convert.ToDecimal((producto.VerunProducto(eDetalleFacturaVenta.GetIdProd())).Rows[0]["PRECIO"]));           

            listadetalle.Add(eDetalleFacturaVenta);

            dataGridView1.Rows.Add(cbproducto.Text, eDetalleFacturaVenta.GetCant());
                       
        }

        private void Vaciar_Click(object sender, EventArgs e)
        {
            listadetalle.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}