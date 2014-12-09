using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DHabitacion
    {
        EntidadBase entidadBase = new EntidadBase();

        //Devuelve las habitaciones disponible para el hotel en las fechas elegidas
        public List<HabitacionDTO> GetDisponiblesPorHotelyFechas(string hotel, string desde, string hasta)
        {
            DataTable table = entidadBase.TraerDatos("hotel.SP_GETHAB_DISPporHotel " + this.ArmarValores(hotel,desde,hasta));
            List<HabitacionDTO> habitaciones = new List<HabitacionDTO>();

            foreach (DataRow r in table.Rows)
            {
                HabitacionDTO habitacion = new HabitacionDTO();
                habitacion.numero = r.Field<decimal>("cod_habitacion");
                habitacion.descripcion = r.Field<string>("descripcion");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        public List<HabitacionDTO> getHabitacionesByReserva(string hotel, string reserva)
        {
            DataTable table = entidadBase.TraerDatos("hotel.SP_GETHAB_BY_RESERVA " + hotel + "," + reserva);
            List<HabitacionDTO> habitaciones = new List<HabitacionDTO>();

            foreach (DataRow r in table.Rows)
            {
                HabitacionDTO habitacion = new HabitacionDTO();
                habitacion.numero = r.Field<decimal>("cod_habitacion");
                habitacion.descripcion = r.Field<string>("descripcion");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        //Devuelve el precio de una habitacion en particular
        public string GetPrecioByHabitacion(string hotel, string habitacion, string regimen)
        {
            
            DataTable precioBase = entidadBase.TraerDatos("select (hotel.FN_GET_PRECIO_BASE ("+habitacion+","+hotel+","+regimen+"))");
            DataRow reg = precioBase.Rows[0];

            return Convert.ToString(reg[0]);
        }

        public string getPrecioByRegimen(string hotel, string regimen)
        {
            DataTable precio = entidadBase.TraerDatos("select precio_base from hotel.Regimen_Hotel where cod_hotel = " + hotel + " and estado = 1 and cod_regimen = " + regimen);
            DataRow reg = precio.Rows[0];

            return Convert.ToString(reg[0]);
        }

        private string ArmarValores(string hotel, string desde, string hasta)
        {
            StringBuilder Valores = new StringBuilder();
            Valores.Append(hotel + ",");
            Valores.Append("'" + desde + "',");
            Valores.Append("'" + hasta + "'");

            return Valores.ToString();
        }

        public string getRecargaEstrellaHotel(string hotel)
        {
            DataTable recargaEstrella = entidadBase.TraerDatos("SELECT h.recarga_estrella FROM hotel.Hotel h WHERE h.codigo =" + hotel);
            DataRow row = recargaEstrella.Rows[0];
            return Convert.ToString(row[0]);
        }

        public string getTipoHabitacionByDescripcion(string descripcion)
        {
            DataTable tipoHabitacion = entidadBase.TraerDatos("SELECT codigo FROM hotel.Tipo_Habitacion ha WHERE ha.descripcion like '%" + descripcion + "%'");
            DataRow row = tipoHabitacion.Rows[0];
            return Convert.ToString(row[0]);
        }

    }
}
