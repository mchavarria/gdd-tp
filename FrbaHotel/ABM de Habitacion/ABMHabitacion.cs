using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class FormAltaHabitacion : Form
    {
        public FormAltaHabitacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rcTxtComodidades.Visible = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numUpNumHab.Value = 0;
            upDnPiso.Value = 0;
            cboUbicacion.ResetText();
            cboTipo.ResetText();
            upDnPiso.Value = 0;
            rcTxtComodidades.Text = "";
        }
        
    }
}
