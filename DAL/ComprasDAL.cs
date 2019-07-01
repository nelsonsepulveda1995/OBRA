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

        public DataTable ConsultarEstadoOrdenDeCompraDAL()
        {
            string consulta;

            DataTable respuesta;
            //  ED  -  2019 07 01
            consulta = $"SELECT ID_OCOMPRA,NOMBREUSUARIO,ESTADO_OP.DESCRIPCION,FECHA,TOTAL FROM ORDENDECOMPRA INNER JOIN ESTADO_OP ON ORDENDECOMPRA.ID_ESTADO = ESTADO_OP.ID_ESTADO";
            //  ED  -  2019 07 01 END
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
            int respuesta;
            // ED  -  2019 06 30
            decimal amount = factura.getPtotal();
            int amountI = Convert.ToInt32(amount);
            string str = amountI.ToString();
            string consulta = $"insert into [FACTURACOMPRA] ([CUIT_PROV],[NOMBREUSUARIO],[ID_OCOMPRA],[ID_MEDIOP],[FECHA],[PRECIO_TOTAL])VALUES('{factura.GetIdProv()}','{factura.Getnombreusuario()}','{factura.GetidOrden()}','{factura.Getmediop()}','{factura.Getfecha()}','{str}')";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
            // ED  -  2019 06 30 END            
        }

        public decimal TotalOC(int idOC)
        {
            decimal ret;
            string consulta = $"SELECT[TOTAL] FROM[Corralon].[dbo].[ORDENDECOMPRA] WHERE[ID_OCOMPRA] = {idOC}";            
            DataTable table = nuevaC.LeerPorComando(consulta);
            ret = table.Rows[0].Field<decimal>(0);

            return ret;
        }
        

        //  ED  2019 07 01
        public DataTable ListarDetalleFC(string idFacturaCompra) => nuevaC.LeerPorComando($"SELECT [ID_DETALLEFC],[ID_FACTURACOMPRA],[PRODUCTO].[DESCRIPCION],[CANT],[PRECIOXUNIDAD] FROM [Corralon].[dbo].[DETALLEFACTURACOMPRA] INNER JOIN [Corralon].[dbo].[PRODUCTO] ON [DETALLEFACTURACOMPRA].[ID_PROD] = [PRODUCTO].[ID_PROD] AND ID_FACTURACOMPRA = {idFacturaCompra}");

        

        public bool CheckProveedor(Eproveedor proveedor)
        {
            string consulta = $"SELECT[CUIT_PROV]FROM[Corralon].[dbo].[PROVEDOR] WHERE[CUIT_PROV] = '{proveedor.getcuit()}'";
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

        public List<EdetalleFacturaCompra> ListDetalleOC(int idOC)
        {
            EdetalleFacturaCompra detalleFacturaCompra = new EdetalleFacturaCompra();
            List<EdetalleFacturaCompra> retList = new List<EdetalleFacturaCompra>();

            string consulta = $"SELECT * FROM [Corralon].[dbo].[DETALLEORDENCOMPRA] WHERE [ID_OCOMPRA] = {idOC}";
            DataTable table = nuevaC.LeerPorComando(consulta);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                detalleFacturaCompra.SetIdDProd(table.Rows[i].Field<int>(2));
                detalleFacturaCompra.SetCantidad(table.Rows[i].Field<int>(3));
                detalleFacturaCompra.SetPrecio(table.Rows[i].Field<decimal>(4));

                retList.Add(detalleFacturaCompra);
            }
            
            return retList;
        }
        //  ED  2019 07 01 END

        public int CrearDetalleFacturaCompra(EdetalleFacturaCompra detalle)
        {
            decimal amount = detalle.GetPrecio();
            int amountI = Convert.ToInt32(amount);
            string str = amountI.ToString();
            string consulta = $"INSERT INTO[DETALLEFACTURACOMPRA]([ID_FACTURACOMPRA],[ID_PROD],[CANT],[PRECIOXUNIDAD])VALUES('{detalle.GetIdFacturaC()}','{detalle.GetIdProd()}','{detalle.GetCantidad()}','{str}')";            
            int respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int GuardarProveedor(Eproveedor _proveedor)
        {
            //  ED  -  2019 07 01
            string consulta = $"INSERT INTO PROVEDOR(CUIT_PROV,NOMBRE,DIRECCION,TELEFONO,CORREOELECTRONICO)VALUES(CONVERT(BIGINT,{_proveedor.getcuit()}),'{_proveedor.getnoombre()}','{_proveedor.getdireccion()}',{_proveedor.gettelefono()},'{_proveedor.getcorreo()}')";
            //  ED  -  2019 07 01
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
        public DataTable ExisteProvedor(string cuit) 
        {
            //  ED  -  2019 07 01
            string consulta = $"SELECT* FROM PROVEDOR WHERE CUIT_PROV =CONVERT(BIGINT,{cuit})";
            //  ED  -  2019 07 01 END
            return nuevaC.LeerPorComando(consulta);
        }
        public DataTable ListarOrdenesdeCompras() => nuevaC.LeerPorStoreProcedure("spListarOrdenCompra");

        public DataTable GetOrdenesporEstado(int estado)
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
            respuesta =Convert.ToInt32( temp.Rows[0]["ID_FACTURACOMPRA"]);
            return respuesta;
        }
    }
}