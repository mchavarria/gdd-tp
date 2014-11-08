using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaHotel.Login
{
    class Conexion
    {
        public String cadenaConexion;
        protected String sql;
        protected SqlConnection conn;
        protected SqlCommand comandoSql;
        protected String mensaje;

        public Conexion() {
            ConnectionStringSettings connetionStringSettings = ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Database1ConnectionString"];
            this.cadenaConexion = connetionStringSettings.ConnectionString;
            this.conn = new SqlConnection(this.cadenaConexion);
        }

        public string Mensaje {
            get {
                return this.mensaje;
            }
        }
    }
}
