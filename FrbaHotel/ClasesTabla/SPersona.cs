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

        public List<Persona> GetAllActivos()
        {
            return perDao.GetAllActivos();
        }

        public List<Persona> GetBySQL(string consulta)
        {
            return perDao.GetBySQL(consulta);
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
    }
}
