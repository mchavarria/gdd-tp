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
    public partial class BusquedaHabitacion : Form
    {
        public BusquedaHabitacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroHab = int.Parse(txtNum.Text);
            int pisoHab = (int)upDnPiso.Value;
            string ubicacion = cboUbicacion.Text;
            int idTipo = cboTipo.SelectedIndex;
            bool disponible = ckDisponible.Checked;





        }

        private void BusquedaHabitacion_Load(object sender, EventArgs e)
        {
            string rol = FormIni.rol;
            
            if (rol == "Administrador") {
                Delete.Visible = true; 
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
