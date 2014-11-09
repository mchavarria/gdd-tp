using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.Login;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Alta_Rol : Form
    {
        public Alta_Rol()
        {
            InitializeComponent();
        }

        private void cancelaltarolbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ActivarRadioButton()
        {
            altarolactivorbtn.PerformClick();
        }

        public void CargarFuncionalidades()
        {
            Funcionalidades funcionalidadesOb = new Funcionalidades();
            DataSet dataSet = funcionalidadesOb.buscarFuncionalidades();

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                funcionalidadesBox.Items.Add(dataRow["codigo"].ToString() + " - " + dataRow["descripcion"].ToString(), false);
            }
        }
    }
}
