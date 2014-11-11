using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Login;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Editar_Rol_Form : Form
    {

        public Editar_Rol_Form()
        {
            InitializeComponent();
        }

        private void Editar_Rol_Form_Load(object sender, EventArgs e)
        {
        }

        internal void setCodigoRol(string codigoRol)
        {
            codigotxt.Text = codigoRol;
        }

        internal void setDescripcionRol(string descripcionRol)
        {
            descripciontxt.Text = descripcionRol;
        }

        internal void setEstadoRol(bool estadoRol)
        {
            if (estadoRol)
            {
                activorbn.Checked = true;
            }
            else
            {
                inactivorbn.Checked = true;
            }
        }

        internal void cargarFuncionalidades()
        {
            Funcionalidades funcionalidadesOb = new Funcionalidades();
            DataSet dataSet = funcionalidadesOb.buscarFuncionalidadesPorRol(codigotxt.Text);
            DataSet todasFuncDataSet = funcionalidadesOb.buscarFuncionalidades();

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                funcionalidadesbox.Items.Add(dataRow["codigo"].ToString() + "-" + dataRow["descripcion"].ToString());
            }

            foreach (DataRow dataRow in todasFuncDataSet.Tables[0].Rows)
            {
                rolaasignarcmb.Items.Add(dataRow["codigo"].ToString() + "-" + dataRow["descripcion"].ToString());
            }
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
