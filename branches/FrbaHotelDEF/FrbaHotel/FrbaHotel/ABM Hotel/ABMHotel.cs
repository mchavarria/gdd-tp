using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_Hotel
{
    public partial class ABMHotel : Form
    {
        public ABMHotel()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (codHotel == 0)
                {
                    Hotel hotel = sHotel.GetByDireccion(txtCalle + " " + txtNumCalle);
                    if (hotel != null)
                        MessageBox.Show("Ya existe un hotel en esa dirección!");
                    else
                    {
                        BuildHotel();
                    }
                }
                else
                {
                    //CARGAR MODIFICACIONES hotel
                    
                    Hotel hotel = sHotel.GetByDireccion(txtCalle + " " + txtNumCalle);
                    if (hotel != null)
                        MessageBox.Show("Ya existe un hotel en esa dirección!");
                    else
                        BuildHotel();
                }
                ABM_Hotel.BusquedaHotel.ventanaHotel.cargate();
            }
        }

        private void BuildHotel()
        {
            Hotel hotel = new Hotel();

            if (codHotel != 0)
            {
                hotel = sHotel.GetByCod(codHotel);
                hotel.codigo = codHotel;
            }

            hotel.nombre = txtNombre.Text;
            hotel.telefono = decimal.Parse(txtTelefono.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString());
            hotel.recarga_estrella = numUpDnCantEstrellas.Value;
            hotel.mail = txtMail.Text;
            hotel.fecha_creacion = Convert.ToDateTime(txtFecha.Text);
            hotel.ciudad = txtCiudad.Text;
            hotel.nom_calle = txtCalle.Text;
            hotel.num_calle = decimal.Parse(txtNumCalle.Text);
            hotel.pais = txtPais.Text;
            hotel.administrador = Login.Log.user;
            hotel.recarga_estrella = numUpDownRecEstrella.Value;

            if (codHotel == 0)
            {
                codHotel = sHotel.Save(hotel);
                altaRegimen(codHotel);
            }
            else
            {
                sHotel.Update(hotel);//solo se puede dar de altas regimenes, no modifcarlos desde el abm de hotel
            }

            MessageBox.Show("Operación exitosa!");
        }

        private void altaRegimen(decimal codHotel) 
        {
            List<Regimen> regimenes = sRegimen.GetAll();
            List<Regimen> regimenesAlta = new List<Regimen>();

            foreach (int indexChecked in ckLstRegimenes.CheckedIndices)
            {
                string descrip = ckLstRegimenes.Text[indexChecked].ToString();

                foreach (Regimen regimen in regimenes)
                {
                    if (descrip == regimen.descripcion)
                        sRegimen.SaveDTO(regimen, codHotel);
                }
            }
        }

        private bool validar()
        {
            if (
            txtCiudad.Text.Trim() != "" && 
            txtCalle.Text.Trim() != "" &&
            txtMail.Text.Trim() != "" &&
            txtFecha.Text.Trim() != "" &&
            txtPais.Text.Trim() != "" &&
            ckLstRegimenes.SelectedValue != null &&
            numUpDnCantEstrellas.Value != 0 &&
            txtNombre.Text.Trim() != "" &&
            txtNumCalle.Text.Trim() != "" &&
            txtTelefono.Text.Trim() != "")

                return true;
            else
            {
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

        static public decimal codHotel = 0;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtFecha.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            ckLstRegimenes.ClearSelected();
            numUpDnCantEstrellas.Value = 0;
        }

        private void ABMHotel_Load(object sender, EventArgs e)
        {
            codHotel = ABM_Hotel.BusquedaHotel.hotelSelected;

            SRegimen sRegimen = new SRegimen();
            List<Regimen> regimenes = sRegimen.GetAll();
            ckLstRegimenes.DisplayMember = "descripcion";
            ckLstRegimenes.ValueMember = "codigo";
            ckLstRegimenes.DataSource = regimenes;
            
            if (codHotel != 0)
                cargarFormulario();
            
        }

        SHotel sHotel = new SHotel();
        SRegimen sRegimen = new SRegimen();

        private void cargarFormulario()
        {
            Hotel hotel = sHotel.GetByCod(codHotel);

            cargarRegimenes();

            txtCalle.Text = hotel.nom_calle;
            txtMail.Text = hotel.mail;
            txtNombre.Text = hotel.nombre;
            txtNumCalle.Text = hotel.num_calle.ToString();
            txtTelefono.Text = hotel.telefono.ToString();
            txtCiudad.Text = hotel.ciudad;
            txtPais.Text = hotel.pais;
            txtFecha.Text = hotel.fecha_creacion.ToShortDateString();
            numUpDnCantEstrellas.Value = hotel.cant_estrellas;
            btnCalendario.Enabled = false;
        }

        private void cargarRegimenes()
        {
            Hotel hotel = sHotel.GetByCod(codHotel);

            List<RegimenDTO> regimenesHotel = sRegimen.GetAllHotel(hotel.codigo);
            
            for (int i = 0; i <= (ckLstRegimenes.Items.Count - 1); i++)
            {
                string descrip = ckLstRegimenes.Text[i].ToString();
                var checkear = false;

                foreach (RegimenDTO regimen in regimenesHotel) {
                    if (descrip == regimen.descripcion) checkear = true;
                }
                if (checkear)
                    ckLstRegimenes.SetItemCheckState(i, CheckState.Checked);
                else
                    ckLstRegimenes.SetItemCheckState(i, CheckState.Unchecked);
            }
            ckLstRegimenes.Enabled = false;
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendFecha.Visible = true;
        }

        private void calendFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = e.Start.ToShortDateString();
        }
    }
}
