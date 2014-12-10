using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_Hotel
{
    public partial class ABMHotel : Form
    {
        public ABMHotel()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtFechaCreacion.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            cboRegimen.ResetText();
            numUpDnCantEstrellas.Value = 0;
        }
    }
}
