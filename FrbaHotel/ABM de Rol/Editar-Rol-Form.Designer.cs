namespace FrbaHotel.ABM_de_Rol
{
    partial class Editar_Rol_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.descripciontxt = new System.Windows.Forms.TextBox();
            this.activorbn = new System.Windows.Forms.RadioButton();
            this.inactivorbn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.rolaasignarcmb = new System.Windows.Forms.ComboBox();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.funcionalidadesbox = new System.Windows.Forms.ListBox();
            this.actualizarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion de rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado de rol:";
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(110, 19);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.ReadOnly = true;
            this.codigotxt.Size = new System.Drawing.Size(142, 20);
            this.codigotxt.TabIndex = 3;
            // 
            // descripciontxt
            // 
            this.descripciontxt.Location = new System.Drawing.Point(110, 46);
            this.descripciontxt.Name = "descripciontxt";
            this.descripciontxt.Size = new System.Drawing.Size(142, 20);
            this.descripciontxt.TabIndex = 4;
            // 
            // activorbn
            // 
            this.activorbn.AutoSize = true;
            this.activorbn.Location = new System.Drawing.Point(117, 76);
            this.activorbn.Name = "activorbn";
            this.activorbn.Size = new System.Drawing.Size(55, 17);
            this.activorbn.TabIndex = 5;
            this.activorbn.TabStop = true;
            this.activorbn.Text = "Activo";
            this.activorbn.UseVisualStyleBackColor = true;
            // 
            // inactivorbn
            // 
            this.inactivorbn.AutoSize = true;
            this.inactivorbn.Location = new System.Drawing.Point(189, 76);
            this.inactivorbn.Name = "inactivorbn";
            this.inactivorbn.Size = new System.Drawing.Size(63, 17);
            this.inactivorbn.TabIndex = 6;
            this.inactivorbn.TabStop = true;
            this.inactivorbn.Text = "Inactivo";
            this.inactivorbn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inactivorbn);
            this.groupBox1.Controls.Add(this.codigotxt);
            this.groupBox1.Controls.Add(this.activorbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descripciontxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.agregarbtn);
            this.groupBox2.Controls.Add(this.rolaasignarcmb);
            this.groupBox2.Controls.Add(this.eliminarbtn);
            this.groupBox2.Controls.Add(this.funcionalidadesbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 271);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles asignados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Agregar rol";
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(124, 78);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarbtn.TabIndex = 13;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            // 
            // rolaasignarcmb
            // 
            this.rolaasignarcmb.FormattingEnabled = true;
            this.rolaasignarcmb.Location = new System.Drawing.Point(6, 51);
            this.rolaasignarcmb.Name = "rolaasignarcmb";
            this.rolaasignarcmb.Size = new System.Drawing.Size(193, 21);
            this.rolaasignarcmb.TabIndex = 12;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Location = new System.Drawing.Point(360, 221);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarbtn.TabIndex = 1;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // funcionalidadesbox
            // 
            this.funcionalidadesbox.FormattingEnabled = true;
            this.funcionalidadesbox.Location = new System.Drawing.Point(219, 19);
            this.funcionalidadesbox.Name = "funcionalidadesbox";
            this.funcionalidadesbox.Size = new System.Drawing.Size(216, 199);
            this.funcionalidadesbox.TabIndex = 0;
            // 
            // actualizarbtn
            // 
            this.actualizarbtn.Location = new System.Drawing.Point(372, 414);
            this.actualizarbtn.Name = "actualizarbtn";
            this.actualizarbtn.Size = new System.Drawing.Size(75, 23);
            this.actualizarbtn.TabIndex = 10;
            this.actualizarbtn.Text = "Actualizar";
            this.actualizarbtn.UseVisualStyleBackColor = true;
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(291, 414);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 11;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // Editar_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 470);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.actualizarbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editar_Rol_Form";
            this.Text = "Editar_Rol_Form";
            this.Load += new System.EventHandler(this.Editar_Rol_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox descripciontxt;
        private System.Windows.Forms.RadioButton activorbn;
        private System.Windows.Forms.RadioButton inactivorbn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.ComboBox rolaasignarcmb;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.ListBox funcionalidadesbox;
        private System.Windows.Forms.Button actualizarbtn;
        private System.Windows.Forms.Button cancelarbtn;
    }
}