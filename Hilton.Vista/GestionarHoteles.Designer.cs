
namespace Hilton.Vista
{
    partial class GestionarHoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarHoteles));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHoteles = new System.Windows.Forms.DataGridView();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCantHabi = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbEspecializacion = new System.Windows.Forms.GroupBox();
            this.rdbTematico = new System.Windows.Forms.RadioButton();
            this.rdbNegocios = new System.Windows.Forms.RadioButton();
            this.rdbMontaña = new System.Windows.Forms.RadioButton();
            this.rdbPlayero = new System.Windows.Forms.RadioButton();
            this.mskPresupuesto = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoteles)).BeginInit();
            this.gpbEspecializacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestionar Hoteles";
            // 
            // dtgHoteles
            // 
            this.dtgHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoteles.Location = new System.Drawing.Point(254, 82);
            this.dtgHoteles.Margin = new System.Windows.Forms.Padding(2);
            this.dtgHoteles.Name = "dtgHoteles";
            this.dtgHoteles.ReadOnly = true;
            this.dtgHoteles.RowHeadersWidth = 51;
            this.dtgHoteles.RowTemplate.Height = 24;
            this.dtgHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoteles.Size = new System.Drawing.Size(619, 289);
            this.dtgHoteles.TabIndex = 23;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(40, 137);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(172, 20);
            this.txtPais.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pais ";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(40, 174);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(172, 20);
            this.txtEstado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Estado";
            // 
            // mskCantHabi
            // 
            this.mskCantHabi.Location = new System.Drawing.Point(40, 212);
            this.mskCantHabi.Mask = "99999";
            this.mskCantHabi.Name = "mskCantHabi";
            this.mskCantHabi.Size = new System.Drawing.Size(48, 20);
            this.mskCantHabi.TabIndex = 3;
            this.mskCantHabi.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad Habitaciones";
            // 
            // gpbEspecializacion
            // 
            this.gpbEspecializacion.Controls.Add(this.rdbTematico);
            this.gpbEspecializacion.Controls.Add(this.rdbNegocios);
            this.gpbEspecializacion.Controls.Add(this.rdbMontaña);
            this.gpbEspecializacion.Controls.Add(this.rdbPlayero);
            this.gpbEspecializacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEspecializacion.Location = new System.Drawing.Point(40, 238);
            this.gpbEspecializacion.Name = "gpbEspecializacion";
            this.gpbEspecializacion.Size = new System.Drawing.Size(188, 69);
            this.gpbEspecializacion.TabIndex = 4;
            this.gpbEspecializacion.TabStop = false;
            this.gpbEspecializacion.Text = "Especializacion";
            // 
            // rdbTematico
            // 
            this.rdbTematico.AutoSize = true;
            this.rdbTematico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTematico.Location = new System.Drawing.Point(91, 42);
            this.rdbTematico.Name = "rdbTematico";
            this.rdbTematico.Size = new System.Drawing.Size(69, 17);
            this.rdbTematico.TabIndex = 3;
            this.rdbTematico.TabStop = true;
            this.rdbTematico.Text = "Tematico";
            this.rdbTematico.UseVisualStyleBackColor = true;
            // 
            // rdbNegocios
            // 
            this.rdbNegocios.AutoSize = true;
            this.rdbNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNegocios.Location = new System.Drawing.Point(11, 42);
            this.rdbNegocios.Name = "rdbNegocios";
            this.rdbNegocios.Size = new System.Drawing.Size(70, 17);
            this.rdbNegocios.TabIndex = 2;
            this.rdbNegocios.TabStop = true;
            this.rdbNegocios.Text = "Negocios";
            this.rdbNegocios.UseVisualStyleBackColor = true;
            // 
            // rdbMontaña
            // 
            this.rdbMontaña.AutoSize = true;
            this.rdbMontaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMontaña.Location = new System.Drawing.Point(91, 19);
            this.rdbMontaña.Name = "rdbMontaña";
            this.rdbMontaña.Size = new System.Drawing.Size(67, 17);
            this.rdbMontaña.TabIndex = 1;
            this.rdbMontaña.TabStop = true;
            this.rdbMontaña.Text = "Montaña";
            this.rdbMontaña.UseVisualStyleBackColor = true;
            // 
            // rdbPlayero
            // 
            this.rdbPlayero.AutoSize = true;
            this.rdbPlayero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlayero.Location = new System.Drawing.Point(11, 19);
            this.rdbPlayero.Name = "rdbPlayero";
            this.rdbPlayero.Size = new System.Drawing.Size(60, 17);
            this.rdbPlayero.TabIndex = 0;
            this.rdbPlayero.TabStop = true;
            this.rdbPlayero.Text = "Playero";
            this.rdbPlayero.UseMnemonic = false;
            this.rdbPlayero.UseVisualStyleBackColor = true;
            // 
            // mskPresupuesto
            // 
            this.mskPresupuesto.Location = new System.Drawing.Point(40, 326);
            this.mskPresupuesto.Mask = "99999";
            this.mskPresupuesto.Name = "mskPresupuesto";
            this.mskPresupuesto.Size = new System.Drawing.Size(48, 20);
            this.mskPresupuesto.SkipLiterals = false;
            this.mskPresupuesto.TabIndex = 5;
            this.mskPresupuesto.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Presupuesto Inversion $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(759, 386);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 29);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(664, 386);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 29);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(714, 57);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(134, 20);
            this.txtBuscar.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(846, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label7_Click);
            // 
            // GestionarHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 438);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskPresupuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gpbEspecializacion);
            this.Controls.Add(this.mskCantHabi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgHoteles);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 477);
            this.MinimumSize = new System.Drawing.Size(900, 477);
            this.Name = "GestionarHoteles";
            this.Text = "GestionarHoteles";
            this.Load += new System.EventHandler(this.GestionarHoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoteles)).EndInit();
            this.gpbEspecializacion.ResumeLayout(false);
            this.gpbEspecializacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHoteles;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCantHabi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbEspecializacion;
        private System.Windows.Forms.RadioButton rdbTematico;
        private System.Windows.Forms.RadioButton rdbNegocios;
        private System.Windows.Forms.RadioButton rdbMontaña;
        private System.Windows.Forms.RadioButton rdbPlayero;
        private System.Windows.Forms.MaskedTextBox mskPresupuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}