using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Editar_Rol_Form : Form
    {
        private string codigoRol;
        private string descripcionRol;

        public Editar_Rol_Form()
        {
            InitializeComponent();
        }

        private void Editar_Rol_Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show(codigoRol);
        }

        public void setCodigoRol(string codigoRol)
        {
            this.codigoRol = codigoRol;
        }

        internal void setDescripcionRol(string descripcionRol)
        {
            this.descripcionRol = descripcionRol;
        }
    }
}
