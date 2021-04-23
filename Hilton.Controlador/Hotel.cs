using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controlador
{
    public class Hotel
    {
       
        private int opc;
        private string codigo;
        private string nombre;
        private string pais;
        private string estado;
        private string cantidadHabi;
        private string especializacion;
        private string presupuesto;

        public int Opc { get => opc; set => opc = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string CantidadHabi { get => cantidadHabi; set => cantidadHabi = value; }
        public string Especializacion { get => especializacion; set => especializacion = value; }
        public string Presupuesto { get => presupuesto; set => presupuesto = value; }

        public Hotel(int opc, string codigo, string nombre, string pais, string estado, string cantidadHabi, string especializacion, string presupuesto)
        {
            this.opc = opc;
            this.codigo = codigo;
            this.nombre = nombre;
            this.pais = pais;
            this.estado = estado;
            this.cantidadHabi = cantidadHabi;
            this.especializacion = especializacion;
            this.presupuesto = presupuesto;
        }
        public Hotel()
        {
            this.opc = 0;
            this.codigo = "";
            this.nombre = "";
            this.pais = "";
            this.estado = "";
            this.cantidadHabi = "";
            this.especializacion = "";
            this.presupuesto = "";
        }
    }
}
