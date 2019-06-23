using System.Data;

namespace DAL
{
    public class GerenteDAL
    {
        readonly Conexion nuevaC = new Conexion();
        public DataTable VentasporVendedorDAL() => nuevaC.LeerPorStoreProcedure("VENTASxUSUARIO");
        public DataTable ProductomasVendidoDAL() => nuevaC.LeerPorStoreProcedure("uspProductosMasVendidos");
    }
}