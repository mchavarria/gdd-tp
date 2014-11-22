namespace FrbaHotel.Registrar_Estadia
{
    partial class Estadia
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
            this.btnCompletarDatos = new System.Windows.Forms.Button();
            this.txtNumReserva = new System.Windows.Forms.MaskedTextBox();
            this.ckDisponible = new System.Windows.Forms.CheckBox();
            this.lblNumRes = new System.Windows.Forms.Label();
            this.calendarioHasta = new System.Windows.Forms.MonthCalendar();
            this.btnCalendarioHasta = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.calendarioDesde = new System.Windows.Forms.MonthCalendar();
            this.btnCalendarioDesde = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(490, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.btnCompletarDatos);
            this.gpoBoxAlta.Controls.Add(this.txtNumReserva);
            this.gpoBoxAlta.Controls.Add(this.ckDisponible);
            this.gpoBoxAlta.Controls.Add(this.lblNumRes);
            this.gpoBoxAlta.Controls.Add(this.calendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.lblHasta);
            this.gpoBoxAlta.Controls.Add(this.txtHasta);
            this.gpoBoxAlta.Controls.Add(this.calendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.txtDesde);
            this.gpoBoxAlta.Controls.Add(this.lblDesde);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(577, 296);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Check In - Out";
            // 
            // btnCompletarDatos
            // 
            this.btnCompletarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarDatos.Location = new System.Drawing.Point(357, 22);
            this.btnCompletarDatos.Name = "btnCompletarDatos";
            this.btnCompletarDatos.Size = new System.Drawing.Size(153, 51);
            this.btnCompletarDatos.TabIndex = 13;
            this.btnCompletarDatos.Text = "Completar Datos Cliente";
            this.btnCompletarDatos.UseVisualStyleBackColor = true;
            this.btnCompletarDatos.Visible = false;
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Enabled = false;
            this.txtNumReserva.Location = new System.Drawing.Point(144, 40);
            this.txtNumReserva.Mask = "99999999";
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(95, 23);
            this.txtNumReserva.TabIndex = 50;
            // 
            // ckDisponible
            // 
            this.ckDisponible.AutoSize = true;
            this.ckDisponible.Enabled = false;
            this.ckDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDisponible.Location = new System.Drawing.Point(245, 40);
            this.ckDisponible.Name = "ckDisponible";
            this.ckDisponible.Size = new System.Drawing.Size(106, 22);
            this.ckDisponible.TabIndex = 47;
            this.ckDisponible.Text = "Disponible";
            this.ckDisponible.UseVisualStyleBackColor = true;
            // 
            // lblNumRes
            // 
            this.lblNumRes.AutoSize = true;
            this.lblNumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRes.Location = new System.Drawing.Point(10, 40);
            this.lblNumRes.Name = "lblNumRes";
            this.lblNumRes.Size = new System.Drawing.Size(128, 20);
            this.lblNumRes.TabIndex = 41;
            this.lblNumRes.Text = "Núm. de reserva:";
            // 
            // calendarioHasta
            // 
            this.calendarioHasta.Location = new System.Drawing.Point(341, 114);
            this.calendarioHasta.Name = "calendarioHasta";
            this.calendarioHasta.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1816, 11, 8, 0, 0, 0, 0), new System.DateTime(1816, 11, 14, 0, 0, 0, 0));
            this.calendarioHasta.TabIndex = 38;
            this.calendarioHasta.Visible = false;
            this.calendarioHasta.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioHasta_DateSelected);
            // 
            // btnCalendarioHasta
            // 
            this.btnCalendarioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioHasta.Location = new System.Drawing.Point(235, 113);
            this.btnCalendarioHasta.Name = "btnCalendarioHasta";
            this.btnCalendarioHasta.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioHasta.TabIndex = 37;
            this.btnCalendarioHasta.Text = "Seleccionar";
            this.btnCalendarioHasta.UseVisualStyleBackColor = true;
            this.btnCalendarioHasta.Click += new System.EventHandler(this.btnCalendarioHasta_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(10, 114);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(102, 20);
            this.lblHasta.TabIndex = 36;
            this.lblHasta.Text = "Fecha hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(136, 114);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(93, 23);
            this.txtHasta.TabIndex = 35;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // calendarioDesde
            // 
            this.calendarioDesde.Location = new System.Drawing.Point(341, 73);
            this.calendarioDesde.Name = "calendarioDesde";
            this.calendarioDesde.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1816, 11, 8, 0, 0, 0, 0), new System.DateTime(1816, 11, 14, 0, 0, 0, 0));
            this.calendarioDesde.TabIndex = 34;
            this.calendarioDesde.Visible = false;
            this.calendarioDesde.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioDesde_DateSelected);
            // 
            // btnCalendarioDesde
            // 
            this.btnCalendarioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioDesde.Location = new System.Drawing.Point(235, 73);
            this.btnCalendarioDesde.Name = "btnCalendarioDesde";
            this.btnCalendarioDesde.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioDesde.TabIndex = 33;
            this.btnCalendarioDesde.Text = "Seleccionar";
            this.btnCalendarioDesde.UseVisualStyleBackColor = true;
            this.btnCalendarioDesde.Click += new System.EventHandler(this.btnCalendarioDesde_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(136, 74);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(93, 23);
            this.txtDesde.TabIndex = 32;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(10, 74);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(106, 20);
            this.lblDesde.TabIndex = 14;
            this.lblDesde.Text = "Fecha desde:";
            // 
            // Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 350);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "Estadia";
            this.Text = "Estadia";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.CheckBox ckDisponible;
        private System.Windows.Forms.Label lblNumRes;
        private System.Windows.Forms.MonthCalendar calendarioHasta;
        private System.Windows.Forms.Button btnCalendarioHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.MonthCalendar calendarioDesde;
        private System.Windows.Forms.Button btnCalendarioDesde;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnCompletarDatos;
        private System.Windows.Forms.MaskedTextBox txtNumReserva;
    }
}