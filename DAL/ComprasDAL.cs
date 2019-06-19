﻿using Entidad;
using System.Data;
namespace DAL
{
    public class ComprasDAL
    {
        Conexion nuevaC = new Conexion(); //llamar esta instancia para la coneccion
        public DataTable ListarProveedor()
        {
            string coneccion = $"select * from PROVEDOR";
            DataTable respuesta = new DataTable();
            respuesta = nuevaC.LeerPorComando(coneccion);
            return respuesta;
        }
        public int CrearCompra()//Cambiar Variables para Crear Compras
        {
            int respuesta = 1;


            return respuesta;
        }
        public int CrearProveedor(Eproveedor _proveedor)
        {
            int respuesta;
            string consulta = $"INSERT TO PROVEDOR(CUIT_PROV,NOMBRE,DIRECCION,TELEFONO,CORREOELECTRONICO)VALUE({_proveedor.getcuit()},'{_proveedor.getnoombre()}','{_proveedor.getdireccion()}','{_proveedor.gettelefono()}','{_proveedor.getcorreo()}')";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public DataTable VerFacturasCompras() //FUNCION  A COMPLETAR
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM FACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable VerDetalleFacturaCompraDAL()
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM DETALLEFACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public bool VerificarProveedorDAL(Eproveedor proveedor)
        {
            DataTable temp = new DataTable();
            string consulta = $"SELECT CUIT_PROV FROM PROVEDOR WHERE CUIT_PROV ={proveedor.getcuit()}"; //se busca proveedor por cuit
            temp = nuevaC.LeerPorComando(consulta);
            if (temp.Rows.Count > 0)
            {
                return false;    // si existe no se puede crear de nuevo
            }
            return true;    //si no existe true
        }
    }
}

