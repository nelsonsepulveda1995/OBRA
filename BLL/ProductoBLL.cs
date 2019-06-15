﻿using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class ProductoDominio
    {
        ProductoDAL producto = new ProductoDAL();
        public int CrearProducto()
        {
            return 1;
        }

        public DataTable ListarProductos()
        {
            DataTable respuesta = new DataTable();
            respuesta = producto.GetListaProductos();
            return respuesta;
        }

        public int CargarStock()
        {
            return 1;
        }
        public bool VerificarStockunProductoBLL(Eproducto _producto)
        {
            bool respuesta = true;
            if (producto.VerificarStockunProductoDAL(_producto))
            {
                respuesta = false;
                return respuesta;
            }
            return respuesta;
        }
    }
}
