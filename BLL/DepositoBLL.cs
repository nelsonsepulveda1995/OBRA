using DAL;
using System.Data;

namespace BLL
{
    public class DepositoBLL
    {
        readonly DepositoDAL deposito = new DepositoDAL();
        public DataTable ListarProductosconPocoStockBLL(int _cantidad)
        {
            return deposito.ListarProductosconPocoStockDAL(_cantidad);
        }
    }
}