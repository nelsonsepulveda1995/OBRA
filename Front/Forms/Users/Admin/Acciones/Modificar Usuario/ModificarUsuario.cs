using System.Windows.Forms;
using BLL;
using Entidad;
using System;
using System.Data;

namespace Front.Forms.Users.Admin.Acciones
{
    public partial class ModificarUsuario : Form
    {
        // ED  -  2019 06 22
        AdministracionBLL admin = new AdministracionBLL();
        Eusuario user = new Eusuario();
        bool editar = false;
        // ED  -  2019 06 22 END
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        // ED  -  2019 06 22
        private void ModificarUsuario_Load(object sender, System.EventArgs e)
        {
            MostrarUsuarioHabilitados();
        }
        private void MostrarUsuarioHabilitados()
        {
            gvwListaUsuarios.DataSource = admin.MostrarUsuarioHabilitados();
        }

        private void BtnModificar_Click(object sender, System.EventArgs e)
        {
            if (gvwListaUsuarios.SelectedRows.Count > 0)
            {
                editar = true;
                nombreIngresado.Text = gvwListaUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
                apellidoIngresado.Text = gvwListaUsuarios.CurrentRow.Cells["APELLIDO"].Value.ToString();                                

                DataTable tabla = admin.ListasTipoUsuario();
                TipoSeleccionado.DataSource = tabla;
                TipoSeleccionado.DisplayMember = "descripcion";
                TipoSeleccionado.ValueMember = "id";                
                
                DataTable tabla2 = admin.ListarPuntosDeVenta();
                cboxPuntoV.DataSource = tabla2;
                cboxPuntoV.DisplayMember = "NOMBRE";
                cboxPuntoV.ValueMember = "CUIT_EMP";
                
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            if (editar)
            {
                if (nombreIngresado.Text.Length == 0 || apellidoIngresado.Text.Length == 0)
                {
                    MessageBox.Show("Por favor complete todos los campos");
                }
                else
                {
                    string idUsuario = gvwListaUsuarios.CurrentRow.Cells["NOMBREUSUARIO"].Value.ToString();
                    user.setIdUsuario(idUsuario);
                    user.setNombre(nombreIngresado.Text);
                    user.setApellido(apellidoIngresado.Text);
                    user.setIdTipo(Convert.ToInt16(TipoSeleccionado.SelectedValue));
                    user.setPuntoDeVenta(Convert.ToInt32(cboxPuntoV.SelectedValue));

                    if (admin.ModificarUsuario(user) == 0)
                    {
                        MessageBox.Show("No se puedo modificar el registro");
                    }
                    else
                    {
                        MessageBox.Show("Modificacion realizada");
                        MostrarUsuarioHabilitados();
                        Limpiar();
                        editar = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro y precione modificar antes de guardar");
            }                          
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            editar = false;
        }

        private void Limpiar()
        {
            nombreIngresado.Text = "";
            apellidoIngresado.Text = "";
            DataTable vacia = new DataTable();
            TipoSeleccionado.DataSource = vacia;
            cboxPuntoV.DataSource = vacia;
        }
        // ED  -  2019 06 22 END
    }
}
