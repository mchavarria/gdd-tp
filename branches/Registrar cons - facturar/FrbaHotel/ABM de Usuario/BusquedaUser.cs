using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class BusquedaUser : Form
    {
        public BusquedaUser()
        {
            InitializeComponent();
        }

        static public decimal usuarioSelected = 0;
        SRol SRol = new SRol();
        SUsuario susuario = new SUsuario();
        SPersona sCliente = new SPersona();

        private void BusquedaUser_Load(object sender, EventArgs e)
        {
                
            List<Rol> roles = SRol.GetRolAsig();
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "codigo";
            cboRol.DataSource = roles;
            cargate();
        }

        public void cargate() {
            gripUser.DataSource = susuario.GetBySQLGRID("select u.codigo, u.user_nombre,u.logueado,u.intentos_fallidos,p.mail,u.estado from hotel.Usuario u, hotel.Usuario_hotel h, hotel.Persona p where p.codigo = u.cod_persona and h.cod_usuario = u.codigo and h.cod_hotel = " + Login.Log.hotel.ToString());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ckDisponible.Checked = false;
            txtMail.Text = "";
            txtUser.Text = "";
            cboRol.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.ABMUser usuarionuevo = new ABMUser();
            usuarionuevo.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ckDisponible.Checked == true || txtMail.Text != "" || txtUser.Text != "" || cboRol.Text != "")
            {
                StringBuilder Valores = new StringBuilder();
                if (ckDisponible.Checked == true)
                    Valores.Append("u.estado = " + 1 + " ");
                if ((ckDisponible.Checked == true && txtMail.Text != "") || (ckDisponible.Checked == true && txtUser.Text != "") ||
                    (ckDisponible.Checked == true && cboRol.Text != "")
                    ) Valores.Append(" and ");

                if (txtMail.Text != "")
                    Valores.Append("p.mail like '%" + txtMail.Text + "%' ");

                if ((txtMail.Text != "" && txtUser.Text != "") || (txtMail.Text != "" && cboRol.Text != "")) Valores.Append(" and ");

                if (txtUser.Text != "") Valores.Append(" u.user_name like '%" + txtUser.Text + "%'");

                if (txtUser.Text != "" && cboRol.Text != "") Valores.Append(" and ");

                if (cboRol.Text != "") Valores.Append(" rol.cod_rol =" + cboRol.SelectedValue);

                gripUser.DataSource = susuario.GetBySQLGRID("select u.codigo, u.user_nombre,u.logueado,u.intentos_fallidos,p.mail,u.estado from hotel.Usuario u, hotel.Usuario_hotel h, hotel.Rol_Usuario rol, hotel.Persona p where p.codigo = u.cod_persona and h.cod_usuario = u.codigo and h.cod_hotel = " + Login.Log.hotel.ToString() + " and " + Valores.ToString());
                
            }
            else gripUser.DataSource = susuario.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABM_de_Usuario.ABMUser seleccionar = new ABMUser();
                    usuarioSelected = decimal.Parse(gripUser.Rows[e.RowIndex].Cells[2].Value.ToString());
                    seleccionar.Show();
                }
                
                if(e.ColumnIndex == 1)
                {
                    // Eliminar
                    usuarioSelected = decimal.Parse(gripUser.Rows[e.RowIndex].Cells[2].Value.ToString());
                    try{
                    susuario.Delete(usuarioSelected);
                    MessageBox.Show("Operación exitosa!");
                    cargate();
                    }
                    catch(Exception ex) { }
                }
        }

        }
    }
}
