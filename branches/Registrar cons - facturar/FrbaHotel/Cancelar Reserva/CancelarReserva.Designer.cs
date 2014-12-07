﻿namespace FrbaHotel.Cancelar_Reserva
{
    partial class CancelarReserva
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calendNacimiento = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtNumeroReserva = new System.Windows.Forms.MaskedTextBox();
            this.lblNumRes = new System.Windows.Forms.Label();
            this.lblMot = new System.Windows.Forms.Label();
            this.btnCalendarioCarga = new System.Windows.Forms.Button();
            this.txtFechaCancela = new System.Windows.Forms.MaskedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFechaCanc = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(518, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 252);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.textBox1);
            this.gpoBoxAlta.Controls.Add(this.calendNacimiento);
            this.gpoBoxAlta.Controls.Add(this.richTextBox1);
            this.gpoBoxAlta.Controls.Add(this.txtNumeroReserva);
            this.gpoBoxAlta.Controls.Add(this.lblNumRes);
            this.gpoBoxAlta.Controls.Add(this.lblMot);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioCarga);
            this.gpoBoxAlta.Controls.Add(this.txtFechaCancela);
            this.gpoBoxAlta.Controls.Add(this.lblUser);
            this.gpoBoxAlta.Controls.Add(this.lblFechaCanc);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(624, 234);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Cancelación";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(174, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 54;
            // 
            // calendNacimiento
            // 
            this.calendNacimiento.Location = new System.Drawing.Point(389, 60);
            this.calendNacimiento.Name = "calendNacimiento";
            this.calendNacimiento.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1816, 11, 8, 0, 0, 0, 0), new System.DateTime(1816, 11, 14, 0, 0, 0, 0));
            this.calendNacimiento.TabIndex = 53;
            this.calendNacimiento.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(287, 96);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = "";
            // 
            // txtNumeroReserva
            // 
            this.txtNumeroReserva.Enabled = false;
            this.txtNumeroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReserva.Location = new System.Drawing.Point(174, 28);
            this.txtNumeroReserva.Mask = "999999999";
            this.txtNumeroReserva.Name = "txtNumeroReserva";
            this.txtNumeroReserva.Size = new System.Drawing.Size(87, 24);
            this.txtNumeroReserva.TabIndex = 51;
            this.txtNumeroReserva.Visible = false;
            // 
            // lblNumRes
            // 
            this.lblNumRes.AutoSize = true;
            this.lblNumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRes.Location = new System.Drawing.Point(11, 31);
            this.lblNumRes.Name = "lblNumRes";
            this.lblNumRes.Size = new System.Drawing.Size(157, 18);
            this.lblNumRes.TabIndex = 50;
            this.lblNumRes.Text = "Número de reserva:";
            this.lblNumRes.Visible = false;
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot.Location = new System.Drawing.Point(10, 95);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(59, 20);
            this.lblMot.TabIndex = 42;
            this.lblMot.Text = "Motivo:";
            // 
            // btnCalendarioCarga
            // 
            this.btnCalendarioCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioCarga.Location = new System.Drawing.Point(283, 60);
            this.btnCalendarioCarga.Name = "btnCalendarioCarga";
            this.btnCalendarioCarga.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioCarga.TabIndex = 7;
            this.btnCalendarioCarga.Text = "Seleccionar";
            this.btnCalendarioCarga.UseVisualStyleBackColor = true;
            // 
            // txtFechaCancela
            // 
            this.txtFechaCancela.Enabled = false;
            this.txtFechaCancela.Location = new System.Drawing.Point(184, 62);
            this.txtFechaCancela.Mask = "00/00/0000";
            this.txtFechaCancela.Name = "txtFechaCancela";
            this.txtFechaCancela.Size = new System.Drawing.Size(93, 23);
            this.txtFechaCancela.TabIndex = 28;
            this.txtFechaCancela.ValidatingType = typeof(System.DateTime);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(10, 199);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(158, 20);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "Usuario que cancela:";
            // 
            // lblFechaCanc
            // 
            this.lblFechaCanc.AutoSize = true;
            this.lblFechaCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCanc.Location = new System.Drawing.Point(10, 62);
            this.lblFechaCanc.Name = "lblFechaCanc";
            this.lblFechaCanc.Size = new System.Drawing.Size(168, 20);
            this.lblFechaCanc.TabIndex = 18;
            this.lblFechaCanc.Text = "Fecha de cancelación:";
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 287);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "CancelarReserva";
            this.Text = "Cancelar Reserva";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.Button btnCalendarioCarga;
        private System.Windows.Forms.MaskedTextBox txtFechaCancela;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFechaCanc;
        private System.Windows.Forms.MaskedTextBox txtNumeroReserva;
        private System.Windows.Forms.Label lblNumRes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar calendNacimiento;
        private System.Windows.Forms.TextBox textBox1;
    }
}