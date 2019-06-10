using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepositoDal
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la coneccion

        public DataTable ListarProductosconPocoStockDAL(int cantidad)//SE puede usar para filtrar (normalmente se usa con: 0)
        {
            DataTable respuesta = new DataTable();
            string consulta = $"SELECT * FROM PRODUCTOS WHERE CANTIDAD<={cantidad}";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        
    }
}
