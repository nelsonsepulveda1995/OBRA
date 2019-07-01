using System;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAL
{
    public class VentasDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para la conexion

        public DataTable ListarClientes() => nuevaC.LeerPorComando("select * from CLIENTE");
        //  ED  -  2019 06 30
        public DataTable ListarFacturasVentas() => nuevaC.LeerPorComando("SELECT [ID_FACTURAVENTA],[MEDIODEPAGO].[DESCRIPCION],[DNI],[NOMBREUSUARIO],[FECHA],[PRECIO_TOTAL] FROM [FACTURAVENTA] INNER JOIN [MEDIODEPAGO] ON [FACTURAVENTA].[ID_MEDIOP] = [MEDIODEPAGO].[ID_MEDIOP]");
        //  ED  -  2019 06 30 END
        //  ED  -  2019 07 01
        public DataTable ListarDetalleFV(string idFacturaVenta) => nuevaC.LeerPorComando($"SELECT [ID_DETALLEFV],[ID_FACTURAVENTA],[PRODUCTO].[DESCRIPCION],[CANT],[PRECIOXUNUDAD] FROM [Corralon].[dbo].[DETALLEFACTURAVENTA] INNER JOIN [Corralon].[dbo].[PRODUCTO] ON [DETALLEFACTURAVENTA].[ID_PROD] = [PRODUCTO].[ID_PROD] AND ID_FACTURAVENTA = {idFacturaVenta}");
        //  ED  -  2019 07 01

        public int GuardarCliente(Ecliente cliente) //VERIFICA SI EXISTE Y SI NO LO CREA
        {
            if (!ExisteCliente(cliente.getidcliente()))
			{
                SqlParameter[] ParametrosCliente = new SqlParameter[]{

                    nuevaC.CrearParametro("@DNI", cliente.getidcliente()),
                    nuevaC.CrearParametro("@Nombre", cliente.getnombre()),
                    nuevaC.CrearParametro("@Apellido", cliente.getapellido()),
                    nuevaC.CrearParametro("@Direccion", cliente.getdireccion()),
                    nuevaC.CrearParametro("@CP", cliente.getcp()),
                    nuevaC.CrearParametro("@Telefono", cliente.gettelefono()),
                    nuevaC.CrearParametro("@Correo", cliente.getcorreo()),
                };

                return nuevaC.EscribirPorStoreProcedure("uspAgregarCliente", ParametrosCliente);
            }
            else return -1;
        }

        public DataTable ListarMedioP()
        {
            // ED  -  2019 06 23
            return nuevaC.LeerPorComando($"SELECT * FROM MEDIODEPAGO");
            // ED  -  2019 06 23 END
        }

        public bool ExisteCliente(int DNI) => nuevaC.LeerPorComando($"SELECT * FROM CLIENTE WHERE DNI = {DNI}").Rows.Count > 0;
	
	    public int CrearventaDAL(EFacturaVenta factura)
        {
            int respuesta;  
            // ED  -  2019 06 30
            decimal amount = factura.getPtotal();
            int amountI = Convert.ToInt32(amount);
            string str = amountI.ToString();   
            string consulta = $"insert into FACTURAVENTA (ID_MEDIOP,DNI,NOMBREUSUARIO,FECHA,PRECIO_TOTAL)VALUES('{factura.Getmediop()}','{factura.Getdni()}','{factura.Getnombreusuario()}','{factura.GetFecha()}','{str}')";            
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
            // ED  -  2019 06 30 END
            
        }
        public int CrearDetalledeVenta(EDetalleFacturaVenta detalle)
        {
            int respuesta;
            string consulta = $"INSERT INTO DETALLEFACTURAVENTA (ID_FACTURAVENTA,ID_PROD,CANT,PRECIOXUNUDAD)" +
                              $"VALUES({detalle.GetIdFacturaVenta()},{detalle.GetIdProd()},{detalle.GetCant()},CONVERT(decimal,{detalle.GetPrecio()}))";            
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;


        }
        public int UltimoIdFacturaVentaDAL()
        {
            int respuesta;
            DataTable temp = new DataTable();
            //  ED  -  2019 07 01
            string consulta = "SELECT TOP(1) ID_FACTURAVENTA FROM [Corralon].[dbo].[FACTURAVENTA] ORDER BY ID_FACTURAVENTA DESC";
            temp = nuevaC.LeerPorComando(consulta);            
            if (temp.Rows.Count>0) {
            //  ED  -  2019 07 01 END
                respuesta = Convert.ToInt32(temp.Rows[0]["ID_FACTURAVENTA"]);
                return respuesta;
            }
            else { return 1; }
        }
	}
}
