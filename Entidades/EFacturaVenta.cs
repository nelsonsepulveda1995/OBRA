using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EFacturaVenta
    {
        private int DNI;
        private string nombreusuario;
        private string fecha;
        private int mediop;
        private decimal Ptotal;

        #region setters
        public void Setmodiop(int _medio)
        {
            mediop = _medio;
        }
        public void setPtotal(decimal _Ptotal)
        {
            Ptotal = _Ptotal;
        }
        public void Setdni(int _dni)
        {
            DNI = _dni;
        }
        public void Setnombreusuario(string nombre)
        {
            nombreusuario = nombre;
        }
        public void SetFecha(string _fecha)
        {
            fecha = _fecha;
        }
        #endregion

        #region getters
        public int Getmediop()
        {
            return mediop;
        }
        public decimal getPtotal()
        {
            return Ptotal;
        }
        public int Getdni()
        {
            return DNI;
        }
        public string Getnombreusuario()
        {
            return nombreusuario;
        }
        public string GetFecha()
        {
            return fecha;
        }
        #endregion
    }
}
