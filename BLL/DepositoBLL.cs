using DAL;
using System.Data;

namespace BLL
{
    public class DepositoBLL
    {
        readonly DepositoDal deposito = new DepositoDal();
        public DataTable ListarProductosconPocoStockBLL(int _cantidad)
        {
            return deposito.ListarProductosconPocoStockDAL(_cantidad);
        }
    }
}