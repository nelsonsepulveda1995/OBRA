using DAL;
using Entidad;
using System;
using System.Data;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL productoDAL = new ProductoDAL();
        VentasDAL VentasDAL = new VentasDAL();

        public int CrearProductoBLL(Eproducto _producto) => productoDAL.SETProductoDAL(_producto);
      
        public DataTable ListarProductos() => productoDAL.GetListaProductos();

        public int CargarStock()
        {
            return 1;
        }
        public bool VerificarStockProducto(int ID) => productoDAL.GetStockProducto(ID) > 0;

        // ED  -  2019 07 01
        public bool CheckExist(string getDescripcion)
        {
            return productoDAL.CheckExist(getDescripcion);
        }
        // ED  -  2019 07 01 END

        public DataTable ListarMediodePago() => productoDAL.GetMediosdePago();

        public DataTable VerunProducto(int id)
        {
            return productoDAL.GetProducto(id);
        }
    }
}