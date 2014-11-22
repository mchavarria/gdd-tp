namespace FrbaHotel.Registrar_Consumible
{
    partial class RegistrarConsumible
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
            this.txtAvisoHab = new System.Windows.Forms.RichTextBox();
            this.gridConsumos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmUDnHab = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDnCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboConsumibles = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblHab = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblConsu = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNumRese = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDnHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(406, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 414);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.txtAvisoHab);
            this.gpoBoxAlta.Controls.Add(this.gridConsumos);
            this.gpoBoxAlta.Controls.Add(this.nmUDnHab);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.numUpDnCantidad);
            this.gpoBoxAlta.Controls.Add(this.cboConsumibles);
            this.gpoBoxAlta.Controls.Add(this.txtMonto);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblHab);
            this.gpoBoxAlta.Controls.Add(this.lblMail);
            this.gpoBoxAlta.Controls.Add(this.lblConsu);
            this.gpoBoxAlta.Controls.Add(this.lblMonto);
            this.gpoBoxAlta.Controls.Add(this.lblNumRese);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(492, 396);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Consumible";
            // 
            // txtAvisoHab
            // 
            this.txtAvisoHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvisoHab.Location = new System.Drawing.Point(14, 315);
            this.txtAvisoHab.Name = "txtAvisoHab";
            this.txtAvisoHab.Size = new System.Drawing.Size(449, 43);
            this.txtAvisoHab.TabIndex = 39;
            this.txtAvisoHab.Text = "Existen varias habitaciónes con ese número, por favor comuniquese con el administ" +
                "rador.";
            this.txtAvisoHab.Visible = false;
            // 
            // gridConsumos
            // 
            this.gridConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.gridConsumos.Location = new System.Drawing.Point(14, 97);
            this.gridConsumos.Name = "gridConsumos";
            this.gridConsumos.ReadOnly = true;
            this.gridConsumos.Size = new System.Drawing.Size(449, 212);
            this.gridConsumos.TabIndex = 38;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Select";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // nmUDnHab
            // 
            this.nmUDnHab.Location = new System.Drawing.Point(412, 40);
            this.nmUDnHab.Name = "nmUDnHab";
            this.nmUDnHab.Size = new System.Drawing.Size(51, 23);
            this.nmUDnHab.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "dll.";
            // 
            // numUpDnCantidad
            // 
            this.numUpDnCantidad.Location = new System.Drawing.Point(399, 68);
            this.numUpDnCantidad.Name = "numUpDnCantidad";
            this.numUpDnCantidad.Size = new System.Drawing.Size(64, 23);
            this.numUpDnCantidad.TabIndex = 35;
            // 
            // cboConsumibles
            // 
            this.cboConsumibles.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboConsumibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsumibles.FormattingEnabled = true;
            this.cboConsumibles.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboConsumibles.Location = new System.Drawing.Point(118, 67);
            this.cboConsumibles.Name = "cboConsumibles";
            this.cboConsumibles.Size = new System.Drawing.Size(183, 24);
            this.cboConsumibles.TabIndex = 23;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(76, 364);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 23);
            this.txtMonto.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 37);
            this.txtNombre.Mask = "999999999";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(87, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblHab
            // 
            this.lblHab.AutoSize = true;
            this.lblHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHab.Location = new System.Drawing.Point(250, 40);
            this.lblHab.Name = "lblHab";
            this.lblHab.Size = new System.Drawing.Size(156, 20);
            this.lblHab.TabIndex = 17;
            this.lblHab.Text = "* Número habitación:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(307, 67);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(87, 20);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "* Cantidad:";
            // 
            // lblConsu
            // 
            this.lblConsu.AutoSize = true;
            this.lblConsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsu.Location = new System.Drawing.Point(6, 67);
            this.lblConsu.Name = "lblConsu";
            this.lblConsu.Size = new System.Drawing.Size(106, 20);
            this.lblConsu.TabIndex = 14;
            this.lblConsu.Text = "* Consumible:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 364);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(58, 20);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto:";
            // 
            // lblNumRese
            // 
            this.lblNumRese.AutoSize = true;
            this.lblNumRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRese.Location = new System.Drawing.Point(6, 37);
            this.lblNumRese.Name = "lblNumRese";
            this.lblNumRese.Size = new System.Drawing.Size(145, 20);
            this.lblNumRese.TabIndex = 3;
            this.lblNumRese.Text = "* Núm. de Reserva:";
            // 
            // RegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 452);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "RegistrarConsumible";
            this.Text = "Consumible";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDnHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.ComboBox cboConsumibles;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblHab;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblConsu;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNumRese;
        private System.Windows.Forms.NumericUpDown numUpDnCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridConsumos;
        private System.Windows.Forms.NumericUpDown nmUDnHab;
        private System.Windows.Forms.RichTextBox txtAvisoHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
    }
}