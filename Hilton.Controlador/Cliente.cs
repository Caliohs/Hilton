using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controlador
{
    public class Cliente
    {
        private int opc;
        private string cedula;
        private string nombre;
        private string metodopago;
        private string tipoCliente;
        private string correo;
        private string telefono;

       

        public Cliente(int opc, string cedula, string nombre, string metodopago, string tipoCliente, string correo, string telefono)
        {
            this.Opc = opc;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Metodopago = metodopago;
            this.TipoCliente = tipoCliente;
            this.Correo = correo;
            this.Telefono = telefono;
        }

        public Cliente()
        {
            this.Opc = 0;
            this.Cedula = "";
            this.Nombre = "";
            this.Metodopago = "";
            this.TipoCliente = "";
            this.Correo = "";
            this.Telefono = "";
        }

        public int Opc { get => opc; set => opc = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Metodopago { get => metodopago; set => metodopago = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
