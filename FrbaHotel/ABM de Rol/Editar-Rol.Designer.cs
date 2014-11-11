namespace FrbaHotel.ABM_de_Rol
{
    partial class Editar_Rol
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
            this.codigoRoltxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoRolcmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descRoltxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tablaRolestbl = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRolestbl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigoRoltxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.estadoRolcmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descRoltxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // codigoRoltxt
            // 
            this.codigoRoltxt.Location = new System.Drawing.Point(90, 51);
            this.codigoRoltxt.Name = "codigoRoltxt";
            this.codigoRoltxt.Size = new System.Drawing.Size(100, 20);
            this.codigoRoltxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo rol";
            // 
            // estadoRolcmb
            // 
            this.estadoRolcmb.FormattingEnabled = true;
            this.estadoRolcmb.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estadoRolcmb.Location = new System.Drawing.Point(383, 16);
            this.estadoRolcmb.Name = "estadoRolcmb";
            this.estadoRolcmb.Size = new System.Drawing.Size(121, 21);
            this.estadoRolcmb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion rol";
            // 
            // descRoltxt
            // 
            this.descRoltxt.Location = new System.Drawing.Point(90, 16);
            this.descRoltxt.Name = "descRoltxt";
            this.descRoltxt.Size = new System.Drawing.Size(196, 20);
            this.descRoltxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tablaRolestbl
            // 
            this.tablaRolestbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRolestbl.Location = new System.Drawing.Point(12, 139);
            this.tablaRolestbl.Name = "tablaRolestbl";
            this.tablaRolestbl.Size = new System.Drawing.Size(540, 225);
            this.tablaRolestbl.TabIndex = 3;
            this.tablaRolestbl.Visible = false;
            this.tablaRolestbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRolestbl_CellClick);
            // 
            // Editar_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 376);
            this.Controls.Add(this.tablaRolestbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editar_Rol";
            this.Text = "Editar Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRolestbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox estadoRolcmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descRoltxt;
        private System.Windows.Forms.TextBox codigoRoltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablaRolestbl;
    }
}