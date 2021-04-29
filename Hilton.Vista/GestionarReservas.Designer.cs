
namespace Hilton.Vista
{
    partial class GestionarReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarReservas));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.gpbFechas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mskPresupuesto = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgtReservas = new System.Windows.Forms.DataGridView();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblTipoHotel = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.cmbCedula = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtReservas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestionar Reservas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1045, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(908, 60);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Seleccione la Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 132);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(108, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre de Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Seleccione Habitacion";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(112, 17);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesde.TabIndex = 49;
            // 
            // gpbFechas
            // 
            this.gpbFechas.Controls.Add(this.label8);
            this.gpbFechas.Controls.Add(this.dtpFechaHasta);
            this.gpbFechas.Controls.Add(this.label7);
            this.gpbFechas.Controls.Add(this.dtpFechaDesde);
            this.gpbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFechas.Location = new System.Drawing.Point(33, 227);
            this.gpbFechas.Name = "gpbFechas";
            this.gpbFechas.Size = new System.Drawing.Size(220, 72);
            this.gpbFechas.TabIndex = 50;
            this.gpbFechas.TabStop = false;
            this.gpbFechas.Text = "Fechas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(112, 44);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaHasta.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Desde";
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(145, 400);
            this.mskCodigo.Mask = "99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.ReadOnly = true;
            this.mskCodigo.Size = new System.Drawing.Size(108, 20);
            this.mskCodigo.TabIndex = 52;
            this.mskCodigo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Codigo de Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(887, 461);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 29);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(799, 461);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 29);
            this.btnAceptar.TabIndex = 53;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mskPresupuesto
            // 
            this.mskPresupuesto.ForeColor = System.Drawing.Color.Red;
            this.mskPresupuesto.Location = new System.Drawing.Point(145, 360);
            this.mskPresupuesto.Mask = "99999";
            this.mskPresupuesto.Name = "mskPresupuesto";
            this.mskPresupuesto.ReadOnly = true;
            this.mskPresupuesto.Size = new System.Drawing.Size(108, 20);
            this.mskPresupuesto.TabIndex = 56;
            this.mskPresupuesto.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 367);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tarifa por noche $";
            // 
            // dgtReservas
            // 
            this.dgtReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtReservas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgtReservas.Location = new System.Drawing.Point(273, 85);
            this.dgtReservas.Margin = new System.Windows.Forms.Padding(2);
            this.dgtReservas.Name = "dgtReservas";
            this.dgtReservas.RowHeadersWidth = 51;
            this.dgtReservas.RowTemplate.Height = 24;
            this.dgtReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtReservas.Size = new System.Drawing.Size(800, 362);
            this.dgtReservas.TabIndex = 60;
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(145, 321);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(108, 21);
            this.cmbHabitaciones.TabIndex = 62;
            this.cmbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cmbHabitaciones_SelectedIndexChanged);
            // 
            // lblTipoHotel
            // 
            this.lblTipoHotel.AutoSize = true;
            this.lblTipoHotel.ForeColor = System.Drawing.Color.Red;
            this.lblTipoHotel.Location = new System.Drawing.Point(142, 196);
            this.lblTipoHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoHotel.Name = "lblTipoHotel";
            this.lblTipoHotel.Size = new System.Drawing.Size(24, 13);
            this.lblTipoHotel.TabIndex = 63;
            this.lblTipoHotel.Text = "tipo";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblTipoCliente.Location = new System.Drawing.Point(142, 154);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(24, 13);
            this.lblTipoCliente.TabIndex = 65;
            this.lblTipoCliente.Text = "tipo";
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(145, 174);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(108, 21);
            this.cmbHotel.TabIndex = 66;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // cmbCedula
            // 
            this.cmbCedula.FormattingEnabled = true;
            this.cmbCedula.Location = new System.Drawing.Point(145, 85);
            this.cmbCedula.Name = "cmbCedula";
            this.cmbCedula.Size = new System.Drawing.Size(108, 21);
            this.cmbCedula.TabIndex = 67;
            this.cmbCedula.SelectedIndexChanged += new System.EventHandler(this.cmbCedula_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuActualizar,
            this.toolStripMenuEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            // 
            // toolStripMenuActualizar
            // 
            this.toolStripMenuActualizar.Name = "toolStripMenuActualizar";
            this.toolStripMenuActualizar.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuActualizar.Text = "Actualizar";
            this.toolStripMenuActualizar.Click += new System.EventHandler(this.toolStripMenuActualizar_Click);
            // 
            // toolStripMenuEliminar
            // 
            this.toolStripMenuEliminar.Name = "toolStripMenuEliminar";
            this.toolStripMenuEliminar.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuEliminar.Text = "Eliminar";
            this.toolStripMenuEliminar.Click += new System.EventHandler(this.toolStripMenuEliminar_Click);
            // 
            // GestionarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.cmbCedula);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.lblTipoHotel);
            this.Controls.Add(this.cmbHabitaciones);
            this.Controls.Add(this.dgtReservas);
            this.Controls.Add(this.mskPresupuesto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gpbFechas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 550);
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "GestionarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarReservas";
            this.Load += new System.EventHandler(this.GestionarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbFechas.ResumeLayout(false);
            this.gpbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtReservas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox gpbFechas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox mskPresupuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgtReservas;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.Label lblTipoHotel;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.ComboBox cmbCedula;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuActualizar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEliminar;
    }
}