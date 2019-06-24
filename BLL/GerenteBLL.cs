using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GerenteBLL
    {
        GerenteDAL gerente = new GerenteDAL();
        public DataTable GetVentasporUsuarioBLL() => gerente.VentasporVendedorDAL();

        public DataTable GetProductomasVedido() => gerente.ProductomasVendidoDAL();
    }
}
