namespace Entidad
{
    public class Ecliente
    {
        private string Nombre;
        private string direccion;
        private int id_cliente;
        private string telefono;
        private string CP;
        private string Correo;

        #region getters
        public string getnombre()
        {
            return this.Nombre;
        }
        public string getdireccion()
        {
            return this.direccion;
        }
        public int getidcliente()
        {
            return this.id_cliente;
        }
        public string gettelefono()
        {
            return this.telefono;
        }
        public string getcp()
        {
            return this.CP;
        }
        public string getcorreo()
        {
            return this.Correo;
        }
        #endregion

        #region setters

        public void setnombre(string _nombre)
        {
            Nombre = _nombre;
        }
        public void setdireccion(string _direccion)
        {
            direccion = _direccion;
        }
        public void setidcliente(int _idcliente)
        {
            id_cliente = _idcliente;
        }
        public void settelefono(string _telefono)
        {
            telefono = _telefono;
        }
        public void setcp(string _cp)
        {
            CP = _cp;
        }
        public void setcorreo(string _correo)
        {
            Correo = _correo;
        }
        #endregion

    }
}
