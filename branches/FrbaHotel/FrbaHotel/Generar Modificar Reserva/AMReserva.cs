using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class AMReserva : Form
    {
        public AMReserva()
        {
            InitializeComponent();
        }

        private void btnCalendarioCarga_Click(object sender, EventArgs e)
        {
            calendNacimiento.Visible = true;
        }

        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendarioDesde.Visible = true;
        }

        private void btnCalendarioHasta_Click(object sender, EventArgs e)
        {
            calendarioHasta.Visible = true;
        }

        private void calendarioHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtHasta.Text = e.Start.ToShortDateString();
            calendarioHasta.Visible = false;
        }

        private void calendarioDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDesde.Text = e.Start.ToShortDateString();
            calendarioDesde.Visible = false;
        }

        private void calendNacimiento_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaCarga.Text = e.Start.ToShortDateString();
            calendNacimiento.Visible = false;
        }

    }
}
