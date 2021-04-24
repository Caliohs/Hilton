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
            Guardar_Cliente();
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
                cliente.Cedula= this.mskCedula.Text;
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
    }
}
