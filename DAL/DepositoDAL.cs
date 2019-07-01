using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DepositoDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la coneccion



        public DataTable ConsultarEstadoOrdenDeCompraDAL(int id_OCOMPRA = 0)
        {
            string consulta;

            DataTable respuesta;
            consulta= $"SELECT ID_OCOMPRA,NOMBREUSUARIO,ESTADO_OP.DESCRIPCION,FECHA,TOTAL FROM ORDENDECOMPRA INNER JOIN ESTADO_OP ON ORDENDECOMPRA.ID_ESTADO = ESTADO_OP.ID_ESTADO";
            /*if (id_OCOMPRA != 0)
            {
                consulta = $"select ID_OCOMPRA, NOMBREUSUARIO, FECHA, ID_ESTADO = CASE ESTADO  WHEN 1 THEN 'INICIADA'  WHEN 2 THEN 'AUTORIZADA'end  from ORDENDECOMPRA where id_OCOMPRA = {id_OCOMPRA};";
            }
            else
            {
                consulta = $"select ID_OCOMPRA, NOMBREUSUARIO, FECHA, ID_ESTADO = CASE ESTADO  WHEN 1 THEN 'INICIADA'  WHEN 2 THEN 'AUTORIZADA'end  from ORDENDECOMPRA;"; //error al pasar la fecha (12/5/2019 00:00:00) da error al leer los '0' 

            }*/

            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }

		public int ModficarStock(int id, decimal StockModify)
        {
            //  ED  -  2019 07 01
            string consulta = $"UPDATE Corralon.dbo.PRODUCTO SET CANTIDAD = CANTIDAD + {StockModify} WHERE ID_PROD = {id}";
            //  ED  -  2019 07 01 END
            return nuevaC.EscribirPorComando(consulta);      
        }

        public DataTable ListAllProducts() => nuevaC.LeerPorComando($"SELECT * FROM PRODUCTO");
                

        public int GuardarOrdenCompra(EordenCompra Orden)
        {
        // ED  -  2019 - 06 - 30
        decimal amount = Orden.GetPtotal();
        int amountI = Convert.ToInt32(amount);
        string str = amountI.ToString();            
                  		
        int respuesta;
        DateTime fec = Convert.ToDateTime(DateTime.Now.ToShortDateString());        
        string consulta = $"INSERT INTO ORDENDECOMPRA(NOMBREUSUARIO,FECHA,ID_ESTADO,TOTAL)VALUES('{Orden.Getid_usuario()}','{Orden.GetFecha()}','{Orden.Getestado()}','{str}')";
        respuesta = nuevaC.EscribirPorComando(consulta);
        return respuesta;   
        // ED  -  2019 - 06  - 30 END;
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
