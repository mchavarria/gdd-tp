using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SRol
    {
        private DRol _rolDao;
        private DRol rolDao
        {
            get
            {
                if (_rolDao == null)
                    _rolDao = new DRol();
                return _rolDao;
            }
        }

        public List<Rol> GetRolesUser(decimal codUser)
        {
            return rolDao.GetRolesUser(codUser);
        }

        public List<Rol> GetRolAsig()
        {
            return rolDao.GetBySQL("select * from hotel.Rol r where r.descripcion <> 'Guest'");
        }

        public List<Rol> GetAll()
        {
            return rolDao.GetAllTODOS();
        }

        public List<Rol> GetAllActivos()
        {
            return rolDao.GetAllActivos();
        }

        public List<Rol> GetBySQL(string consulta)
        {
            return rolDao.GetBySQL(consulta);
        }

        public decimal Save(Rol rol, decimal codFuncionNEW)
        {
            return rolDao.Save(rol, codFuncionNEW);
        }

        public void Update(Rol rol, decimal codFuncionNEW)
        {
            rolDao.Update(rol, codFuncionNEW);
        }

        public void Delete(decimal codigo)
        {
            rolDao.Delete(codigo);
        }
    }
}