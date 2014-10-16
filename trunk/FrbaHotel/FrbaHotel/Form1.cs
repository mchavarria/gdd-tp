using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Inicial : Form
    {
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
    }
}
