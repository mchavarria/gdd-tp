using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            cboTipo.ResetText();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
