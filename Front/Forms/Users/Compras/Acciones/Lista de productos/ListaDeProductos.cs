﻿using BLL;
using System.Data;
using System.Windows.Forms;


namespace Front.Forms.Users.Compras.Acciones
{
    
    public partial class ListaDeProductos : Form
    {
        ProductoDominio productos = new ProductoDominio();
        public ListaDeProductos()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDeProductos_Load(object sender, System.EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = productos.listarproductosBLL();
            dglistaproductos.DataSource = tabla;
        }
    }
}
