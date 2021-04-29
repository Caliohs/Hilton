using System;
using System.Collections;
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
    public partial class GestionarReservas : Form
    {
        private DataTable datos;
        private Reserva reserva;
        private ReservaHelper reservaHelper;
        //VARIABLES ADICIONALES
        private double tarifa = 0;
        private string porcentaje = "100%";
        private string codigoReservacon;

        public GestionarReservas()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            try
            {
                reserva = new Reserva();
                reserva.Opc = 2;
                reservaHelper = new ReservaHelper(reserva);
                datos = reservaHelper.Listar();

                if (datos.Rows.Count > 0)
                {
                    dgtReservas.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GestionarReservas_Load(object sender, EventArgs e)
        {
            CargarHoteles();
            CargarCedulas();
            Limpiar();
            Listar();
        }
        //TRAE LAS CEDULASA UN COMBOBOX
        public void CargarCedulas()
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteHelper clienteHelper = new ClienteHelper(cliente);
                cliente.Opc = 2;
                datos = clienteHelper.Listar();
                string[] dt = new string[datos.Rows.Count];
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    dt[i] = datos.Rows[i]["cedula"].ToString();
                }
                cmbCedula.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //TRAE DATOS DEPENDIENDO EL NUMERO DE CEDULA SELECCOINADO
        private void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cliente cliente = new Cliente();
                ClienteHelper clienteHelper = new ClienteHelper(cliente);
                cliente.Opc = 6;
                cliente.Cedula = cmbCedula.Text;
                datos = clienteHelper.BuscarClientePorCedula();
                txtNombre.Text = datos.Rows[0]["nombre"].ToString();
                lblTipoCliente.Text = datos.Rows[0]["tipoCliente"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //CARGA LOS HOTELES A COMBO BOX
        public void CargarHoteles()
        {
            try
            {
                Hotel hotel = new Hotel();
                HotelHelper hHelper = new HotelHelper(hotel);
                hotel.Opc = 2;
                datos = hHelper.Listar();
                string[] dt = new string[datos.Rows.Count];
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    dt[i] = datos.Rows[i]["nombre"].ToString();
                }
                cmbHotel.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CARGA DAtOS DEL HOTEL SELECCIONAD0
        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cmbHabitaciones.Items.Clear();
               
                Hotel hotel = new Hotel();
                HotelHelper hHelper = new HotelHelper(hotel);
                hotel.Opc = 6;
                hotel.Nombre = cmbHotel.Text;
                datos = hHelper.BuscarHotel();

                lblTipoHotel.Text = datos.Rows[0]["especializacion"].ToString();
                int nHabitaciones = int.Parse(datos.Rows[0]["cantidad"].ToString());

                for (int i = 1; i <= nHabitaciones; i++)
                {
                    cmbHabitaciones.Items.Add(i);
                }
                cmbHabitaciones.SelectedIndex = 0;
                mskPresupuesto.Text="";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //AQUI SE REALIZA EL CALCULO DE TARIFA
        private void cmbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarifa = 0;
            porcentaje = "100%";
            if (lblTipoHotel.Text.Equals("Playero"))
            {
                tarifa = 120;
            }
            else if (lblTipoHotel.Text.Equals("Montaña"))
            {
                tarifa = 100;
            }
            else if (lblTipoHotel.Text.Equals("Negocios"))
            {
                tarifa = 85;
            }
            else if (lblTipoHotel.Text.Equals("Tematico"))
            {
                tarifa = 135;
            }
            if (lblTipoCliente.Text.Equals("VIP"))
            {
                porcentaje = "90%";
                tarifa = tarifa + (tarifa * 0.9);
            }
            else if (lblTipoCliente.Text.Equals("Socio"))
            {
                porcentaje = "85%";
                tarifa = tarifa + (tarifa * 0.85);
            }
            Random rnd = new Random();
            codigoReservacon = rnd.Next().ToString();
            mskCodigo.Text = codigoReservacon.Substring(0, 5);
            mskPresupuesto.Text = tarifa.ToString();


        }
        public void Guardar()
        {
            try
            {
                reserva = new Reserva();
                reserva.Opc = 1;
                reserva.CodigoReservacion = mskCodigo.Text;
                reserva.Cedula = this.cmbCedula.Text;
                reserva.NombreCliente = this.txtNombre.Text;
                reserva.NombreHotel = this.cmbHotel.Text;
                reserva.NumeroHabitacion = this.cmbHabitaciones.Text;
                reserva.DesdeFecha = this.dtpFechaDesde.Value.ToString();
                reserva.HastaFecha = this.dtpFechaHasta.Value.ToString();
                reserva.PorcentajeTarifa = porcentaje;
                reserva.Tarifa = tarifa.ToString();
                reservaHelper = new ReservaHelper(reserva);
                reservaHelper.Guardar();
                MessageBox.Show("Se ha creado una reservacion");
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
        }

        public void Limpiar()
        {
            this.cmbCedula.SelectedIndex = -1;
            this.txtNombre.Clear();
            this.lblTipoCliente.Text = "tipo";
            this.cmbHotel.SelectedIndex = -1;
            this.lblTipoHotel.Text = "tipo";
            this.dtpFechaDesde.Value = DateTime.Today;
            this.dtpFechaHasta.Value = DateTime.Today;
            this.cmbHabitaciones.SelectedIndex = 0;
            this.mskPresupuesto.Text = "";
            this.mskCodigo.Text = "";
            tarifa = 0;
            porcentaje = "100%";
        }
    }


}
