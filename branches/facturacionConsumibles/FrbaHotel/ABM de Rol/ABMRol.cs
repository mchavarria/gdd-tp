using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class ABMRol : Form
    {
        SRol sRol = new SRol();
        SFuncion sFuncion = new SFuncion();
        public ABMRol()
        {
            InitializeComponent();
        }

        public static decimal valorL;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BuildRol();
            try
            {

                if (valorL > 0){
                    List<Funcion> funcionesDelRol = sFuncion.GetBySQL("select * from hotel.Rol_Funcion r where r.cod_funcion = "+cboFunc.SelectedValue.ToString()+" and r.cod_rol =" + valorL);
                    if(funcionesDelRol.Count() == 0){
                        sRol.Update(rol,decimal.Parse(cboFunc.SelectedValue.ToString()));
                    }
                }
                else
                    sRol.Save(rol,decimal.Parse(cboFunc.SelectedValue.ToString()));

                MessageBox.Show("Operación exitosa!");
                ABM_de_Rol.BusquedaRoles.ventana.cargate();
                ABM_de_Rol.BusquedaRoles.codSelected = 0;
                this.Close(); 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación!");
            }
            finally
            {
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cboFunc.Text = "";
            ckActiva.Checked = false;
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            valorL = ABM_de_Rol.BusquedaRoles.codSelected;
            List<Funcion> funciones = sFuncion.GetAll();
            cboFunc.DisplayMember = "descripcion";
            cboFunc.ValueMember = "codigo";
            cboFunc.DataSource = funciones;

            if (valorL > 0)
            {
                LoadRol(valorL);
            }
        }
        Rol rol = new Rol();
        private void LoadRol(decimal codRol)
        {
            List<Rol> roles = sRol.GetBySQL("select * from hotel.Rol r where r.codigo = " + codRol);
            rol = roles.SingleOrDefault();
            txtNombre.Text = rol.descripcion;
            ckActiva.Checked = rol.estado;

            //para poder dar de alta otra funcionabilidad
            List<Funcion> funciones = sFuncion.GetAll();
            cboFunc.DisplayMember = "descripcion";
            cboFunc.ValueMember = "codigo";
            cboFunc.DataSource = funciones;
        }

        private void BuildRol()
        {
            if (valorL > 0)
                rol.codigo = valorL;
            rol.descripcion = txtNombre.Text;
            rol.estado = ckActiva.Checked;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (cboFunc.Text != "" && valorL > 0) {
                List<Funcion> funcionesDelRol = sFuncion.GetBySQL("select * from hotel.Rol_Funcion r where r.cod_funcion = " + cboFunc.SelectedValue.ToString() + " and r.cod_rol =" + valorL);
                if (funcionesDelRol.Count() != 0)
                {
                    try{
                    sRol.GetBySQL("delete hotel.Rol_Funcion f where f.cod_funcion =" + cboFunc.SelectedValue.ToString() + " and f.cod_rol = " +valorL);
                        }

                        catch (Exception ex)
                        {
                        }
                }
            }
        }
    }
}
