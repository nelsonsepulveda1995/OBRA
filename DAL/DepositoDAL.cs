using Entidad;
using System;
using System.Data;

namespace DAL
{
    public class DepositoDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la coneccion

		public int ModficarStock(int id, decimal StockModify)
        {
            string consulta = $"UPDATE PRODUCTO SET CANTIDAD = {StockModify} WHERE  ID_PROD={id}";
            return nuevaC.EscribirPorComando(consulta);      
        }

        public DataTable ListAllProducts() => nuevaC.LeerPorComando($"SELECT * FROM PRODUCTO");

        //SE puede usar para filtrar (normalmente se usa con: 0)	
        public DataTable GetProductosConPocoStock(int cantidad) => nuevaC.LeerPorComando($"SELECT * FROM PRODUCTO WHERE CANTIDAD<={cantidad}");
        public int GuardarOrdenCompra(EordenCompra Orden)
        {
            int respuesta;
            DateTime fec = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string consulta = $"INSERT INTO ORDENDECOMPRA(NOMBREUSUARIO,FECHA,ESTADO)VALUES('{Orden.Getid_usuario()}','{Orden.GetFecha()}',{Orden.Getestado()})"; //error al pasar la fecha (12/5/2019 00:00:00) da error al leer los '0' 
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int GuardarDetalleOrdenCompra(EDetalleOrdenCompra detalle)
        {
            int respuesta;
            string consulta = $"INSERT INTO DETALLEORDENCOMPRA (ID_OCOMPRA,ID_PROD,CANT,PRECIOXUNIDAD) " +
                              $"VALUES ({detalle.get_idOCompras()},{detalle.get_idProducto()},{detalle.getCantidad()},CONVERT(decimal,{detalle.getPrecio()}))";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int UltimoIdOrdeCompra()
        {
            DataTable temp = new DataTable();
            string consulta = "select top(1) ID_OCOMPRA FROM ORDENDECOMPRA ORDER BY ID_OCOMPRA DESC";
            temp = nuevaC.LeerPorComando(consulta);
            if (temp.Rows.Count > 0)
            {
                int respuesta = Convert.ToInt32(temp.Rows[0]["ID_OCOMPRA"]);
                return respuesta;
            }
            else
            {
                return 1;//si la bd esta vacia retorna el valor 1 para empezar la cuenta
            }
        
        }
    }
}
