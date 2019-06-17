﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EordenCompra
    {
        private int OrdenCompra;
        private int id_proveedor;
        private string id_usuario;
        private DateTime Fecha;
        private bool estado;

        #region Getters
        public int GetIdOrdenCompra()
        {
            return OrdenCompra;
        }
        public string Getid_usuario()
        {
            return id_usuario;
        }
        public int Getid_proveedor()
        {
            return id_proveedor;
        }
        public DateTime GetFecha()
        {
            return Fecha;
        }
       
        public bool Getestado()
        {
            return estado;
        }
        #endregion

        #region Setters

        public void setIdOrdeCompra(int idorden)
        {
            OrdenCompra = idorden;
        }
        public void Setid_proveedor(int _proveedor)
        {
            id_proveedor = _proveedor;
        }
        public void Setid_usuario(string _usuario)
        {
            id_usuario = _usuario;
        }
        public void Setfecha(DateTime _fecha)
        {
            Fecha = _fecha;
        }
        public void Setestado(bool _estado)
        {
            estado = _estado;
        }
        #endregion
    }
}
