using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
        }
        ABM_de_Cliente.BusquedaCliente ventanaBusqCliente;
        SPersona sPersona = new SPersona();

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

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            ventanaBusqCliente = this;
            STipoDoc stip = new STipoDoc();
            List<TipoDoc> tipos = stip.GetAll();
            cboTipo.DisplayMember = "descripcion";
            cboTipo.ValueMember = "codigo";
            cboTipo.DataSource = tipos;


        }

        public void cargate()
        {
            gridClientes.DataSource = sPersona.GetAllClientes();

        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
