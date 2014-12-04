using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class ABMUser : Form
    {
        public ABMUser()
        {
            InitializeComponent();
        }

        public string SHA256Encripta(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        static public decimal valorL = 0;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            cboHotel.SelectedValue = 1;
            txtMail.Text = "";
            txtNacimiento.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtNumDNI.Text = "";
            txtPassword.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            cboRol.SelectedValue = 1;
            cboTipoDNI.SelectedValue = 1;
            calendNacimiento.Visible = false;
        }

        SUsuario sUsuario = new SUsuario();
        SPersona sCliente = new SPersona();
        EntidadBase entidadBase = new EntidadBase();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validar()){
                if(valorL == 0){
                Usuario usuario = sUsuario.GetByUser(txtUser.Text);
                if(usuario != null)
                    MessageBox.Show("El usuario ya está asignado, elija otro nombre.");
                else{
                    List<Persona> clientesMail = sCliente.GetByMail(txtMail.Text);
                    if(clientesMail.Count != 0)
                        MessageBox.Show("El mail debe ser único! Ya está registrado.");
                    else
                        BuildUsuario();
                }
                }else{
                    /*Usuario user = sUsuario.GetByUser(txtUser.Text);
                    Persona per = sCliente.GetByCod(decimal.Parse(user.cod_persona.ToString()));
                    if(txtMail.Text != per.mail){
                        List<Persona> clientesMail = sCliente.GetByMail(txtMail.Text);
                        if (clientesMail.Count != 0)
                            MessageBox.Show("El mail debe ser único! Ya está registrado.");
                    }
                    else*/
                        BuildUsuario();
                }
            }
        }

        private void BuildUsuario()
        {
            Usuario usuario = new Usuario();
            
            Usuario user = sUsuario.GetByUser(txtUser.Text);
            if (user != null)
                usuario = user;
            
            Persona per = new Persona();

            if (valorL != 0){
                usuario.codigo = valorL;
                per = sCliente.GetByCod(decimal.Parse(user.cod_persona.ToString()));
            }
                 
            per.num_doc = decimal.Parse(txtNumDNI.Text);
            per.nombre = txtNombre.Text;
            per.apellido = txtApellido.Text;
            per.codigo_tipo_doc = int.Parse(cboTipoDNI.SelectedValue.ToString());
            per.mail = txtMail.Text;
            string tel = txtTelefono.Text.Replace('-',' ').Replace(" ","").Trim().ToString();
            per.telefono = decimal.Parse(tel);
            per.nom_calle = txtCalle.Text;
            per.num_calle = decimal.Parse(txtNumCalle.Text);
            per.fecha_nacimiento = DateTime.Parse(txtNacimiento.Text);
            per.estado = true;

            decimal codPer;
            if(valorL == 0)
                codPer = sCliente.Save(per);
            else
                codPer = sCliente.Update(per);

            string encriptadaContra = SHA256Encripta(txtPassword.Text);
            usuario.user_nombre = txtUser.Text;
            usuario.user_password = encriptadaContra;
            usuario.logueado = 0;
            usuario.intentos_fallidos = 0;
            usuario.cod_persona = codPer;
            usuario.estado = true;

            decimal codUsuario;
            if (valorL == 0){
                codUsuario = sUsuario.Save(usuario);
                entidadBase.EjecutarSQL("insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (" + codUsuario.ToString() + "," + cboHotel.SelectedValue.ToString() + ")");
            }
            else {
                codUsuario = sUsuario.Update(usuario);
                entidadBase.EjecutarSQL("insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (" + codUsuario.ToString() + "," + cboHotel.SelectedValue.ToString() + ")");
            }

            MessageBox.Show("Operación exitosa!");
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendNacimiento.Visible = true;
        }

        private void calendNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNacimiento.Text = e.Start.ToShortDateString();
        }

        private void ABMUser_Load(object sender, EventArgs e)
        {
            if (ABM_de_Usuario.BusquedaUser.usuarioSelected != 0)
                cargarFormulario(ABM_de_Usuario.BusquedaUser.usuarioSelected);

            SHotel sHotel = new SHotel();
            List<Hotel> hoteles = sHotel.GetAllActivos();
            cboHotel.DisplayMember = "direccionCompleta";
            cboHotel.ValueMember = "codigo";
            cboHotel.DataSource = hoteles;

            SRol SRol = new SRol();
            List<Rol> roles = SRol.GetRolAsig();
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "codigo";
            cboRol.DataSource = roles;

            STipoDoc stip = new STipoDoc();
            List<TipoDoc> tipos = stip.GetAll();
            cboTipoDNI.DisplayMember = "descripcion";
            cboTipoDNI.ValueMember = "codigo";
            cboTipoDNI.DataSource = tipos;
        }

        private void cargarFormulario(decimal codUsuario)
        {
            Usuario usuario = sUsuario.GetByCod(codUsuario);
            valorL = usuario.codigo;
            List<Persona> per = sCliente.GetBySQL("hotel.SP_GETPERSONAUsuario " + valorL);
            Persona persona = per.Single();

            SHotel sHotel = new SHotel();
            List<Hotel> hoteles = sHotel.GetBySQL("hotel.SP_GETHOTELESDEUSUARIO " + valorL);
            cboHotel.DisplayMember = "direccionCompleta";
            cboHotel.ValueMember = "codigo";
            cboHotel.DataSource = hoteles;

            SRol sRol = new SRol();
            List<Rol> roles = sRol.GetRolesUser(valorL);
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "codigo";
            cboRol.DataSource = roles;

            txtApellido.Text = persona.apellido ;
            txtCalle.Text = persona.nom_calle;
            txtMail.Text = persona.mail;
            txtNacimiento.Text = persona.fecha_nacimiento.ToString();
            txtNombre.Text = persona.nombre;
            txtNumCalle.Text = persona.num_calle.ToString();
            txtNumDNI.Text = persona.num_doc.ToString();
            txtPassword.Text = usuario.user_password;
            txtTelefono.Text = persona.telefono.ToString();
            txtUser.Text = usuario.user_nombre;
            cboTipoDNI.SelectedValue = persona.codigo_tipo_doc;
        }

        private bool validar()
        {
            if (
            txtApellido.Text.Trim() != "" &&
            txtCalle.Text.Trim() != "" &&
            cboHotel.Text.Trim() != "" &&
            txtMail.Text.Trim() != "" &&
            txtNacimiento.Text.Trim() != "" &&
            txtNombre.Text.Trim() != "" &&
            txtNumCalle.Text.Trim() != "" &&
            txtNumDNI.Text.Trim() != "" &&
            txtPassword.Text.Trim() != "" &&
            txtTelefono.Text.Trim() != "" &&
            txtUser.Text.Trim() != "" &&
            cboRol.Text.Trim() != "" &&
            cboTipoDNI.Text.Trim() != "")

                return true;
            else{
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

    }
}
