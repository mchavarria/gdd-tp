using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class SReserva
    {
        public Reserva GetReserva(string codigoReserva)
        {
            EntidadBase entidadBase = new EntidadBase();
            DataTable TableFunc = entidadBase.TraerDatos("select r.codigo from hotel.reserva r where r.codigo = " + codigoReserva);
            Reserva reserva = new Reserva();

            if (TableFunc.Rows.Count == 0)
            {
                return null;
            }
            decimal codigo = TableFunc.Rows[0].Field<decimal>("codigo");
            reserva.codigo = codigo;
            return reserva;
        }

        internal bool isAllInclusive(string codigoReserva)
        {
            EntidadBase entidadBase = new EntidadBase();
            string query = string.Format("select hotel.isAllInclusive({0}) ",
                int.Parse(codigoReserva));

            bool resultado = (bool) entidadBase.EjecutarFuncionEscalarSQL(query);

            return resultado;
        }
    }
}
