using Hilton.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton.Vista
{
    public partial class GestionarUsuarios : Form
    {

        private Usuario user;
        private UsuarioHelper userH;
        private DataTable datos;

        public GestionarUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.mskCedula.ReadOnly == false)
                {
                    agregar();
                }

                else
                {
                    actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listar()
        {
            try
            {
                user = new Usuario();
                user.Opc = 2;
                userH = new UsuarioHelper(user);
                datos = userH.Listar();

                if (datos.Rows.Count > 0)
                    dtgUsuarios.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.dtgUsuarios.Columns[7].Visible = false; /*oculta la cloumna de contraseñas*/
            }
        }

        private void agregar()
        {
            try
            {
                if (this.txtClave.Text == this.txtConfClave.Text)
                {                  
                    user = new Usuario();
                    user.Nombre = this.txtNombre.Text;
                    user.Cedula = this.mskCedula.Text;
                    user.Genero = this.cmbGenero.Text;
                    user.FechaNacimiento = this.dtpFecha.Value.ToString();
                    user.Correo = this.txtCorreo.Text;
                    user.Perfil = this.cmbPerfil.Text;
                    user.User = this.txtUser.Text;
                    user.Clave = this.txtClave.Text;
                    user.Opc = 1;

                    userH = new UsuarioHelper(user);
                    userH.Guardar();
                    MessageBox.Show("Usuario almacenado con éxito");
                    limpiar();
                    listar();
                }
                else MessageBox.Show("Las claves no coinciden");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizar()
        {
            try
            {
                if (this.txtClave.Text == this.txtConfClave.Text)
                {
                    user = new Usuario();
                    user.Nombre = this.txtNombre.Text;
                    user.Cedula = this.mskCedula.Text;
                    user.Genero = this.cmbGenero.Text;
                    user.Correo = this.txtCorreo.Text;
                    user.Perfil = this.cmbPerfil.Text;
                    user.User = this.txtUser.Text;
                    user.Clave = this.txtClave.Text;
                    user.Opc = 3;

                    userH = new UsuarioHelper(user);
                    userH.Actualizar();
                    MessageBox.Show("Usuario actualizado");
                    limpiar();
                    listar();
                }
                else MessageBox.Show("Las claves no coinciden");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limpiar()
        {

            this.cmbGenero.SelectedIndex = -1;
            this.cmbPerfil.SelectedIndex = -1;
            this.txtNombre.Clear();
            this.mskCedula.Clear();
            this.txtCorreo.Clear();
            this.txtUser.Clear();
            this.txtClave.Clear();
            this.txtConfClave.Clear();
            this.mskCedula.ReadOnly = false;
            this.dtpFecha.Enabled = true;

        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCacelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dtgUsuarios.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay Usuarios por actualizar");

                else
                {
                    int indice = dtgUsuarios.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.mskCedula.Text = fila["cedula"].ToString();
                    this.mskCedula.ReadOnly = true;
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.dtpFecha.Text = fila["fechaNacimiento"].ToString();
                    this.dtpFecha.Enabled = false;
                    this.txtCorreo.Text = fila["correo"].ToString();
                    this.cmbPerfil.Text = fila["perfil"].ToString();
                    this.txtUser.Text = fila["usuario"].ToString();
                    this.txtClave.Text = fila["clave"].ToString();
                    this.txtConfClave.Text = fila["clave"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dtgUsuarios.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay usuarios por Eliminar");

                else
                {
                    int indice = dtgUsuarios.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    user = new Usuario();
                    user.Opc = 4;
                    user.Cedula = fila["cedula"].ToString();

                    //Inicializo El Helper
                    userH = new UsuarioHelper(user);
                    userH.Eliminar();

                    MessageBox.Show("Usuario Eliminado con Exito");
                    listar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar()
        {
            try
            {
              
                user = new Usuario();
                user.Opc = 5;
                user.Nombre = this.txtBuscar.Text;
                userH = new UsuarioHelper(user);
                datos = userH.Buscar();

                if (datos.Rows.Count > 0)
                    dtgUsuarios.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}

