using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controlador
{
    public class Reserva
    {
        private int opc;
        private string codigoReservacion;
        private string cedula;
        private string nombreCliente;
        private string nombreHotel;
        private string numeroHabitacion;
        private string desdeFecha;
        private string hastaFecha;
        private string porcentajeTarifa;
        private string tarifa;


        public Reserva(int opc, string codigoReservacion, string cedula, string nombreCliente, string nombreHotel, string numeroHabitacion, string desdeFecha, string hastaFecha, string porcentajeTarifa, string tarifa)
        {
            this.Opc = opc;
            this.CodigoReservacion = codigoReservacion;
            this.cedula = cedula;
            this.NombreCliente = nombreCliente;
            this.NombreHotel = nombreHotel;
            this.NumeroHabitacion = numeroHabitacion;
            this.DesdeFecha = desdeFecha;
            this.HastaFecha = hastaFecha;
            this.PorcentajeTarifa = porcentajeTarifa;
            this.Tarifa = tarifa;
        }
        public Reserva()
        {
            this.Opc = 0;
            this.CodigoReservacion = "";
            this.cedula = "";
            this.NombreCliente = "";
            this.NombreHotel = "";
            this.NumeroHabitacion = "";
            this.DesdeFecha = "";
            this.HastaFecha = "";
            this.PorcentajeTarifa = "";
            this.Tarifa = "";
        }
        public int Opc { get => opc; set => opc = value; }
        public string CodigoReservacion { get => codigoReservacion; set => codigoReservacion = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreHotel { get => nombreHotel; set => nombreHotel = value; }
        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public string DesdeFecha { get => desdeFecha; set => desdeFecha = value; }
        public string HastaFecha { get => hastaFecha; set => hastaFecha = value; }
        public string PorcentajeTarifa { get => porcentajeTarifa; set => porcentajeTarifa = value; }
        public string Tarifa { get => tarifa; set => tarifa = value; }


    }
}
