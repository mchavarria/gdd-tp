using System;
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
    public partial class ABMRegimen : Form
    {
        public ABMRegimen()
        {
            InitializeComponent();
        }

        static public decimal codReg = 0;
        static public decimal codhotel = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //variar precio de las que no estan usandose

            if (validar())
            {
                if (codReg == 0)
                {
                    BuildRegimen();
                }
                else
                {
                    //CARGAR MODIFICACIONES regimenes
                    BuildRegimen();
                }
                ABM_Hotel.BusquedaHotel.ventanaHotel.cargate();
            }
        }

        SRegimen sRegimen = new SRegimen();

        private void BuildRegimen()
        {
            RegimenDTO reg = new RegimenDTO();
            decimal precioAnterior = 0;

            if (codReg != 0)
            {
                reg = sRegimen.GetByCodDTO(codReg, codhotel);
                reg.cod_regimen = codReg;
                precioAnterior = reg.precio_base;
            }

            reg.cod_hotel = codhotel;
            reg.descripcion = cboDescrip.SelectedText;
            reg.estado = ckActivo.Checked;
            reg.precio_base = decimal.Parse(txtPrecio.Text);

            if (codReg == 0)
            {
                codReg = sRegimen.SaveDTO(reg);
            }
            else
            {
                if (reg.estado == false || (precioAnterior != reg.precio_base))
                { //darle de baja o modificar precio
                    SHotel sHotel = new SHotel();
                    var ocupado = sHotel.hotelOcupadoRegimen(reg.cod_hotel, reg.cod_regimen, DateTime.Now);
                    if (ocupado == false)
                    {
                        sRegimen.UpdateDTO(reg);
                        MessageBox.Show("Operación exitosa!");
                    }
                    else if (reg.estado == false)
                            MessageBox.Show("No puede dar de baja, hay reservas con este tipo de regimen!");
                    else MessageBox.Show("No puede modificar el precio, exisen reservas con este precio!");
                }
                else
                {
                    sRegimen.UpdateDTO(reg);
                    MessageBox.Show("Operación exitosa!");
                }
            }
        }

        private bool validar()
        {
            if ( 
            txtCodigo.Text.Trim() != "" &&
            cboDescrip.Text.Trim() != "" &&
            txtPrecio.Text.Trim() != "" )

                return true;
            else
            {
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

        private void cargarFormulario()
        {
            RegimenDTO reg = sRegimen.GetByCodDTO(codReg, codhotel);

            txtCodigo.Text = reg.cod_regimen.ToString();
            cboDescrip.Text = reg.descripcion;
            txtPrecio.Text = reg.precio_base.ToString();
            ckActivo.Checked = reg.estado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            cboDescrip.Text = "";
            txtPrecio.Text = "";
            ckActivo.Checked = false;
        }

        private void ABMRegimen_FormClosing(object sender, FormClosingEventArgs e)
        {
            ABM_de_Regimen.BusquedaRegimen.selectedReg = 0;
        }

        private void ABMRegimen_Load(object sender, EventArgs e)
        {
            codReg = ABM_de_Regimen.BusquedaRegimen.selectedReg;
            codhotel = ABM_de_Regimen.BusquedaRegimen.codHotel;

            SRegimen sRegimen = new SRegimen();
            List<RegimenDTO> regimenes = sRegimen.GetAllHotel(ABM_de_Regimen.BusquedaRegimen.codHotel);
            cboDescrip.DisplayMember = "descripcion";
            cboDescrip.ValueMember = "codigo";
            cboDescrip.DataSource = regimenes;

            if (codReg != 0)
                cargarFormulario();

        }
    }
}
