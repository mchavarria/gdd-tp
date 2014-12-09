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
    public partial class BusquedaHotel : Form
    {
        public BusquedaHotel()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCiudad.Text = "";
            txtNombre.Text = "";
            txtPais.Text = "";
            numUpDnCantEstrellas.Value = 0;
        }
    }
}
