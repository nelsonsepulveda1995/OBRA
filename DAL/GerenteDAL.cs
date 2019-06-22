using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GerenteDAL
    {
        Conexion nuevaC = new Conexion();
        public DataTable VentasporVendedorDAL()
        {
            DataTable respuesta = new DataTable();
            SqlParameter[] parametro = new SqlParameter[0];
            respuesta = nuevaC.LeerPorStoreProcedure("VENTASxUSUARIO", parametro);
            return respuesta;
        }
        public DataTable ProductomasVendidoDAL()
        {
            string consulta = "SELECT P.DESCRIPCION , COUNT(D.ID_PROD)AS VENTA FROM PRODUCTO AS P JOIN DETALLEFACTURAVENTA AS D ON P.ID_PROD=D.ID_PROD GROUP BY P.DESCRIPCION ORDER BY VENTA ASC";
            DataTable respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
    }
}
