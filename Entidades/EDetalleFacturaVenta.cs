using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EDetalleFacturaVenta
    {
        private int id_Facturaventa;
        private int id_prod;
        private int cant;
        private decimal precio;

        #region setters
        //  ED  -  2019 07 01
        public void SetIdFacturaVenta(int idfactura)
        {
            id_Facturaventa=idfactura;
        }
        //  ED  -  2019 07 01 END
        public void SetIdProd(int prod)
        {
            id_prod=prod;
        }
        public void SetCant(int _cant)
        {
            cant=_cant;
        }
        public void SetPrecio(decimal _p)
        {
            precio=_p;
        }

        #endregion

        #region Getters
        public int GetIdFacturaVenta()
        {
            return id_Facturaventa;
        }
        public int GetIdProd()
        {
            return id_prod;
        }
        public int GetCant()
        {
            return cant;
        }
        public decimal GetPrecio()
        {
            return precio;
        }
        #endregion
    }
}
