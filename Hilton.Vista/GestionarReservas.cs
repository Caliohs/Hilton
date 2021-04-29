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
        private double tarifa;
        private string porcentaje;
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
                cliente.Opc = 5;
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
                hotel.Opc = 5;
                hotel.Nombre = cmbHotel.Text;
                datos = hHelper.BuscarHotel();

                lblTipoHotel.Text = datos.Rows[0]["especializacion"].ToString();
                int nHabitaciones = int.Parse(datos.Rows[0]["cantidad"].ToString());

                for (int i = 1; i <= nHabitaciones; i++)
                {
                    cmbHabitaciones.Items.Add(i);
                }
                cmbHabitaciones.SelectedIndex = 0;
                mskPresupuesto.Text = "";
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
            //lo hace para guardar y no para actualizar
            if (this.mskCodigo.Enabled == true)
            {
                Random rnd = new Random();
                codigoReservacon = rnd.Next().ToString();
                mskCodigo.Text = codigoReservacon.Substring(0, 5);
                mskPresupuesto.Text = tarifa.ToString();

            }


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
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar()
        {
            try
            {


                reserva = new Reserva();
                reserva.Opc = 3;
                reserva.CodigoReservacion = this.mskCodigo.Text;
                reserva.DesdeFecha = this.dtpFechaDesde.Value.ToString();
                reserva.HastaFecha = this.dtpFechaHasta.Value.ToString();
                reserva.NumeroHabitacion = this.cmbHabitaciones.Text;
                reservaHelper = new ReservaHelper(reserva);
                reservaHelper.Actualizar();
                MessageBox.Show("Reservacion actualizada");
                Listar();
                Limpiar();

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
                datos = (DataTable)dgtReservas.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay reservaciones por actualizar");

                else
                {
                    int indice = dgtReservas.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.cmbCedula.Text = fila["cedula"].ToString();
                    this.txtNombre.Text = fila["nombreCliente"].ToString();
                    this.cmbHotel.Text = fila["nombreHotel"].ToString();
                    this.dtpFechaDesde.Text = fila["desdeFecha"].ToString();
                    this.dtpFechaHasta.Text = fila["hastaFecha"].ToString();
                    this.cmbHabitaciones.Text = fila["numeroHabitacion"].ToString();
                    this.mskPresupuesto.Text = fila["tarifa"].ToString();
                    this.mskCodigo.Text = fila["codigoReservacion"].ToString();
                    this.lblTipoCliente.Visible = false;
                    this.lblTipoHotel.Visible = false;
                    this.cmbCedula.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.cmbHotel.Enabled = false;
                    this.mskPresupuesto.Enabled = false;
                    this.mskCodigo.Enabled = false;
                }
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
                if (this.mskCodigo.Enabled == true)
                    Guardar();
                else
                    Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
            this.lblTipoCliente.Visible = true;
            this.lblTipoHotel.Visible = true;
            this.cmbCedula.Enabled = true;
            this.txtNombre.Enabled = true;
            this.cmbHotel.Enabled = true;
            this.mskPresupuesto.Enabled = true;
            this.mskCodigo.Enabled = true;
            tarifa = 0;
            porcentaje = "100%";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dgtReservas.DataSource;
                if (datos == null)
                    MessageBox.Show("No hay reservaciones por Eliminar");

                else
                {
                    int indice = dgtReservas.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    reserva = new Reserva();
                    reserva.Opc = 4;
                    reserva.CodigoReservacion = fila["codigoReservacion"].ToString();
                    reservaHelper = new ReservaHelper(reserva);
                    reservaHelper.Eliminar();
                    Listar();
                    MessageBox.Show("Reservacion Eliminado con Exito");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                reserva = new Reserva();
                reserva.Opc = 5;
                reserva.NombreHotel = this.txtBuscar.Text;
                reservaHelper = new ReservaHelper(reserva);
                datos = reservaHelper.Buscar();

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
    }


}
