namespace Entidad
{
    public class Eproveedor
    {
        private int id_proveedor;
        private int cuit;
        private string nombre;
        private string direccion;
        private int telefono;
        private string correo;

        #region getteers
        public int getidproveedor()
        {

            return this.id_proveedor;
        }
        public int getcuit()
        {
            return this.cuit;
        }
        public string getnoombre()
        {
            return this.nombre;
        }
        public string getdireccion()
        {
            return this.direccion;
        }
        public int gettelefono()
        {
            return this.telefono;
        }
        public string getcorreo()
        {
            return this.correo;
        }
        #endregion

        #region setters
        public void setidproveedor(int id)
        {
            id_proveedor = id;
        }
        public void setcuit(int _cuit)
        {
            cuit = _cuit;
        }
        public void setnombre(string _nombre)
        {
            nombre = _nombre;
        }

        public void setdireccion(string _direccion)
        {
            direccion = _direccion;
        }
        public void settelefono(int _telefono)
        {
            telefono = _telefono;
        }
        public void setcorreo(string _correo)
        {
            correo = _correo;
        }
        #endregion
    }
}
