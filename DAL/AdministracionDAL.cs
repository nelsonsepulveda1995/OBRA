﻿using System;
using System.Data;
using Entidad;

namespace DAL
{
    public class AdministracionDAL
    {
        readonly Conexion nuevaC = new Conexion();   //llamar esta instancia para la coneccion

        //buscador de usuario (solo debuelve el nombre mas adelante se puede usar para buscar todos sus datos)
        public DataTable BuscarUsuario(Eusuario usuario)
        {
            String consulta = $"select ID_USUARIO FROM USUARIO WHERE ID_USUARIO='{usuario.getidUsuario()}'";
            return nuevaC.LeerPorComando(consulta);
        }
        public int CrearUsuario(Eusuario usuario) //crea un nuevo usuario
        {
            String consulta = $"insert into USUARIO(NOMBREUSUARIO,ID, NOMBRE,APELLIDO,DNI,CONTRASENIA,ESTADO)VALUES('{usuario.getidUsuario()}','{usuario.getIdTipo()}', '{usuario.getNombre()}', '{usuario.getApellido()}', '{usuario.getDNI()}','{usuario.getContraseña()}',1)";  
            int respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public DataTable ListarTipoUsuario() => nuevaC.LeerPorStoreProcedure("spListarTipoUsuarios");

        public DataTable DeshabilitarUsuario(string idUsuario)
        {
            return nuevaC.LeerPorStoreProcedure("spDeshabilitarUsuario", nuevaC.CrearParametro("@Usuario", idUsuario));
        }

        public DataTable MostrarUsuarioHabilitados() => nuevaC.LeerPorStoreProcedure("spMostrarUsuarioHabilitados");
    }
}