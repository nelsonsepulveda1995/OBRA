using DAL;
using Entidad;
using System;
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


        public DataTable ConsultarEstadoOrdenDeCompraBLL()
        {
            //  ED  -  2019 07 01
            return comprasDAL.ConsultarEstadoOrdenDeCompraDAL();
            //  ED  -  2019 07 01 END
        }


        public int CrearFacturaCompra(EFacturaCompra factura, List<EdetalleFacturaCompra> listadetalle) 
        {
            //  ED  -  2019 07 01
            int respuesta =comprasDAL.CrearFacturaCompra(factura) ;
            if (respuesta > 0)
            {
                comprasDAL.CambiarEstadoOrdenDeCompra(factura.GetidOrden(), 2);
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
            //  ED  -  2019 07 01            
            return 1; //1 significa que todo se escribio sin problemas
        }
        //  ED  -  2019 07 01
        public decimal TotalOC(int idOC)
        {
            return comprasDAL.TotalOC(idOC);
        }
        
        public DataTable ListarDetalleFC(string idFacturaCompra)
        {
            return comprasDAL.ListarDetalleFC(idFacturaCompra);
        }

        
        public bool CheckProveedor(Eproveedor proveedor)
        {
            return comprasDAL.CheckProveedor(proveedor);
        }

        public List<EdetalleFacturaCompra> ListDetalleOC(int idOC)
        {
            return comprasDAL.ListDetalleOC(idOC);
        }
        //  ED  -  2019 07 01 END

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
        
        public DataTable ListarOrdenesdeCompraporEstado(int estado) => comprasDAL.GetOrdenesporEstado(estado);

        public DataTable DetalledeUnaorden(int id) => comprasDAL.GetDetalledeUnaOrden(id);
    }
}
