using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaHotel.Login
{
    class Usuarios:Conexion
    {
        private string usuario;
        private string password;

        public Usuarios()
        {
            usuario = string.Empty;
            password = string.Empty;
            this.sql = string.Empty;
        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public bool Buscar()
        {
            bool Resultado = false;
            //[GD2C2014].[GESTION_DE_INFARTOS].usuarios
            this.sql = string.Format(@"SELECT id_usuario FROM [GD2C2014].[GESTION_DE_INFARTOS].usuarios WHERE nombre_usuario = '{0}' AND password= '{1}'", this.usuario, this.password);
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandoSql.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "Bienvenido!";
            }
            else
            {
                this.mensaje = "Datos ingresados incorrectos. Verifique";
            }
            this.conn.Close();

            return Resultado;
        }
    }
}
