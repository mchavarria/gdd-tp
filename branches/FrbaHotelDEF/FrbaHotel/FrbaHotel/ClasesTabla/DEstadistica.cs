using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DEstadistica
    {

        EntidadBase entidadBase = new EntidadBase();

        public List<HotelEstadistica> EstadisticaTopHotelReservaCancelada(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.EstadisticaTopHotelReservaCancelada '" + trim + "',"+anio );
            List<HotelEstadistica> hoteles = new List<HotelEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                HotelEstadistica hotel = new HotelEstadistica();
                hotel.nom_calle = r.Field<string>("nom_calle");
                hotel.num_calle = r.Field<decimal>("num_calle");
                hotel.nombre = r.Field<string>("nombre");
                hotel.pais = r.Field<string>("pais");
                hotel.ciudad = r.Field<string>("ciudad");
                hotel.cantReservaCanceladas = r.Field<int>("cantReservaCanceladas");
                hoteles.Add(hotel);
            }
            return hoteles;
        }


    }
}
