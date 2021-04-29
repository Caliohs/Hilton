using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hilton.Controlador;

namespace Hilton.Vista
{
    public partial class GestionarClientes : Form
    {
        private DataTable datos;
        private Cliente cliente;
        private ClienteHelper clienteHelper;

        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.mskCedula.ReadOnly == false)
                {
                    Guardar_Cliente();
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
            finally
            {
                limpiar();
            }

        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Guardar_Cliente()
        {
            try
            {

                string radioseleccionado = String.Empty;
                foreach (RadioButton radio in gpbTipoCliente.Controls)
                {
                    if (radio.Checked)
                        radioseleccionado = radio.Text;
                }

                cliente = new Cliente();
                cliente.Opc = 1;
                cliente.Cedula = this.mskCedula.Text;
                cliente.Nombre = this.txtNombre.Text;
                cliente.Metodopago = this.cmbMetodoPago.Text;
                cliente.TipoCliente = radioseleccionado;
                cliente.Correo = this.txtCorreo.Text;
                cliente.Telefono = this.mskTelefono.Text;
                clienteHelper = new ClienteHelper(cliente);
                clienteHelper.Guardar();
                MessageBox.Show("Cliente almacenado");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listar()
        {
            try
            {
                cliente = new Cliente();
                cliente.Opc = 2;
                clienteHelper = new ClienteHelper(cliente);
                datos = clienteHelper.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgClientes.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Buscar()
        {
            try
            {
                cliente = new Cliente();
                cliente.Opc = 4;
                cliente.Nombre = this.txtBuscar.Text;
                clienteHelper = new ClienteHelper(cliente);
                datos = clienteHelper.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgClientes.DataSource = datos;
                }

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

        private void toolStripMenuActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dtgClientes.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay Clientes por actualizar");

                else
                {
                    int indice = dtgClientes.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.mskCedula.Text = fila["cedula"].ToString();
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.cmbMetodoPago.Text = fila["metodoPago"].ToString();
                    this.txtCorreo.Text = fila["correo"].ToString();
                    this.mskTelefono.Text = fila["telefono"].ToString();
                    this.mskCedula.ReadOnly = true;

                    string radioseleccionado = String.Empty;
                    foreach (RadioButton radio in gpbTipoCliente.Controls)
                    {
                        if (radio.Text.Equals(fila["tipoCliente"].ToString()))
                            radio.Checked = true;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void actualizar()
        {
            try
            {
                string radioseleccionado = String.Empty;
                foreach (RadioButton radio in gpbTipoCliente.Controls)
                {
                    if (radio.Checked)
                        radioseleccionado = radio.Text;
                }

                cliente = new Cliente();
                cliente.Opc = 3;
                cliente.Cedula = this.mskCedula.Text;
                cliente.Nombre = this.txtNombre.Text;
                cliente.Metodopago = this.cmbMetodoPago.Text;
                cliente.TipoCliente = radioseleccionado;
                cliente.Correo = this.txtCorreo.Text;
                cliente.Telefono = this.mskTelefono.Text;
                clienteHelper = new ClienteHelper(cliente);
                clienteHelper.Actualizar();
                MessageBox.Show("Cliente actualizado");
                Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void limpiar()
        {
            foreach (RadioButton radio in gpbTipoCliente.Controls)
            {
                radio.Checked = false;
            }

            this.txtNombre.Clear();
            this.txtBuscar.Clear();
            this.txtCorreo.Clear();
            this.mskCedula.Clear();
            this.mskTelefono.Clear();
            this.cmbMetodoPago.SelectedIndex = -1;
            this.mskCedula.ReadOnly = false;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
