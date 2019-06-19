using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EDetalleOrdenCompra
    {
        private int id_Detalleorden;
        private int id_OCompras;
        private int id_Producto;
        private int cantidad;
        private decimal PrecioUnidad;

        #region Setters
        public void Setid_Detalleorde(int _iddetalle)
        {
            id_Detalleorden = _iddetalle;
        }
       
        public void Setid_Compras(int _idcompras)
        {
            id_OCompras = _idcompras;
        }
        public void Setidproducto(int _idproducto)
        {
            id_Producto = _idproducto;
        }
        public void Setcatidad(int _cant)
        {
            cantidad = _cant;
        }
        public void Setprecio(decimal _precio)
        {
            PrecioUnidad = _precio;
        }
        #endregion

        #region Getters

        public int get_idOCompras()
        {
            return id_OCompras;
        }


        public int get_idDetalleOrden()
        {
            return id_Detalleorden;
        }
        public int get_idProducto()
        {
            return id_Producto;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public decimal getPrecio()
        {
            return PrecioUnidad;
        }
        #endregion
    }
}
