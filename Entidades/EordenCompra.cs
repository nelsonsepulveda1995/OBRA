using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EordenCompra
    {
        private int OrdenCompra;
        private string id_usuario;
        private string Fecha;
        private int estado;
        private decimal Ptotal;

        #region Getters
        // ED - 2019 06 30
        public decimal GetPtotal()
        {
            return Ptotal;
        }
        public void SetPtotal(decimal _Ptotal)
        {
            Ptotal = _Ptotal;
        }
        // ED - 2019 06 30 END
        public int GetIdOrdenCompra()
        {
            return OrdenCompra;
        }
        public string Getid_usuario()
        {
            return id_usuario;
        }

        public string GetFecha()
        {
            return Fecha;
        }
       
        public int Getestado()
        {
            return estado;
        }
        #endregion

        #region Setters

        public void setIdOrdeCompra(int idorden)
        {
            OrdenCompra = idorden;
        }

        public void Setid_usuario(string _usuario)
        {
            id_usuario = _usuario;
        }
        public void Setfecha(string _fecha)
        {
            Fecha = _fecha;
        }
        public void Setestado(int _estado)
        {
            estado = _estado;
        }
        #endregion
    }
}
