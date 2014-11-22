namespace FrbaHotel.ABM_de_Habitacion
{
    partial class BusquedaHabitacion
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
            this.gridHabitaciones = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.ckDisponible = new System.Windows.Forms.CheckBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.upDnPiso = new System.Windows.Forms.NumericUpDown();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridHabitaciones)).BeginInit();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHabitaciones
            // 
            this.gridHabitaciones.AllowUserToDeleteRows = false;
            this.gridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Delete});
            this.gridHabitaciones.Location = new System.Drawing.Point(12, 188);
            this.gridHabitaciones.Name = "gridHabitaciones";
            this.gridHabitaciones.ReadOnly = true;
            this.gridHabitaciones.Size = new System.Drawing.Size(576, 369);
            this.gridHabitaciones.TabIndex = 0;
            this.gridHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Select";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 147);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(6, 39);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(69, 17);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Número:";
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.ckDisponible);
            this.gpoBoxAlta.Controls.Add(this.cboTipo);
            this.gpoBoxAlta.Controls.Add(this.txtNum);
            this.gpoBoxAlta.Controls.Add(this.upDnPiso);
            this.gpoBoxAlta.Controls.Add(this.cboUbicacion);
            this.gpoBoxAlta.Controls.Add(this.label3);
            this.gpoBoxAlta.Controls.Add(this.label2);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.lblNum);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(13, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(575, 129);
            this.gpoBoxAlta.TabIndex = 4;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // ckDisponible
            // 
            this.ckDisponible.AutoSize = true;
            this.ckDisponible.Location = new System.Drawing.Point(9, 96);
            this.ckDisponible.Name = "ckDisponible";
            this.ckDisponible.Size = new System.Drawing.Size(103, 21);
            this.ckDisponible.TabIndex = 16;
            this.ckDisponible.Text = "Disponible";
            this.ckDisponible.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(373, 66);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(157, 24);
            this.cboTipo.TabIndex = 14;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(81, 36);
            this.txtNum.Mask = "000009";
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(196, 23);
            this.txtNum.TabIndex = 13;
            // 
            // upDnPiso
            // 
            this.upDnPiso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.upDnPiso.Location = new System.Drawing.Point(81, 67);
            this.upDnPiso.Name = "upDnPiso";
            this.upDnPiso.Size = new System.Drawing.Size(58, 23);
            this.upDnPiso.TabIndex = 12;
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboUbicacion.Location = new System.Drawing.Point(373, 36);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(157, 24);
            this.cboUbicacion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Piso:";
            // 
            // BusquedaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 569);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gridHabitaciones);
            this.Name = "BusquedaHabitacion";
            this.Text = "BusquedaHabitacion";
            this.Load += new System.EventHandler(this.BusquedaHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHabitaciones)).EndInit();
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHabitaciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.NumericUpDown upDnPiso;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.CheckBox ckDisponible;
    }
}