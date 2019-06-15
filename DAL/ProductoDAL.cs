using Entidad;
using System;
using System.Data;
namespace DAL
{
    public class ProductoDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para a conexion
        public DataTable GetListaProductos() //listar todos los productos
        {
            return nuevaC.LeerPorStoreProcedure("spListarProductos");;
        }
        public DataTable Verunproducto(Eproducto _producto) //Trae todos los datos de un producto (puede servir para calcular el precio total o verificar stock)
        {
            string coneccion = $"SELECT * FROM PRODUCTOS WHERE ID_PROD='{_producto.getid_prod()}'";
            DataTable respuesta = new DataTable();
            respuesta = nuevaC.LeerPorComando(coneccion);
            return respuesta;

        }
        public bool VerificarStockunProductoDAL(Eproducto _producto)// TRUE si cantidad >0 FALSE si cantidad ==0
        {
            bool respuesta = true;
            DataTable temp = new DataTable();
            string coneccion = $"SELECT CANTIDAD FROM PRODUCTO WHERE ID_PRODUCTO='{_producto.getid_prod()}'";
            temp = nuevaC.LeerPorComando(coneccion);
            if (Convert.ToInt64(temp.Rows[0]["CANTIDAD"]) == 0)
            {
                respuesta = false;
                return respuesta;
            }
            else return respuesta;
        }

    }
}
