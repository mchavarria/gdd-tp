namespace FrbaHotel.Registrar_Consumible
{
    partial class Facturar
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
            this.BtnTarjeta = new System.Windows.Forms.Button();
            this.gridConsumos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMetPago = new System.Windows.Forms.ComboBox();
            this.txtMontoTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblConsu = new System.Windows.Forms.Label();
            this.lblMet = new System.Windows.Forms.Label();
            this.lblMontoTot = new System.Windows.Forms.Label();
            this.lblNumRese = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(462, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.BtnTarjeta);
            this.gpoBoxAlta.Controls.Add(this.gridConsumos);
            this.gpoBoxAlta.Controls.Add(this.txtFecha);
            this.gpoBoxAlta.Controls.Add(this.lblFecha);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.cboMetPago);
            this.gpoBoxAlta.Controls.Add(this.txtMontoTotal);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblConsu);
            this.gpoBoxAlta.Controls.Add(this.lblMet);
            this.gpoBoxAlta.Controls.Add(this.lblMontoTot);
            this.gpoBoxAlta.Controls.Add(this.lblNumRese);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(548, 365);
            this.gpoBoxAlta.TabIndex = 13;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Factura";
            // 
            // BtnTarjeta
            // 
            this.BtnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjeta.Location = new System.Drawing.Point(307, 60);
            this.BtnTarjeta.Name = "BtnTarjeta";
            this.BtnTarjeta.Size = new System.Drawing.Size(98, 25);
            this.BtnTarjeta.TabIndex = 16;
            this.BtnTarjeta.Text = "Tarjeta";
            this.BtnTarjeta.UseVisualStyleBackColor = true;
            this.BtnTarjeta.Visible = false;
            // 
            // gridConsumos
            // 
            this.gridConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Eliminar});
            this.gridConsumos.Location = new System.Drawing.Point(20, 115);
            this.gridConsumos.Name = "gridConsumos";
            this.gridConsumos.ReadOnly = true;
            this.gridConsumos.Size = new System.Drawing.Size(517, 210);
            this.gridConsumos.TabIndex = 42;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Select";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Delete";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(444, 31);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(93, 23);
            this.txtFecha.TabIndex = 41;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(275, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(163, 20);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Fecha de facturación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "dll.";
            // 
            // cboMetPago
            // 
            this.cboMetPago.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboMetPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetPago.FormattingEnabled = true;
            this.cboMetPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboMetPago.Location = new System.Drawing.Point(151, 60);
            this.cboMetPago.Name = "cboMetPago";
            this.cboMetPago.Size = new System.Drawing.Size(150, 24);
            this.cboMetPago.TabIndex = 23;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(70, 328);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(142, 23);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 31);
            this.txtNombre.Mask = "999999999";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblConsu
            // 
            this.lblConsu.AutoSize = true;
            this.lblConsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsu.Location = new System.Drawing.Point(16, 92);
            this.lblConsu.Name = "lblConsu";
            this.lblConsu.Size = new System.Drawing.Size(104, 20);
            this.lblConsu.TabIndex = 15;
            this.lblConsu.Text = "Consumibles:";
            // 
            // lblMet
            // 
            this.lblMet.AutoSize = true;
            this.lblMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMet.Location = new System.Drawing.Point(6, 60);
            this.lblMet.Name = "lblMet";
            this.lblMet.Size = new System.Drawing.Size(139, 20);
            this.lblMet.TabIndex = 14;
            this.lblMet.Text = "* Método de pago:";
            // 
            // lblMontoTot
            // 
            this.lblMontoTot.AutoSize = true;
            this.lblMontoTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTot.Location = new System.Drawing.Point(16, 328);
            this.lblMontoTot.Name = "lblMontoTot";
            this.lblMontoTot.Size = new System.Drawing.Size(48, 20);
            this.lblMontoTot.TabIndex = 13;
            this.lblMontoTot.Text = "Total:";
            // 
            // lblNumRese
            // 
            this.lblNumRese.AutoSize = true;
            this.lblNumRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRese.Location = new System.Drawing.Point(6, 31);
            this.lblNumRese.Name = "lblNumRese";
            this.lblNumRese.Size = new System.Drawing.Size(145, 20);
            this.lblNumRese.TabIndex = 3;
            this.lblNumRese.Text = "* Núm. de Reserva:";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 426);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "Facturar";
            this.Text = "Facturación";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMetPago;
        private System.Windows.Forms.MaskedTextBox txtMontoTotal;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblConsu;
        private System.Windows.Forms.Label lblMet;
        private System.Windows.Forms.Label lblMontoTot;
        private System.Windows.Forms.Label lblNumRese;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView gridConsumos;
        private System.Windows.Forms.Button BtnTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}