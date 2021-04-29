using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controlador
{
    public class Usuario
    {
        private int opc;
        private string cedula;
        private string nombre;
        private string genero;
        private string fechaNacimiento;
        private string correo;
        private string perfil;
        private string user;
        private string clave;

        public Usuario(int opc, string cedula, string nombre, string genero, string fechaNacimiento, string correo, string perfil, string user, string clave)
        {
            this.Opc = opc;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Genero = genero;
            this.FechaNacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Perfil = perfil;
            this.User = user;
            this.Clave = clave;
        }
        public Usuario()
        {
            this.Opc = 0;
            this.Cedula = "";
            this.Nombre = "";
            this.Genero = "";
            this.FechaNacimiento = "";
            this.Correo = "";
            this.Perfil = "";
            this.User = "";
            this.Clave = "";
        }


        public int Opc { get => opc; set => opc = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
