using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EdetalleFacturaCompra  //revisar coherenca con BD
    {
        private int id_prod;
        private decimal precio;
        private int cantidad;

        #region Setters
        public void SetIdDProd(int id)
        {
            id_prod = id;
        }
        public void SetPrecio(decimal _p)
        {
            precio = _p;
        }
        public void SetCantidad(int _C)
        {
            cantidad = _C;
        }
        #endregion

        #region Getters
        public int GetIdProd()
        {
            return id_prod;
        }
        public decimal GetPrecio()
        {
            return precio;
        }
        public int GetCantidad()
        {
            return cantidad;
        }
        #endregion
    }
}
