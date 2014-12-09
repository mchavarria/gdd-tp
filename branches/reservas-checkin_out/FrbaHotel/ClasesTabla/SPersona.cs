using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SPersona
    {
        private DPersona _perDao;
        private DPersona perDao
        {
            get
            {
                if (_perDao == null)
                    _perDao = new DPersona();
                return _perDao;
            }
        }

        public List<Persona> GetByMail(string mail)
        {
            return perDao.GetByMail(mail);
        }

        public List<Persona> GetByMailToValidate(string mail,string codigo)
        {
            return perDao.GetByMailToValidate(mail,codigo);
        }

        public List<Persona> GetAllActivos()
        {
            return perDao.GetAllActivos();
        }

        public List<Persona> GetBySQL(string consulta)
        {
            return perDao.GetBySQL(consulta);
        }

        public Persona getByCodigo(string codigo)
        {
            return perDao.getByCodigo(codigo);
        }

        public decimal Save(Persona per)
        {
            return perDao.Save(per);
        }

        public decimal Update(Persona per)
        {
            return perDao.Update(per);
        }

        public void Delete(decimal codigo)
        {
            perDao.Delete(codigo);
        }

        public List<Persona> GetByGrilla(string nombre, string apellido, string tipoDni, string dni, string email)
        {
            return perDao.GetBySQL(ordernarItemsParaConsulta(nombre,apellido,tipoDni,dni,email));
        }

        public string ordernarItemsParaConsulta(string nombre, string apellido, string tipoDni, string dni, string email)
        {
            StringBuilder consulta = new StringBuilder();
            bool inicial = true;
            consulta.Append("SELECT * FROM hotel.Persona ");
            string sqlWhere = " p WHERE ";
            
            if (nombre != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.nombre LIKE '%" + nombre + "%'");
            }
            if (apellido != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.apellido LIKE '%" + apellido + "%'");
            }
            if (tipoDni != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.codigo_tipo_doc = " + tipoDni);
            }
            if (dni != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.num_doc = " + dni);
            }
            if (email != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.mail LIKE '%" + email + "%'");
            }
            return consulta.ToString();
        }
    }
}
