﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using Entidad;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class OrdenesDeCompras : Form
    {
        
        Eproducto eproducto = new Eproducto();// instancia de entidad producto
        ProductoBLL productoBll = new ProductoBLL(); //instancias de producto en BLL  
        List<Eproducto> ListaProductos = new List<Eproducto>();//lista de  carrito donde se guardan los productos para laorden de compras
        
        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            cblistaproducto.DataSource = productoBll.ListarProductos();;
            cblistaproducto.DisplayMember = "DESCRIPCION";
            cblistaproducto.ValueMember = "ID_PROD";
            tb_vistacarrito.Text = "  ";
        }

        private void AgregarAlCarrito_Click(object sender, System.EventArgs e) //al tocar este boton hay que cargar a la lista lo seleccionado y mostrarlo en "listbCarrito"
        {
            eproducto.SetID(Convert.ToInt16(cblistaproducto.SelectedValue)); //guarda el producto que agrego al carrito
            eproducto.SetDescripcion(cblistaproducto.Text);
            eproducto.SetStock(Convert.ToInt16(numupdow_cantidad.Value));
            ListaProductos.Add(eproducto);
            tb_vistacarrito.AppendText("\n"+eproducto.GetDescripcion()+"     " + eproducto.GetStock());

        }
        private void VaciarCarrito_Click(object sender, EventArgs e)
        {
            ListaProductos.Clear();
        }
    }
}
