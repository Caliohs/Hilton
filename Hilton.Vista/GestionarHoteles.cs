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
    public partial class GestionarHoteles : Form
    {
        private DataTable datos;
        private Hotel hotel;
        private HotelHelper hotelHelper;
        public GestionarHoteles()
        {
            InitializeComponent();
        }

        private void GestionarHoteles_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Guardar_Hotel()
        {
            try
            {
                DateTime dt = DateTime.Today;
                Random rnd = new Random();
                string codigo = rnd.Next().ToString();

                string radioseleccionado = String.Empty;
                foreach (RadioButton radio in gpbEspecializacion.Controls)
                {
                    if (radio.Checked)
                        radioseleccionado = radio.Text;
                }

                hotel = new Hotel();
                hotel.Opc = 1;
                hotel.Codigo = (radioseleccionado.Substring(0, 1) + dt.ToString("yyyy") + codigo.Substring(0, 2));
                hotel.Nombre = this.txtNombre.Text;
                hotel.Pais = this.txtPais.Text;
                hotel.Estado = this.txtEstado.Text;
                hotel.CantidadHabi = this.mskCantHabi.Text;
                hotel.Especializacion = radioseleccionado;
                hotel.Presupuesto = mskPresupuesto.Text;
                hotelHelper = new HotelHelper(hotel);
                hotelHelper.Guardar();
                MessageBox.Show("Contacto almacenado");
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
                hotel = new Hotel();
                hotel.Opc = 2;
                hotelHelper = new HotelHelper(hotel);
                datos = hotelHelper.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgHoteles.DataSource = datos;
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
                hotel = new Hotel();
                hotel.Opc = 4;
                hotel.Especializacion = cmbBuscar.Text;
                hotelHelper = new HotelHelper(hotel);
                datos = hotelHelper.Buscar();

                if (datos.Rows.Count > 0)
                {
                    dtgHoteles.DataSource = datos;
                }
                else
                    MessageBox.Show("no hay datos para Hotel tipo" + cmbBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gpbEspecializacion.Enabled == true)
                    Guardar_Hotel();
                else
                    actualizar();
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

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBuscar.Text.Equals("Todos"))
                    Listar();
                else
                    Buscar();
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
                int indice = dtgHoteles.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
                string codigo = fila["codigo"].ToString();

                hotel = new Hotel();
                hotel.Opc = 3;
                hotel.Codigo = codigo;
                hotel.Nombre = this.txtNombre.Text;
                hotel.Pais = this.txtPais.Text;
                hotel.Estado = this.txtEstado.Text;
                hotel.CantidadHabi = this.mskCantHabi.Text;
                hotel.Presupuesto = mskPresupuesto.Text;
                hotelHelper = new HotelHelper(hotel);
                hotelHelper.Guardar();
                MessageBox.Show("Contacto actualizado");
                Listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dtgHoteles.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay Usuarios por actualizar");

                else
                {
                    int indice = dtgHoteles.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.txtPais.Text = fila["pais"].ToString();
                    this.txtEstado.Text = fila["estado"].ToString();
                    this.mskCantHabi.Text = fila["cantidad"].ToString();
                    this.mskPresupuesto.Text = fila["presupuesto"].ToString();

                    string radioseleccionado = String.Empty;
                    foreach (RadioButton radio in gpbEspecializacion.Controls)
                    {
                        if (radio.Text.Equals(fila["especializacion"].ToString()))
                            radio.Checked = true;

                    }
                    this.gpbEspecializacion.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void limpiar()
        {
            foreach (RadioButton radio in gpbEspecializacion.Controls)
            {
                radio.Checked = false;
            }

            this.txtNombre.Clear();
            this.txtPais.Clear();
            this.txtEstado.Clear();
            this.mskCantHabi.Clear();
            this.mskPresupuesto.Clear();
            this.gpbEspecializacion.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
