﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class BusquedaRegimen : Form
    {
        public BusquedaRegimen()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescr.Text = "";
            txtPrecio.Text = "";
            cargate();
        }

        SRegimen sRegimen = new SRegimen();
        static public decimal codHotel = 0;
        static public decimal selectedReg = 0;
        static public BusquedaRegimen ventanabusqreg;

        public void cargate()
        {
            gridRegimen.DataSource = sRegimen.GetAllHotel(codHotel);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "" || txtDescr.Text.Trim() != "" || txtPrecio.Text.Trim() != "")
            {
                StringBuilder Valores = new StringBuilder();
                if (txtCodigo.Text.Trim() != "")
                    Valores.Append("h.cod_regimen like '%" + txtCodigo.Text.Trim() + "%' ");

                if (txtCodigo.Text.Trim() != "" && (txtDescr.Text.Trim() != "" || txtPrecio.Text.Trim() != ""))
                    Valores.Append(" and ");

                if (txtDescr.Text.Trim() != "")
                    Valores.Append("r.descripcion like '%" + txtDescr.Text + "%' ");

                if (txtDescr.Text.Trim() != "" && txtPrecio.Text.Trim() != "") Valores.Append(" and ");

                if (txtPrecio.Text.Trim() != "") Valores.Append(" h.precio_base like '%" + txtPrecio.Text + "%'");

                gridRegimen.DataSource = sRegimen.GetBySQLDTO("select h.cod_regimen, r.descripcion, h.cod_hotel, h.precio_base, h.estado from hotel.Regimen r, hotel.Regimen_Hotel h where h.cod_regimen = r.codigo and h.cod_hotel = "+ codHotel + " and " + Valores.ToString());
            }
            else cargate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABM_de_Regimen.ABMRegimen select = new ABMRegimen();
                    selectedReg = decimal.Parse(gridRegimen.Rows[e.RowIndex].Cells[2].Value.ToString());
                    select.Show();
                }

                if (e.ColumnIndex == 1)
                {
                    // Eliminar
                    selectedReg = decimal.Parse(gridRegimen.Rows[e.RowIndex].Cells[2].Value.ToString());
                    sRegimen.Delete(selectedReg, codHotel);
                    MessageBox.Show("Operación exitosa!");
                }
            }
        }

        private void BusquedaRegimen_Load(object sender, EventArgs e)
        {
            codHotel = Login.Log.hotel;
            ventanabusqreg = this;
            cargate();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABMRegimen ventana = new ABMRegimen();
            ventana.Show();
        }

    }
}
