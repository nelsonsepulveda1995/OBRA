using System;

namespace Entidad
{
    public class Eproducto
    {
        private int id_prod;
        private int stock;
        private string descripcion;
        private decimal precio;

        public override string ToString()
        {
            //Asumo nombres de propiedades Marca, Modelo y Anno.
            return String.Format("{0} {1}", descripcion, stock);
        }

        #region setters
        public void setid_prod(int _idprod)
        {
            id_prod = _idprod;
        }
        public void setstock(int _stock)
        {
            stock = _stock;
        }
        public void setdescripcion(string _des)
        {
            descripcion = _des;
        }
        public void setprecio(decimal _precio)
        {
            precio = _precio;
        }
        #endregion

        #region getters

        public int getid_prod()
        {
            return this.id_prod;
        }
        public int getstock()
        {
            return this.stock;
        }
        public string getdescripcion()
        {
            return this.descripcion;
        }
        public decimal getprecio()
        {
            return this.precio;
        }
        #endregion
    }
}
