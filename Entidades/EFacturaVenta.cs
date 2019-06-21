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

        #region setters

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
