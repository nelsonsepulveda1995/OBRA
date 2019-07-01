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
        //  ED  -  2019 07 01
        private string nombreusuario;
        private int mediop;
        private decimal Ptotal;
        //  ED  -  2019 07 01 END

        #region Setter
        public void Setmodiop(int _medio)
        {
            mediop = _medio;
        }
        public void setPtotal(decimal _Ptotal)
        {
            Ptotal = _Ptotal;
        }
        public void Setnombreusuario(string nombre)
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

        public int Getmediop()
        {
            return mediop;
        }
        public decimal getPtotal()
        {
            return Ptotal;
        }
        public string Getnombreusuario()
        {
            return nombreusuario;
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
