namespace FrbaHotel.ABM_de_Rol
{
    partial class Alta_Rol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.altarolnoactivorbtn = new System.Windows.Forms.RadioButton();
            this.altarolactivorbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionalidadesBox = new System.Windows.Forms.CheckedListBox();
            this.descripcionRoltxt = new System.Windows.Forms.TextBox();
            this.altarolbtn = new System.Windows.Forms.Button();
            this.cancelaltarolbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.altarolnoactivorbtn);
            this.groupBox1.Controls.Add(this.altarolactivorbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.funcionalidadesBox);
            this.groupBox1.Controls.Add(this.descripcionRoltxt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de rol";
            // 
            // altarolnoactivorbtn
            // 
            this.altarolnoactivorbtn.AutoSize = true;
            this.altarolnoactivorbtn.Location = new System.Drawing.Point(147, 196);
            this.altarolnoactivorbtn.Name = "altarolnoactivorbtn";
            this.altarolnoactivorbtn.Size = new System.Drawing.Size(71, 17);
            this.altarolnoactivorbtn.TabIndex = 7;
            this.altarolnoactivorbtn.TabStop = true;
            this.altarolnoactivorbtn.Text = "No activo";
            this.altarolnoactivorbtn.UseVisualStyleBackColor = true;
            // 
            // altarolactivorbtn
            // 
            this.altarolactivorbtn.AutoSize = true;
            this.altarolactivorbtn.Location = new System.Drawing.Point(13, 196);
            this.altarolactivorbtn.Name = "altarolactivorbtn";
            this.altarolactivorbtn.Size = new System.Drawing.Size(55, 17);
            this.altarolactivorbtn.TabIndex = 6;
            this.altarolactivorbtn.TabStop = true;
            this.altarolactivorbtn.Text = "Activo";
            this.altarolactivorbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado de rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciones las funcionalidades a agregar";
            // 
            // funcionalidadesBox
            // 
            this.funcionalidadesBox.FormattingEnabled = true;
            this.funcionalidadesBox.Location = new System.Drawing.Point(10, 82);
            this.funcionalidadesBox.Name = "funcionalidadesBox";
            this.funcionalidadesBox.Size = new System.Drawing.Size(243, 94);
            this.funcionalidadesBox.TabIndex = 3;
            // 
            // descripcionRoltxt
            // 
            this.descripcionRoltxt.Location = new System.Drawing.Point(10, 19);
            this.descripcionRoltxt.Name = "descripcionRoltxt";
            this.descripcionRoltxt.Size = new System.Drawing.Size(243, 20);
            this.descripcionRoltxt.TabIndex = 0;
            // 
            // altarolbtn
            // 
            this.altarolbtn.Location = new System.Drawing.Point(197, 261);
            this.altarolbtn.Name = "altarolbtn";
            this.altarolbtn.Size = new System.Drawing.Size(75, 23);
            this.altarolbtn.TabIndex = 1;
            this.altarolbtn.Text = "Grabar";
            this.altarolbtn.UseVisualStyleBackColor = true;
            this.altarolbtn.Click += new System.EventHandler(this.altarolbtn_Click);
            // 
            // cancelaltarolbtn
            // 
            this.cancelaltarolbtn.Location = new System.Drawing.Point(116, 260);
            this.cancelaltarolbtn.Name = "cancelaltarolbtn";
            this.cancelaltarolbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelaltarolbtn.TabIndex = 2;
            this.cancelaltarolbtn.Text = "Cancelar";
            this.cancelaltarolbtn.UseVisualStyleBackColor = true;
            this.cancelaltarolbtn.Click += new System.EventHandler(this.cancelaltarolbtn_Click);
            // 
            // Alta_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 300);
            this.Controls.Add(this.cancelaltarolbtn);
            this.Controls.Add(this.altarolbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta_Rol";
            this.Text = "Alta_Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcionRoltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox funcionalidadesBox;
        private System.Windows.Forms.Button altarolbtn;
        private System.Windows.Forms.Button cancelaltarolbtn;
        private System.Windows.Forms.RadioButton altarolnoactivorbtn;
        private System.Windows.Forms.RadioButton altarolactivorbtn;
        private System.Windows.Forms.Label label3;
    }
}