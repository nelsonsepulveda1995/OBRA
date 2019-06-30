using DAL;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class ComprasBLL
    {
        ProductoDAL producto = new ProductoDAL();
        readonly ComprasDAL comprasDAL = new ComprasDAL();

        public int cambiarEstadoOrdenDecompraBLL(int id, int estado)
        {
            return comprasDAL.CambiarEstadoOrdenDeCompra(id, estado);
        }


        public DataTable ConsultarEstadoOrdenDeCompraBLL(int id_OCOMPRA=0)
        {
            return comprasDAL.ConsultarEstadoOrdenDeCompraDAL(id_OCOMPRA);
        }


        public int CrearFacturaCompra(EFacturaCompra factura, List<EdetalleFacturaCompra> listadetalle, int OrdenCompra,int estado) //Logica creada revisar parametros dentro de la funcion
        {
            int respuesta=comprasDAL.CrearFacturaCompra(factura) ;
            if (respuesta > 0)
            {
                int idfacuturadecompra=comprasDAL.GetUltimoIdFacturaCompra();
                foreach (EdetalleFacturaCompra detalle in listadetalle)
                {
                    detalle.SetIdFacturaC(idfacuturadecompra);
                }

                foreach (EdetalleFacturaCompra detalle in listadetalle)
                {
                int temp = comprasDAL.CrearDetalleFacturaCompra(detalle);
                if (temp == 0)
                    {
                        return -3;
                    }
                }
            }
            comprasDAL.CambiarEstadoOrdenDeCompra(OrdenCompra,estado);//revisar que numero es "orden aceptada"
            return 1; //1 significa que todo se escribio sin problemas
        }
        public DataTable VerCompras() => comprasDAL.GetFacturasCompras();

        public DataTable VerDetalleCompras() => comprasDAL.GetDetalleFacturaCompra();

        public int CrearProveedor(Eproveedor proveedor)
        {
            if (comprasDAL.ExisteProvedor(proveedor.getcuit())!=null)
            {
                //si la consulta devuelve 0 es que no escribio en la base
                return comprasDAL.GuardarProveedor(proveedor);
            }
            return -1; //solo si el proveedor existe y tira un false en el if 
        }

        public DataTable ListarProveedores() => comprasDAL.GetProveedores();

        public int DesabilitarProveedor()
        {
            return 1;
        }

        public int ModificarProveedor()
        {
            return 1;
        }
        public DataTable CrearRemito()           //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable CrearDetalleRemito()    //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable ListarOrdenesdeCompraporEstado(int estado) => comprasDAL.GetOrdenesporEstado(estado);

        public DataTable DetalledeUnaorden(int id) => comprasDAL.GetDetalledeUnaOrden(id);
    }
}
