using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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
            this.sql = string.Format(@"SELECT codigo FROM [GD2C2014].[GESTION_DE_INFARTOS].usuarios WHERE nombre = '{0}' AND password= '{1}' AND logueado = '0'", this.usuario, this.password);
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandoSql.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "Bienvenido!";

                Reg.Close();
                this.sql = string.Format(@"UPDATE [GD2C2014].[GESTION_DE_INFARTOS].usuarios SET logueado = '1' WHERE nombre = '{0}' AND password= '{1}'", this.usuario, this.password);
                this.comandoSql = new SqlCommand(this.sql, this.conn);
                this.comandoSql.ExecuteNonQuery();
            }
            else
            {
                this.mensaje = "Datos ingresados incorrectos. Verifique";
            }
            this.conn.Close();

            return Resultado;
        }

        internal List<string> GetModulos()
        {
            this.sql = string.Format("select * from GESTION_DE_INFARTOS.getFuncionalidades(@Usuario);", usuario);
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.comandoSql.Parameters.AddWithValue("@Usuario", usuario);
            List<string> modulos = new List<string>();

            try
            {
                this.conn.Open();
                SqlDataReader Reg = this.comandoSql.ExecuteReader();
                while (Reg.Read())
                {
                    modulos.Add(Reg[0].ToString());
                }
                Reg.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return modulos;
        }

        internal void LogOut()
        {
            this.sql = string.Format(@"UPDATE [GD2C2014].[GESTION_DE_INFARTOS].usuarios SET logueado = 0 WHERE nombre = '{0}'", this.usuario);
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            this.comandoSql.ExecuteNonQuery();
            
            this.conn.Close();
        }
    }
}
