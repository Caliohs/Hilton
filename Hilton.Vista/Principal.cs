using Hilton.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilton.Vista
{
    public partial class Principal : Form
    {
        private GestionarHoteles addHoteles;
        private GestionarReservas addReservas;
        private GestionarClientes addClientes;
        private GestionarUsuarios addUser;
        private Acercade acerca;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuario obj)
        {
            InitializeComponent();
            this.statusUsuario.Text = "Bienvenid@ " + obj.Nombre;
            validarPerfil(obj.Perfil);
        }

        private void validarPerfil(object perfil)
        {
            switch (perfil)
            {
                case "Plataforma":
                    this.hotelesToolStripMenuItem.Visible = false;
                    this.usuariosToolStripMenuItem.Visible = false;
                    this.clientesToolStripMenuItem.Visible = false;
                    
                    break;

                case "Administrador":
                    this.hotelesToolStripMenuItem.Visible = false;
                    this.usuariosToolStripMenuItem.Visible = false;
                   

                    break;
            }
        }

        private void reIngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addHoteles = null;
            this.addReservas = null;
            this.addClientes = null;
            this.addUser = null;
            this.acerca = null;
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addHoteles = null;
            this.addReservas = null;
            this.addClientes = null;
            this.addUser = null;
            this.acerca = null;
            Application.Exit();
        }

        private void gestionarHotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addHoteles = new GestionarHoteles();
            this.addHoteles.MdiParent = this;
            this.addHoteles.Show();
        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addReservas = new GestionarReservas();
            this.addReservas.MdiParent = this;
            this.addReservas.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.addClientes = new GestionarClientes();
            this.addClientes.MdiParent = this;
            this.addClientes.Show();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addUser = new GestionarUsuarios();
            this.addUser.MdiParent = this;
            this.addUser.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.acerca = new Acercade();
            this.acerca.MdiParent = this;
            this.acerca.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
