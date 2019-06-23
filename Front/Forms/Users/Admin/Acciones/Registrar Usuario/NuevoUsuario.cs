using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Admin.Acciones
{
    public partial class NuevoUsuario : Form
    {
        Eusuario Nuevousuario = new Eusuario();
        AdministracionBLL admin = new AdministracionBLL();
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void BotonRegistrar_Click(object sender, System.EventArgs e)
        {
            
            if (usuarioIngresado.Text.Length < 4 || usuarioIngresado.Text.Contains(" "))
            {
                MessageBox.Show("El Usuario ingresado debe tener mas de 3 caracteres y no contener espacios", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dniIngresado.Text.Length == 0 || nombreIngresado.Text.Length == 0 || apellidoIngresado.Text.Length == 0 || Contraseñaingresada.Text.Length == 0 || TipoSeleccionado.Text.Length == 0)
                {
                    MessageBox.Show("Compos obligatorios vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Nuevousuario.setDNI(Convert.ToInt32(dniIngresado.Text));
                        Nuevousuario.setApellido(apellidoIngresado.Text);
                        Nuevousuario.setDNI(Convert.ToInt32(dniIngresado.Text));
                        Nuevousuario.setContraseña(Contraseñaingresada.Text);
                        Nuevousuario.setIdUsuario(usuarioIngresado.Text);
                        Nuevousuario.setNombre(nombreIngresado.Text);
                        Nuevousuario.setIdTipo(Convert.ToInt16(TipoSeleccionado.SelectedValue));
                        //  ED -  2019 06 22
                        Nuevousuario.setPuntoDeVenta(Convert.ToInt32(comboBox2.SelectedValue));
                        //  ED -  2019 06 22 END
                        if (admin.CrearUsuario(Nuevousuario) == 0)
                        {
                            MessageBox.Show("No se pudo crear el registro");
                        }
                        else
                        {
                            MessageBox.Show("Registro creado exitosamente");
                            Limpiar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Los datos no son correctos : ");
                    }                                                            
                }
            }
        }

        private void MaterialLabel2_Click(object sender, System.EventArgs e)
        {

        }

        private void NuevoUsuario_Load(object sender, EventArgs e) //no funciona !!!!!
        {
            
            DataTable tabla= admin.ListasTipoUsuarioBll();
            TipoSeleccionado.DataSource = tabla;
            TipoSeleccionado.DisplayMember = "descripcion";
            TipoSeleccionado.ValueMember = "id";
            
            //  ED -  2019 06 22
            DataTable tabla2 = admin.ListarPuntosDeVenta();
            comboBox2.DataSource = tabla2;
            comboBox2.DisplayMember = "NOMBRE";
            comboBox2.ValueMember = "CUIT_EMP";
            //  ED -  2019 06 22 END

        }

        private void Limpiar()
        {
            dniIngresado.Text = "";
            apellidoIngresado.Text = "";
            dniIngresado.Text = "";
            Contraseñaingresada.Text = "";
            usuarioIngresado.Text = "";
            nombreIngresado.Text = "";

        }

        private void TipoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
