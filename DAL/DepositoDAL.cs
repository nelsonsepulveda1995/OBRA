using Entidad;
using System;
using System.Data;

namespace DAL
{
    public class DepositoDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la coneccion

        public DataTable ListarProductosconPocoStockDAL(int cantidad)//SE puede usar para filtrar (normalmente se usa con: 0)
        {
            DataTable respuesta = new DataTable();
            string consulta = $"SELECT * FROM PRODUCTO WHERE CANTIDAD<={cantidad}";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public int CrearOrdenCompraDAL(EordenCompra Orden)
        {
            int respuesta;
            DateTime fec = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string consulta = $"INSERT INTO ORDENDECOMPRA(NOMBREUSUARIO,FECHA,ESTADO)VALUES('{Orden.Getid_usuario()}','{Orden.GetFecha()}',{Orden.Getestado()})"; //error al pasar la fecha (12/5/2019 00:00:00) da error al leer los '0' 
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int CrearDetalleOrdenCompraDAL(EDetalleOrdenCompra detalle)
        {
            int respuesta;
            string consulta = $"INSERT INTO DETALLEORDENCOMPRA (ID_OCOMPRA,ID_PROD,CANT,PRECIOXUNIDAD) VALUES ({detalle.get_idOCompras()},{detalle.get_idProducto()},{detalle.getCantidad()},CONVERT(decimal,{detalle.getPrecio()}))";
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
