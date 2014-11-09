using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Login;

namespace FrbaHotel
{
    public partial class Inicial : Form
    {
        private string Usuario;

        public void setUsuario(string Usuario) {
            this.Usuario = Usuario;
        }

        public Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // vamos a la pagina de login
            
            Login.LoginForm loginForm = new Login.LoginForm();
            loginForm.Tag = this;
            loginForm.Show(this);
            Hide();
        }

        internal void ShowMenues(List<string> codigosFunciones)
        {       
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if ("toolStripMenuItem1" == item.Name)
                {
                    foreach (ToolStripMenuItem subitem in item.DropDown.Items)
                    {
                        foreach (string codigoFuncion in codigosFunciones)
                        {
                            if (codigoFuncion == subitem.Name)
                            {
                                item.Visible = true;
                                subitem.Visible = true;
                            }
                        }
                    }
                    
                }
            }
        }

        private void altaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.Alta_Rol altaRolForm = new ABM_de_Rol.Alta_Rol();
            altaRolForm.Tag = this;
            altaRolForm.ActivarRadioButton();
            altaRolForm.CargarFuncionalidades();
            altaRolForm.Show(this);
            //Hide();
        }

        internal void HideLogin()
        {
            this.loginbtn.Visible = false;
        }

        internal void showLogout()
        {
            this.logoutbtn.Visible = true;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            UsuarioOb.Usuario = this.Usuario;

            UsuarioOb.LogOut();
            Close();    
        }
    }
}
