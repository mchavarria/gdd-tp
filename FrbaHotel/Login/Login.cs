using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            UsuarioOb.Usuario = this.txtUsuario.Text;
            UsuarioOb.Password = this.txtPass.Text;

            if (UsuarioOb.Buscar() == true)
            {
                MessageBox.Show(UsuarioOb.Mensaje, "Login");
                
                Inicial inicialForm = new Inicial();
                inicialForm.Tag = this;
                inicialForm.setUsuario(UsuarioOb.Usuario);
                inicialForm.ShowMenues(UsuarioOb.GetModulos());
                inicialForm.HideLogin();
                inicialForm.showLogout();
                inicialForm.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show(UsuarioOb.Mensaje, "Error");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
