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

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            //TODO validar repetidos
            funcionalidadesbox.Items.Add(rolaasignarcmb.SelectedItem);
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            funcionalidadesbox.Items.Remove(funcionalidadesbox.SelectedItem);
        }

        private void actualizarbtn_Click(object sender, EventArgs e)
        {
            //TODO agregar validaciones
            string parametrosEditarRol = "";
            string prefijo = "";

            foreach (object funcionalidad in funcionalidadesbox.Items)
            {
                string funcionalidadRow = funcionalidad.ToString();

                string[] funcionalidadArray = funcionalidadRow.Split('-');

                string codigoFuncion = funcionalidadArray[0];
                string descripcionFuncion = funcionalidadArray[1];

                parametrosEditarRol = parametrosEditarRol + prefijo + codigoFuncion;
                prefijo = ",";
            }

            Funcionalidades funcionalidadesOb = new Funcionalidades();
            string descripcionRol = descripciontxt.Text;

            int estado = 0;
            if (activorbn.Checked)
            {
                estado = 1;
            }

            funcionalidadesOb.editarRol(codigotxt.Text, descripcionRol, estado, parametrosEditarRol);

            MessageBox.Show("Rol Modificado correctamente", "Editar-Rol");

            Close();

        }
    }
}
