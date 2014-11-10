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
                funcionalidadesBox.Items.Add(dataRow["codigo"].ToString() + "-" + dataRow["descripcion"].ToString(), false);
            }
        }

        private void altarolbtn_Click(object sender, EventArgs e)
        {
            string parametrosAltaRol = "";
            string prefijo = "";

   


            foreach (object itemChecked in funcionalidadesBox.CheckedItems)
            {
                string itemSeleccionado = itemChecked.ToString();

                string[] itemArray = itemSeleccionado.Split('-');

                string codigoFuncion = itemArray[0];
                string descripcionFuncion = itemArray[1];

                parametrosAltaRol = parametrosAltaRol + prefijo + codigoFuncion;
                prefijo = ",";
            }

            Funcionalidades funcionalidadesOb = new Funcionalidades();
            string descripcionRol = descripcionRoltxt.Text;
            
            int estado = 0;
            if(altarolactivorbtn.Checked) {
                estado = 1;
            }
            
            funcionalidadesOb.altaRol(descripcionRol, estado, parametrosAltaRol);

            MessageBox.Show("Rol agregado correctamente", "Alta-Rol");

            Close();
        }
    }
}
