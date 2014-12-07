using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class Facturar : Form
    {
        private SFactura sFactura = new SFactura();
        private SReserva sReserva = new SReserva();

        private decimal total = 0;
        
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            numFacttxt.Text = sFactura.getNextNumber().ToString();
            fechatxt.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO Grabar factura
        }

        private void cargarReservabtn_Click(object sender, EventArgs e)
        {
            //TODO Validar campos

            List<ItemFactura> itemsFactura = sFactura.getItemsFactura(numReservatxt.Text);

            gridItems.DataSource = itemsFactura;

            SConsumible sConsumible = new SConsumible();

            List<Consumible> consumibles = sConsumible.GetConsumiblesPorReserva(numReservatxt.Text);

            gridConsumos.DataSource = consumibles;

            txtMontoTotal.Text = calcularTotal(consumibles).ToString();

            btnGuardar.Enabled = true;
        }

        private decimal calcularTotal(List<Consumible> consumibles)
        {
            foreach(Consumible c in consumibles) {
                total += (c.precio * c.cantidad);
            }

            return total;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //TODO Limpiar campos
        }
    }
}
