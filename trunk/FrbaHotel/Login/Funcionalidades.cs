using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    class Funcionalidades : Conexion
    {
        private string codigo;
        private string descripcion;

        public Funcionalidades()
        {
            codigo = string.Empty;
            descripcion = string.Empty;
            this.sql = string.Empty;
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

        public DataSet buscarFuncionalidades()
        {
            this.sql = "select * from GESTION_DE_INFARTOS.funcionalidad;";
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.sql, this.conn))
                {
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    this.conn.Close();
                    return dataSet;
                }
        }

        public DataSet buscarFuncionalidadesPorRol(string codigoRol)
        {
            this.sql = string.Format("select * from GESTION_DE_INFARTOS.getFuncionalidadesPorRol('{0}');", codigoRol);
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                    this.sql, this.conn))
            {
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                this.conn.Close();
                return dataSet;
            }
        }

        public void altaRol(string descripcion, int estado, string parametrosAltaRol)
        {
            this.sql = "GESTION_DE_INFARTOS.alta_rol";
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.comandoSql.CommandType = CommandType.StoredProcedure;
            this.comandoSql.Parameters.AddWithValue("@Descripcion", SqlDbType.VarChar).Value = descripcion;
            this.comandoSql.Parameters.AddWithValue("@Estado", SqlDbType.Bit).Value = estado;
            this.comandoSql.Parameters.AddWithValue("@Codigos_Funciones", SqlDbType.VarChar).Value = parametrosAltaRol;

            try
            {
                this.conn.Open();
                this.comandoSql.ExecuteNonQuery();
                this.conn.Close();
            }
            finally
            {
                this.conn.Close();
            }
        }

        public DataSet buscarRoles(string codigo, string descripcion, string estado)
        {
            // int cod_estado = -1;
            // if (estado == "Activo"){ cod_estado = 1;}
            // else if (estado == "Inactivo") { cod_estado = 0; }
            //TODO fijar los filtros
            this.sql = "select * from GESTION_DE_INFARTOS.roles;";
            this.comandoSql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                    this.sql, this.conn))
            {
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                this.conn.Close();
                return dataSet;
            }
        }
    }
}
