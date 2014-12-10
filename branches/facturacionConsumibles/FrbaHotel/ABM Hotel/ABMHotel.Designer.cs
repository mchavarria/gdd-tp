namespace FrbaHotel.ABM_Hotel
{
    partial class ABMHotel
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.cboRegimen = new System.Windows.Forms.ComboBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.numUpDnCantEstrellas = new System.Windows.Forms.NumericUpDown();
            this.txtFechaCreacion = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtPais = new System.Windows.Forms.MaskedTextBox();
            this.txtCalle = new System.Windows.Forms.MaskedTextBox();
            this.lblCantEstrellas = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantEstrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(305, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.lblCreacion);
            this.gpoBoxAlta.Controls.Add(this.cboRegimen);
            this.gpoBoxAlta.Controls.Add(this.lblRegimen);
            this.gpoBoxAlta.Controls.Add(this.numUpDnCantEstrellas);
            this.gpoBoxAlta.Controls.Add(this.txtFechaCreacion);
            this.gpoBoxAlta.Controls.Add(this.lblPais);
            this.gpoBoxAlta.Controls.Add(this.lblCiudad);
            this.gpoBoxAlta.Controls.Add(this.txtCiudad);
            this.gpoBoxAlta.Controls.Add(this.txtNumCalle);
            this.gpoBoxAlta.Controls.Add(this.txtPais);
            this.gpoBoxAlta.Controls.Add(this.txtCalle);
            this.gpoBoxAlta.Controls.Add(this.lblCantEstrellas);
            this.gpoBoxAlta.Controls.Add(this.txtTelefono);
            this.gpoBoxAlta.Controls.Add(this.txtMail);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblDirecc);
            this.gpoBoxAlta.Controls.Add(this.lblTel);
            this.gpoBoxAlta.Controls.Add(this.lblMail);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(391, 306);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Hotel nuevo";
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreacion.Location = new System.Drawing.Point(10, 270);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(122, 20);
            this.lblCreacion.TabIndex = 36;
            this.lblCreacion.Text = "Fecha creación:";
            // 
            // cboRegimen
            // 
            this.cboRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegimen.FormattingEnabled = true;
            this.cboRegimen.Location = new System.Drawing.Point(157, 240);
            this.cboRegimen.Name = "cboRegimen";
            this.cboRegimen.Size = new System.Drawing.Size(222, 24);
            this.cboRegimen.TabIndex = 35;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.Location = new System.Drawing.Point(10, 240);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(141, 20);
            this.lblRegimen.TabIndex = 34;
            this.lblRegimen.Text = "Tipos de Régimen:";
            // 
            // numUpDnCantEstrellas
            // 
            this.numUpDnCantEstrellas.Location = new System.Drawing.Point(132, 153);
            this.numUpDnCantEstrellas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnCantEstrellas.Name = "numUpDnCantEstrellas";
            this.numUpDnCantEstrellas.Size = new System.Drawing.Size(78, 23);
            this.numUpDnCantEstrellas.TabIndex = 33;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(138, 270);
            this.txtFechaCreacion.Mask = "00/00/0000";
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(86, 23);
            this.txtFechaCreacion.TabIndex = 32;
            this.txtFechaCreacion.ValidatingType = typeof(System.DateTime);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(10, 211);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(43, 20);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(10, 182);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(63, 20);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(79, 182);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(300, 23);
            this.txtCiudad.TabIndex = 12;
            // 
            // txtNumCalle
            // 
            this.txtNumCalle.Location = new System.Drawing.Point(318, 124);
            this.txtNumCalle.Mask = "000009";
            this.txtNumCalle.Name = "txtNumCalle";
            this.txtNumCalle.Size = new System.Drawing.Size(61, 23);
            this.txtNumCalle.TabIndex = 27;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(59, 211);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(320, 23);
            this.txtPais.TabIndex = 10;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(135, 124);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(177, 23);
            this.txtCalle.TabIndex = 26;
            // 
            // lblCantEstrellas
            // 
            this.lblCantEstrellas.AutoSize = true;
            this.lblCantEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantEstrellas.Location = new System.Drawing.Point(10, 155);
            this.lblCantEstrellas.Name = "lblCantEstrellas";
            this.lblCantEstrellas.Size = new System.Drawing.Size(116, 20);
            this.lblCantEstrellas.TabIndex = 0;
            this.lblCantEstrellas.Text = "Cant. Estrellas:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(91, 95);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(288, 23);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(57, 66);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(322, 23);
            this.txtMail.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecc.Location = new System.Drawing.Point(10, 124);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(119, 20);
            this.lblDirecc.TabIndex = 17;
            this.lblDirecc.Text = "Calle y Número:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(10, 95);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(10, 66);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // ABMHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 364);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "ABMHotel";
            this.Text = "ABM de Hoteles";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantEstrellas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtFechaCreacion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.MaskedTextBox txtCiudad;
        private System.Windows.Forms.MaskedTextBox txtNumCalle;
        private System.Windows.Forms.MaskedTextBox txtPais;
        private System.Windows.Forms.MaskedTextBox txtCalle;
        private System.Windows.Forms.Label lblCantEstrellas;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numUpDnCantEstrellas;
        private System.Windows.Forms.ComboBox cboRegimen;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblCreacion;
    }
}