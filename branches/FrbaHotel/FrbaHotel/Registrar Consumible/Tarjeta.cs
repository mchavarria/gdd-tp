using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {
            InitializeComponent();
        }

        private void btnCalendarioHasta_Click(object sender, EventArgs e)
        {
            calendarioHasta.Visible = true;
        }

        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendarioDesde.Visible = true;
        }

        private void calendarioDesde_DateSelected(object sender, DateRangeEventArgs e)
        {
            calendarioDesde.Visible = false;
            txtEmision.Text = e.Start.ToShortDateString();
        }

        private void calendarioHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            calendarioHasta.Visible = false;
            txtFechaVence.Text = e.Start.ToShortDateString();
        }
    }
}
