using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductoDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para a conexion
        public DataTable GetListaProductos() //listar todos los productos
        {
            return nuevaC.LeerPorStoreProcedure("spListarProductos");
        }
        public DataTable Verunproducto(int ID) //Trae todos los datos de un producto (puede servir para calcular el precio total o verificar stock)
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro);
        }
        public int GetStockProducto(int ID)// TRUE si cantidad >0 FALSE si cantidad ==0
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return Convert.ToInt32(nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro).Rows[0]["CANTIDAD"]);
        }
    }
}