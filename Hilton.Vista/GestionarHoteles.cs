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
        private  HotelHelper hotelHelper;  
        public GestionarHoteles()
        {
            InitializeComponent();
        }

        private void GestionarHoteles_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar_Hotel();
        }
    }
}
