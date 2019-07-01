using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductoDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para a conexion
        public DataTable GetListaProductos() => nuevaC.LeerPorStoreProcedure("uspListarProductos");
     
        public DataTable GetProducto(int ID) //Trae todos los datos de un producto (puede servir para calcular el precio total o verificar stock)
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro);
        }
        //  ED  -  2019 07 01
        public DataTable GetProductosConPocoStock(int cantidad) => nuevaC.LeerPorComando($"SELECT * FROM PRODUCTO WHERE CANTIDAD<={cantidad}");
        //  ED  -  2019 07 01 END

        public int GetStockProducto(int ID)// TRUE si cantidad >0 FALSE si cantidad ==0
        {
            SqlParameter parametro = nuevaC.CrearParametro("@idProducto", ID);
            return Convert.ToInt32(nuevaC.LeerPorStoreProcedure("uspGetProducto", parametro).Rows[0]["CANTIDAD"]);
        }
        public DataTable GetMediosdePago() => nuevaC.LeerPorStoreProcedure("spListarMedioDePago");
        // ED  -  2019 07 01
        public bool CheckExist(string getDescripcion)
        {
            string consulta = $"SELECT[DESCRIPCION]FROM[Corralon].[dbo].[PRODUCTO] WHERE[DESCRIPCION] = '{getDescripcion}'";
            DataTable ret = nuevaC.LeerPorComando(consulta);
            if (ret.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // ED  -  2019 07 01 END

        public int SETProductoDAL(Eproducto _producto) //crea un nuevo producto sin importal el id que crea la BD
        {
            // ED  -  2019 07 01
            string consulta = $"INSERT INTO PRODUCTO(DESCRIPCION,PRECIO,CANTIDAD)VALUES('{_producto.GetDescripcion()}',CONVERT(DECIMAL,{_producto.GetPrecio()}),{_producto.GetStock()})";
            // ED  -  2019 07 01 END
            return nuevaC.EscribirPorComando(consulta);
        }
    }
}