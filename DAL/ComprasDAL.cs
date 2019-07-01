using Entidad;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ComprasDAL
    {
        Conexion nuevaC = new Conexion(); //llamar esta instancia para la coneccion
        public DataTable GetProveedores() => nuevaC.LeerPorStoreProcedure("spListarProvedores");

        public DataTable ConsultarEstadoOrdenDeCompraDAL(int id_OCOMPRA=0)
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
                 consulta = $"select ID_OCOMPRA, NOMBREUSUARIO, FECHA, ID_ESTADO = CASE ESTADO  WHEN 1 THEN 'INICIADA'  WHEN 2 THEN 'AUTORIZADA'end  from ORDENDECOMPRA;"; 

            }*/

            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;

        }



        public int CambiarEstadoOrdenDeCompra(int id,int estado)
        {
            string consulta = $"update ORDENDECOMPRA set ID_ESTADO ={estado} where ID_OCOMPRA = {id};";
            return nuevaC.EscribirPorComando(consulta);
        }

        public int CrearFacturaCompra(EFacturaCompra factura)
        {
            string consulta = $"INSERT TO FACTURADECOMPRA()VALUES()";// !!!!!!!!COMPLETAR Y REVISAR COHERENCIA CON BD !!!!!!!!!!!
            int respuesta=nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int CrearDetalleFacturaCompra(EdetalleFacturaCompra detalle)
        {
            string consulta = $"INSERT TO DETALLEFACTURACOMPRA()VALUES()";// !!!!!!!!COMPLETAR Y REVISAR COHERENCIA CON BD!!!!!!!!!!!
            int respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int GuardarProveedor(Eproveedor _proveedor)
        {
            string consulta = $"INSERT INTO PROVEDOR(CUIT_PROV,NOMBRE,DIRECCION,TELEFONO,CORREOELECTRONICO)VALUES({_proveedor.getcuit()},'{_proveedor.getnoombre()}','{_proveedor.getdireccion()}',{_proveedor.gettelefono()},'{_proveedor.getcorreo()}')";
            return nuevaC.EscribirPorComando(consulta);
        }
        public DataTable GetFacturasCompras() 
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM FACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable GetDetalleFacturaCompra()
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM DETALLEFACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable ExisteProvedor(int cuit) 
        {
            string consulta = $"SELECT* FROM PROVEDOR WHERE CUIT_PROV ={cuit}";
            return nuevaC.LeerPorComando(consulta);
        }
        public DataTable ListarOrdenesdeCompras() => nuevaC.LeerPorStoreProcedure("spListarOrdenCompra");

        public DataTable GetOrdenesporEstado(int estado)//1 sin aprobar 2 aprobado
        {
            DataTable respuesta = new DataTable();
            string consulta = $"Select * FROM ORDENDECOMPRA WHERE ID_ESTADO='{estado}'";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable GetDetalledeUnaOrden(int id)
        {
            DataTable respuesta = new DataTable();
            string consulta = $"SELECT [PRODUCTO].[DESCRIPCION],[DETALLEORDENCOMPRA].[CANT], [DETALLEORDENCOMPRA].[PRECIOXUNIDAD] FROM [DETALLEORDENCOMPRA]INNER JOIN [PRODUCTO] ON [DETALLEORDENCOMPRA].[ID_PROD]=[PRODUCTO].[ID_PROD] and DETALLEORDENCOMPRA.ID_OCOMPRA= {id} ORDER BY [DETALLEORDENCOMPRA].[ID_PROD];";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public int GetUltimoIdFacturaCompra()
        {
            int respuesta;
            string consulta = "SELECT TOP(1) ID_FACTURACOMPRA FROM FACTURACOMPRA ORDER BY ID_FACTURACOMPRA DESC"; //REVISAR COHERENCIA CON LA BD
            DataTable temp = nuevaC.LeerPorComando(consulta);
            respuesta =Convert.ToInt32( temp.Rows[0]["ID_FACTURACOMPRA"]); //revisar coherencia con BD
            return respuesta;
        }
    }
}