using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductoDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para a conexion
        public DataTable GetListaProductos() => nuevaC.LeerPorStoreProcedure("spListarProductos");
     
        public DataTable GetProducto(int ID) //Trae todos los datos de un producto (puede servir para calcular el precio total o verificar stock)
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro);
        }
        public int GetStockProducto(int ID)// TRUE si cantidad >0 FALSE si cantidad ==0
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return Convert.ToInt32(nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro).Rows[0]["CANTIDAD"]);
        }
        public DataTable GetMediosdePago() => nuevaC.LeerPorStoreProcedure("spListarMedioDePago");

        public int SETProductoDAL(Eproducto _producto) //crea un nuevo producto sin importal el id que crea la BD
        {
            string consulta = $"INSERT INTO PRODUCTO(DESCIPCION,PRECIO,CANT)VALUES('{_producto.GetDescripcion()}',CONVERT(DECIMAL,{_producto.GetPrecio()}),{_producto.GetStock()})";
            return nuevaC.EscribirPorComando(consulta);
        }
    }
}