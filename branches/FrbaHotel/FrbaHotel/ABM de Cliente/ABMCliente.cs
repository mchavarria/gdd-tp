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
    public partial class ABMCliente : Form
    {
        public ABMCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtLocalidad.Text = "";
            txtMail.Text = "";
            txtNacimiento.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtNumDNI.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            cboTipoDNI.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendNacimiento.Visible = true;
        }

        private void calendNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNacimiento.Text = e.Start.ToShortDateString();
        }
    }
}
