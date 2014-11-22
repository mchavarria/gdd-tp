using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Estadia : Form
    {
        public Estadia()
        {
            InitializeComponent();
        }

        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendarioDesde.Visible = true;
        }

        private void btnCalendarioHasta_Click(object sender, EventArgs e)
        {
            calendarioHasta.Visible = true;
        }

        private void calendarioDesde_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDesde.Text = e.Start.ToShortDateString();
            calendarioDesde.Visible = false;
        }

        private void calendarioHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtHasta.Text = e.Start.ToShortDateString();
            calendarioHasta.Visible = false;
        }
    }
}
