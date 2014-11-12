using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SHotel
    {
            private DHotel _hotelDao;
            private DHotel hotelDao
            {
                get
                {
                    if (_hotelDao == null)
                        _hotelDao = new DHotel();
                    return _hotelDao;
                }
            }

            public List<Hotel> GetAllActivos()
            {
                return hotelDao.GetAllActivos();
            }

            public List<Hotel> GetBySQL(string consulta)
            {
                return hotelDao.GetBySQL(consulta);
            }

            public decimal Save(Hotel hotel)
            {
                return hotelDao.Save(hotel);
            }

            public void Update(Hotel hotel)
            {
                hotelDao.Update(hotel);
            }

            public void Delete(int codigo)
            {
                hotelDao.Delete(codigo);
            }
    }
}
