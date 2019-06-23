namespace Entidad
{
    public class Eusuario
    {
        private string idUsuario;
        private string Nombre;
        private string Apellido;
        private int DNI;
        private string Contraseña;
        private int idTipo;
        private string TipoUsuario;
        //  ED -  2019 06 22
        private int PuntoDeVenta;
        //  ED -  2019 06 22 END

        #region getters
        public string getidUsuario()
        {
            return this.idUsuario;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

        public string getApellido()
        {
            return this.Apellido;
        }

        public int getDNI()
        {
            return this.DNI;
        }

        public string getContraseña()
        {
            return this.Contraseña;
        }

        public string getTipoUsuario()
        {
           return this.TipoUsuario;
        }

        public int getIdTipo()
        {
            return this.idTipo;
        }

        public int getPuntoDeVenta()
        {
            return this.PuntoDeVenta;
        }
        #endregion

        #region settters
        public void setIdUsuario(string _idUsuario)
        {
            this.idUsuario = _idUsuario;
        }

        public void setNombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }

        public void setApellido(string _Apellido)
        {
            this.Apellido = _Apellido;
        }

        public void setDNI(int _DNI)
        {
            this.DNI = _DNI;
        }

        public void setContraseña(string _Contraseña)
        {
            this.Contraseña = _Contraseña;
        }

        public void setTipoUsuario(string _TipoUsuario)
        {
            this.TipoUsuario = _TipoUsuario;
        }

        public void setIdTipo(int _IdTipo)
        {
            this.idTipo = _IdTipo;
        }

        public void setPuntoDeVenta(int _PuntoDeVenta)
        {
            this.PuntoDeVenta = _PuntoDeVenta;
        }
        #endregion
    }
}