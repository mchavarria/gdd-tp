using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SReserva
    {
        private DReserva _reservaDAO;
        private DReserva reservaDAO
        {
            get
            {
                if (_reservaDAO == null)
                    _reservaDAO = new DReserva();
                return _reservaDAO;
            }
        }
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

        public decimal Save(Reserva reserva)
        {
            return reservaDAO.Save(reserva);
        }

        //Asocia la resera con las distintas habitaciones que se relacionan
        public void asociarReservaHabitacciones(List<HabitacionDTO> habSeleccionadas, decimal num_reserva)
        {
            foreach (HabitacionDTO hab in habSeleccionadas)
            {
                reservaDAO.asociarReservaHabitacion(hab.numero, num_reserva);
            }
        }

        //Obtiene la reserva por codigo
        public Reserva getReserva(string num_reserva)
        {
            return reservaDAO.getReserva(num_reserva);
        }

        public void actualizarReserva(Reserva reserva)
        {
            reservaDAO.update(reserva);
        }

        //Audita la reserva
        public void auditarReserva(Reserva reserva, string fecha, string motivo)
        {
            reservaDAO.auditarReserva(reserva, fecha, motivo);
        }

        //Cancela la reserva
        public void cancelarReserva(Reserva reserva)
        {
            reservaDAO.cancelarReserva(reserva);
        }

        public Reserva getReservaParaCheck(string num_reserva)
        {
            return reservaDAO.getReservaParaCheck(num_reserva);
        }

        public void ingresarReserva(string num_reserva)
        {
            reservaDAO.ReservaIngresada(num_reserva);
        }
    }
}