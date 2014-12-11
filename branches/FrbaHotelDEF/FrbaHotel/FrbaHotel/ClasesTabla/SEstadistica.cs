using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SEstadistica
    {
        private DEstadistica _estadisticaDao;
        private DEstadistica estadisticaDao
        {
            get
            {
                if (_estadisticaDao == null)
                    _estadisticaDao = new DEstadistica();
                return _estadisticaDao;
            }
        }

        public List<HotelEstadistica> EstadisticaTopHotelReservaCancelada(string trim, int anio) {
            return estadisticaDao.EstadisticaTopHotelReservaCancelada(trim, anio);
        }


    }
}
