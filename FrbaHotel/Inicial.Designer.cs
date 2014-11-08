namespace FrbaHotel
{
    partial class Inicial
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ROL1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ROL2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ROL3 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(551, 1);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ROL1,
            this.ROL2,
            this.ROL3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "ABM Roles";
            this.toolStripMenuItem1.Visible = false;
            // 
            // ROL1
            // 
            this.ROL1.AccessibleName = "1";
            this.ROL1.Name = "ROL1";
            this.ROL1.Size = new System.Drawing.Size(152, 22);
            this.ROL1.Text = "Alta Rol";
            this.ROL1.Visible = false;
            this.ROL1.Click += new System.EventHandler(this.altaRolToolStripMenuItem_Click);
            // 
            // ROL2
            // 
            this.ROL2.Name = "ROL2";
            this.ROL2.Size = new System.Drawing.Size(152, 22);
            this.ROL2.Text = "Baja Rol";
            this.ROL2.Visible = false;
            // 
            // ROL3
            // 
            this.ROL3.Name = "ROL3";
            this.ROL3.Size = new System.Drawing.Size(152, 22);
            this.ROL3.Text = "Editar Rol";
            this.ROL3.Visible = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(551, 1);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Visible = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 281);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ROL1;
        private System.Windows.Forms.ToolStripMenuItem ROL2;
        private System.Windows.Forms.ToolStripMenuItem ROL3;
        private System.Windows.Forms.Button logoutbtn;


    }
}

