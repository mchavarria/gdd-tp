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
    public partial class Editar_Rol : Form
    {
        public Editar_Rol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoRol = codigoRoltxt.Text;
            string descripcionRol = descRoltxt.Text;
            string estado = estadoRolcmb.Text;

            Funcionalidades funcionalidades = new Funcionalidades();
            DataSet dataSet = funcionalidades.buscarRoles(codigoRol, descripcionRol, estado);

            tablaRolestbl.DataSource = dataSet.Tables[0];

            tablaRolestbl.ReadOnly = true;

            //agrego boton de seleccion
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            tablaRolestbl.Columns.Add(btn);
            btn.HeaderText = "Seleccionar";
            btn.Text = "Seleccionar";
            btn.Name = "seleccionarbtn";
            btn.UseColumnTextForButtonValue = true;
            btn.ReadOnly = false;


            //muestro la tabla de resultado          
            tablaRolestbl.Visible = true;
        }

        private void tablaRolestbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewCell codigoCell = tablaRolestbl.Rows[e.RowIndex].Cells["codigo"];
                DataGridViewCell descripcionCell = tablaRolestbl.Rows[e.RowIndex].Cells["descripcion"];
                DataGridViewCell estadoCell = tablaRolestbl.Rows[e.RowIndex].Cells["estado"];

                Editar_Rol_Form editarRolForm = new Editar_Rol_Form();
                editarRolForm.setCodigoRol(codigoCell.Value.ToString());
                editarRolForm.setDescripcionRol(descripcionCell.Value.ToString());

                string estadostr = estadoCell.Value.ToString();

                editarRolForm.setEstadoRol(estadostr == "True");
                editarRolForm.cargarFuncionalidades();

                editarRolForm.Show();
            }
        }

    }
}
