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
            //Asumo nombres de propiedades Marca, Modelo y Año.
            return String.Format("{0} {1}", descripcion, stock);
        }

        #region setters
        public void SetID(int _idprod)
        {
            id_prod = _idprod;
        }
        public void SetStock(int _stock)
        {
            stock = _stock;
        }
        public void SetDescripcion(string _des)
        {
            descripcion = _des;
        }
        public void SetPrecio(decimal _precio)
        {
            precio = _precio;
        }
        #endregion

        #region getters

        public int GerID()
        {
            return this.id_prod;
        }
        public int GetStock()
        {
            return this.stock;
        }
        public string GetDescripcion()
        {
            return this.descripcion;
        }
        public decimal GetPrecio()
        {
            return this.precio;
        }
        #endregion
    }
}
