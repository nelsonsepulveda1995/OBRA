using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EFacturaCompra //revisar coherenca con BD
    {
        private string fecha;
        private int id_Orden;
        private int id_prov;
        private string nombreusuario;
        private int mediodepago;
        private decimal total;

        #region Setter
        public void Settotal(decimal _total)
        {
            total = _total;
        }
        public void Setmediodepago(int medio)
        {
            mediodepago = medio;
        }
        public void SetnombreUsuario(string nombre)
        {
            nombreusuario = nombre;
        }
        public void SetFecha(string _f)
        {
            fecha=_f;
        }
        public void SetIdOrden(int _id)
        {
            id_Orden=_id;
        }
        public void SetIdProv(int _id)
        {
            id_prov=_id;
        }
        #endregion

        #region Getters
        public string Getnombreusuario()
        {
            return nombreusuario;
        }
        public int Getmediodepago()
        {
            return mediodepago;
        }
        public decimal Gettotal()
        {
            return total;
        }
        public string Getfecha()
        {
            return fecha;
        }
        public int GetidOrden()
        {
            return id_Orden;
        }
        public int GetIdProv()
        {
            return id_prov;
        }

        #endregion
    }
}
